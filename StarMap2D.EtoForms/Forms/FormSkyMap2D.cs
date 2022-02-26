#region License
/*
MIT License

Copyright(c) 2022 Petteri Kautonen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AASharp;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Calculations.Enumerations;
using StarMap2D.Calculations.Helpers;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.Common.SvgColorization;
using StarMap2D.Common.Utilities;
using StarMap2D.EtoForms.Classes;
using StarMap2D.EtoForms.Controls;
using StarMap2D.EtoForms.Controls.EventArguments;
using StarMap2D.EtoForms.Controls.Utilities;
using StarMap2D.EtoForms.Properties;
using StarMap2D.Localization;
using VPKSoft.StarCatalogs.Providers;

namespace StarMap2D.EtoForms.Forms
{
    /// <summary>
    /// A form to display a sky map.
    /// Implements the <see cref="Eto.Forms.Form" />
    /// </summary>
    /// <seealso cref="Eto.Forms.Form" />
    public class FormSkyMap2D : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormSkyMap2D"/> class.
        /// </summary>
        public FormSkyMap2D()
        {
            // Set the software localization.
            UI.Culture = Globals.Locale;


            MinimumSize = new Size(1024, 768);

            InitializeView();

            LoadEmbeddedCatalog();
            LoadSettings();
            CreateSolarSystemObjects();
            Shown += FormSkyMap2D_Shown;
        }

        private void FormSkyMap2D_Shown(object? sender, EventArgs e)
        {
            splitter!.Position = ClientSize.Width - 250;
        }

        private Splitter? splitter;
        private TableLayout? mapControlLayout;
        private DateTimePicker? dateTimePickerJump;
        private NumericStepper? nsSpeedPerTimeAmount;
        private ComboBox? cmbTimeUnit;
        private UITimer timer = new() { Interval = 0.2, };
        private CheckedButton? buttonPlayPause;

        private void ElapsedHandler(object? sender, EventArgs e)
        {
            map2d.DateTimeUtc = DateTime.UtcNow;
        }

        private readonly List<EnumStringItem<TimeInterval>> timeDataSource = new(new[]
        {
            new EnumStringItem<TimeInterval>(TimeInterval.Millisecond, Units.MilliSeconds),
            new EnumStringItem<TimeInterval>(TimeInterval.Second, Units.Seconds),
            new EnumStringItem<TimeInterval>(TimeInterval.Minute, Units.Minutes),
            new EnumStringItem<TimeInterval>(TimeInterval.Hour, Units.Hours),
            new EnumStringItem<TimeInterval>(TimeInterval.Day, Units.Days),
            new EnumStringItem<TimeInterval>(TimeInterval.Week, Units.Weeks),
            new EnumStringItem<TimeInterval>(TimeInterval.Month, Units.Months),
            new EnumStringItem<TimeInterval>(TimeInterval.Year, Units.Years),
        });

        private void InitializeView()
        {
            //            Content = map2d;
            map2d.Plot2D = new(Globals.Settings.Latitude, Globals.Settings.Longitude)
            {
                Diameter = Math.Min(map2d.Width, map2d.Height)
            };


            splitter = new Splitter { Orientation = Orientation.Horizontal };

            Content = splitter;
            splitter.Panel1 = map2d;

            mapControlLayout = new TableLayout();
            splitter.Panel2 = mapControlLayout;

            dateTimePickerJump = new DateTimePicker { Mode = DateTimePickerMode.DateTime, Value = DateTime.Now, };

            mapControlLayout.Rows.Add(EtoHelpers.LabelWrapperWithButton(UI.SpecifyDateTimeTitle, null,
                dateTimePickerJump, (_, _) => map2d.DateTimeUtc = dateTimePickerJump.Value?.ToUniversalTime() ?? DateTime.UtcNow,
                StarMap2D.EtoForms.Controls.Properties.Resources.ic_fluent_arrow_right_48_filled, Colors.SteelBlue));


            nsSpeedPerTimeAmount = new NumericStepper { MinValue = 1, MaxValue = int.MaxValue, };

            cmbTimeUnit = new ComboBox { ItemTextBinding = new PropertyBinding<string>(nameof(EnumStringItem<TimeInterval>.EnumName)) };

            mapControlLayout.Rows.Add(
                EtoHelpers.LabelWrapperWithControls(UI.SpeedPerTimeUnit, 5, 5, nsSpeedPerTimeAmount,
                    cmbTimeUnit,
                    // A reset button for the date and time jumping.
                    EtoHelpers.CreateImageButton(SvgColorize.FromBytes(StarMap2D.EtoForms.Controls.Properties.Resources.ic_fluent_arrow_undo_48_filled), Colors.SteelBlue, 6,
                        (_, _) =>
                        {
                            TimeUpdate = false;
                            dateTimePickerJump.Value = DateTime.Now;
                            map2d.DateTimeUtc = DateTime.UtcNow;
                        })));

            cmbTimeUnit.DataStore = timeDataSource;
            cmbTimeUnit.SelectedValue = timeDataSource.First(f => f.EnumValue == TimeInterval.Second);

            buttonPlayPause = new CheckedButton(delegate (object? _, CheckedChangeEventArguments args)
                {
                    TimeUpdate = args.Checked;
                }
            )
            {
                CheckedSvgImage = SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_pause_48_filled),
                UncheckedSvgImage = SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_play_48_filled),
            };

            mapControlLayout.Rows.Add(EtoHelpers.LabelWrap("PlayPause", buttonPlayPause));

            timer.Elapsed += ElapsedHandler;

            // Leave this to the last!
            mapControlLayout.Rows.Add(new TableRow { ScaleHeight = true });
        }

        private bool InvertEastWest => map2d.InvertEastWest;
        private bool timeUpdate;
        private List<SolarSystemObjectGraphics> solarSystemObjects = new();

        private bool TimeUpdate
        {
            get => timeUpdate;

            set
            {
                if (value != timeUpdate)
                {
                    timeUpdate = value;
                    if (timer.Started && !value)
                    {
                        timer.Stop();
                    }
                    else if (!timer.Started && value)
                    {
                        timer.Start();
                    }
                }
            }
        }

        private void CreateSolarSystemObjects()
        {
            string LowerCaseFirstUpper(string value)
            {
                value = value.ToLower();

                var upperStart = value[0].ToString().ToUpper()[0];

                value = upperStart + value.Remove(0, 1);
                return value;
            }

            var tabDeli = LocalizationProvider.SolarSystemObjectLocalization;

            if (map2d.Plot2D == null)
            {
                return;
            }

            foreach (SolarSystemSmallBodies value in Enum.GetValues(typeof(SolarSystemSmallBodies)))
            {
                if (value == SolarSystemSmallBodies.Pluto) // Pluto, the special "planet".
                {
                    continue;
                }

                var solarSystemObject = solarSystemObjects.First(f => (int)f.ObjectType == (int)value);

                if (!solarSystemObject.Enabled)
                {
                    continue;
                }

                map2d.StarMapObjects.Add(new StarMapObject
                {
                    CalculatePosition = (aaDate, precision, latitude, longitude, _) =>
                        map2d.Plot2D.Project2D(
                            SolarSystemObjectPositions.GetSmallObjectPosition(value, aaDate, precision, latitude,
                                longitude), InvertEastWest),
                    ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => solarSystemObject.Image },
                    IsLocationCalculated = true,
                    ObjectName = tabDeli.GetMessage($"text{LowerCaseFirstUpper(value.ToString())}", value.ToString(), Globals.Settings.Locale!),
                    ObjectType = solarSystemObject.ObjectType,
                    Identifier = (int)value,
                });
            }

            foreach (AASEllipticalObject value in Enum.GetValues(typeof(AASEllipticalObject)))
            {
                if (value == AASEllipticalObject.SUN)
                {
                    continue;
                }

                var solarSystemObject = solarSystemObjects.First(f => (int)f.ObjectType == (int)value);

                if (!solarSystemObject.Enabled)
                {
                    continue;
                }

                map2d.StarMapObjects.Add(new StarMapObject
                {
                    CalculatePosition = (aaDate, precision, latitude, longitude, _) =>
                        map2d.Plot2D.Project2D(SolarSystemObjectPositions.GetObjectPosition(value, aaDate, precision, longitude, latitude), InvertEastWest),
                    ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => solarSystemObject.Image },
                    IsLocationCalculated = true,
                    ObjectName = tabDeli.GetMessage($"text{LowerCaseFirstUpper(value.ToString())}", nameof(value), Globals.Settings.Locale!),
                    ObjectType = solarSystemObject.ObjectType,
                    Identifier = (int)value,
                });
            }

            var sun = solarSystemObjects.First(f => f.ObjectType == ObjectsWithPositions.Sun);
            if (sun.Enabled)
            {
                map2d.StarMapObjects.Add(new StarMapObject
                {
                    CalculatePosition = (aaDate, precision, latitude, longitude, _) =>
                        map2d.Plot2D.Project2D(
                            SolarSystemObjectPositions.GetSunPosition(aaDate, precision, longitude, latitude), InvertEastWest),
                    ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => sun.Image },
                    IsLocationCalculated = true,
                    ObjectName = tabDeli.GetMessage("textSun", "Sun", Globals.Settings.Locale!),
                    ObjectType = ObjectsWithPositions.Sun,
                    Identifier = (int)ObjectsWithPositions.Sun,
                });
            }

            var moon = solarSystemObjects.First(f => f.ObjectType == ObjectsWithPositions.Moon);
            if (moon.Enabled)
            {
                map2d.StarMapObjects.Add(new StarMapObject
                {
                    CalculatePosition = (aaDate, precision, latitude, longitude, _) =>
                        map2d.Plot2D.Project2D(
                            SolarSystemObjectPositions.GetMoonPosition(aaDate, precision, longitude, latitude), InvertEastWest),
                    ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => moon.Image },
                    IsLocationCalculated = true,
                    ObjectName = tabDeli.GetMessage("textMoon", "Moon", Globals.Settings.Locale!),
                    ObjectType = ObjectsWithPositions.Moon,
                    Identifier = (int)ObjectsWithPositions.Moon,
                });
            }
        }

        private Map2D map2d = new();

        /// <summary>
        /// Loads the embedded star catalog to be used by the map.
        /// </summary>
        private void LoadEmbeddedCatalog()
        {
            var yaleBrightProvider = new YaleBrightProvider();

            using var reader = new StreamReader(new MemoryStream(Resources.YaleBrightStars));

            yaleBrightProvider.LoadData(reader.ReadAllLines());

            foreach (var yaleBrightStar in yaleBrightProvider.StarData)
            {
                map2d.StarMapObjects.Add(new StarMapObject
                {
                    RightAscension = yaleBrightStar.RightAscension,
                    Declination = yaleBrightStar.Declination,
                    Magnitude = yaleBrightStar.Magnitude
                });
            }
        }

        /// <summary>
        /// Loads the program settings.
        /// </summary>
        private void LoadSettings()
        {
            map2d.Locale = "fi";

            map2d.Plot2D.Latitude = Globals.Settings.Latitude;
            map2d.Plot2D.Longitude = Globals.Settings.Longitude;

            solarSystemObjects = SolarSystemObjectGraphics.MergeWithDefaults(Globals.Settings.KnownObjects!,
                Globals.Settings.Locale!);
        }
    }
}