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
using System.Globalization;
using System.IO;
using System.Linq;
using AASharp;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Calculations.Compass;
using StarMap2D.Calculations.Enumerations;
using StarMap2D.Calculations.Helpers;
using StarMap2D.Calculations.Helpers.DateAndTime;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.Common.SvgColorization;
using StarMap2D.Common.Utilities;
using StarMap2D.EtoForms.ApplicationSettings.SettingClasses;
using StarMap2D.EtoForms.Classes;
using StarMap2D.EtoForms.Controls;
using StarMap2D.EtoForms.Controls.EventArguments;
using StarMap2D.EtoForms.Controls.Utilities;
using StarMap2D.EtoForms.Forms.Dialogs;
using StarMap2D.EtoForms.Properties;
using StarMap2D.Localization;
using VPKSoft.StarCatalogs.Providers;

namespace StarMap2D.EtoForms.Forms;

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
        SizeChanged += FormSkyMap2D_SizeChanged;
        Closing += FormSkyMap2D_Closing;
        map2d.CoordinatesChanged += Map2d_CoordinatesChanged;
        map2d.MouseHoverObject += Map2d_MouseHoverObject;
        map2d.MouseLeaveObject += Map2d_MouseLeaveObject;
        map2d.MouseCoordinatesChanged += Map2d_MouseCoordinatesChanged;
        map2d.MouseClickObject += Map2d_MouseClickObject;
    }

    private void Map2d_MouseClickObject(object sender, Common.EventsAndDelegates.NamedObjectEventArgs e)
    {
        if (e.Identifier != null)
        {
            FormDialogCelestialObject.ShowModal((ObjectsWithPositions)e.Identifier, map2d.DateTimeUtc, map2d.Latitude,
                map2d.Longitude);
        }
    }

    private void Map2d_MouseCoordinatesChanged(object? sender, Common.EventsAndDelegates.CoordinatesChangedEventArgs e)
    {
        string format = "+000.000000;-000.000000"; // F6
        lbMouseCoordinateAzimuthValue!.Text = e.Azimuth.ToString(format, Globals.FormattingCulture);
        lbMouseCoordinateHeightValue!.Text = e.Altitude.ToString(format, Globals.FormattingCulture);
        lbMouseCoordinateRightAscensionValue!.Text = e.RightAscension.ToString(format, Globals.FormattingCulture);
        lbMouseCoordinateDeclinationValue!.Text = e.Declination.ToString(format, Globals.FormattingCulture);
        lbCompassDirectionValue!.Text = CompassDirection.FromDegrees(e.Azimuth).ValueString;
    }

    private void Map2d_MouseHoverObject(object sender, Common.EventsAndDelegates.NamedObjectEventArgs e)
    {
        if (e.Identifier == null)
        {
            return;
        }

        var details = SolarSystemObjectPositions.GetDetails((ObjectsWithPositions)e.Identifier, map2d.Plot2D!.AaDate, Globals.HighPrecisionCalculations,
            map2d.Latitude, map2d.Longitude);

        lbObjectNameValue!.Text = e.Name;
        lbRightAscensionValue!.Text = $@"{details.RightAscension.ToString("F5", Globals.FormattingCulture)}";
        lbDeclinationValue!.Text = $@"{details.Declination.ToString("F5", Globals.FormattingCulture)}";
        lbHorizontalXValue!.Text = $@"{details.HorizontalDegreesX.ToString("F1", Globals.FormattingCulture)}";
        lbHorizontalYValue!.Text = $@"{details.HorizontalDegreesY.ToString("F1", Globals.FormattingCulture)}";
        cbAboveHorizonValue!.Checked = details.AboveHorizon;
    }

    private void Map2d_MouseLeaveObject(object sender, Common.EventsAndDelegates.NamedObjectEventArgs e)
    {
        lbObjectNameValue!.Text = string.Empty;
        lbRightAscensionValue!.Text = UI.NAChar;
        lbDeclinationValue!.Text = UI.NAChar;
        lbHorizontalXValue!.Text = UI.NAChar;
        lbHorizontalYValue!.Text = UI.NAChar;
        cbAboveHorizonValue!.Checked = false;
    }

    private int PreviousSplitterSize { get; set; } = 280;

    private Splitter? splitterMain;
    private TableLayout? mapControlLayout;
    private TableLayout? objectInfoTableNameRaDec;
    private TableLayout? objectInfoTableHorizontalCoordinates;
    private TableLayout? mousePositionLayout;
    private DateTimePicker? dateTimePickerJump;
    private NumericStepper? nsSpeedPerTimeAmount;
    private ComboBox? cmbTimeUnit;
    private readonly UITimer timer = new() { Interval = 0.2, };
    private CheckedButton? buttonPlayPause;
    private CheckBox? cbInvertEastWest;
    private CheckBox? cbDrawConstellationBorders;
    private CheckBox? cbDrawConstellations;
    private CheckBox? cbDrawConstellationNames;
    private CheckBox? cbSkipCalculatedObjects;
    private CheckBox? cbDrawCrossHair;
    private readonly Map2D map2d = new();
    private ComboBox? cmbJumpLocation;
    private NumericStepper? nsLatitude;
    private NumericStepper? nsLongitude;
    private CompassView? cwCompass;
    private Label? lbObjectNameValue;
    private Label? lbRightAscensionValue;
    private Label? lbDeclinationValue;
    private Label? lbHorizontalXValue;
    private Label? lbHorizontalYValue;
    private CheckBox? cbAboveHorizonValue;
    private Label? lbMouseCoordinateHeightValue;
    private Label? lbMouseCoordinateAzimuthValue;
    private Label? lbMouseCoordinateRightAscensionValue;
    private Label? lbMouseCoordinateDeclinationValue;
    private Label? lbCompassDirectionValue;

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


        splitterMain = new Splitter { Orientation = Orientation.Horizontal };
        splitterMain.PositionChanged += SplitterMainPositionChanged;

        Content = splitterMain;
        splitterMain.Panel1 = map2d;

        mapControlLayout = new TableLayout();
        splitterMain.Panel2 = mapControlLayout;

        dateTimePickerJump = new DateTimePicker { Mode = DateTimePickerMode.DateTime, Value = DateTime.Now, };

        mapControlLayout.Rows.Add(EtoHelpers.LabelWrapperWithButton(UI.SpecifyDateTimeTitle, null,
            dateTimePickerJump, (_, _) => map2d.DateTimeUtc = dateTimePickerJump.Value?.ToUniversalTime() ?? DateTime.UtcNow,
            EtoForms.Controls.Properties.Resources.ic_fluent_arrow_right_48_filled, Colors.SteelBlue));


        // The time unit value and it's type selector combo box.
        nsSpeedPerTimeAmount = new NumericStepper { MinValue = 1, MaxValue = int.MaxValue, DecimalPlaces = 3 };

        cmbTimeUnit = new ComboBox { ItemTextBinding = new PropertyBinding<string>(nameof(EnumStringItem<TimeInterval>.EnumName)) };
        cmbTimeUnit.DataStore = timeDataSource;
        cmbTimeUnit.SelectedValue = timeDataSource.First(f => f.EnumValue == TimeInterval.Second);

        mapControlLayout.Rows.Add(
            EtoHelpers.LabelWrapperWithControls(UI.SpeedPerTimeUnit, 5, 5, nsSpeedPerTimeAmount,
                cmbTimeUnit,
                // A reset button for the date and time jumping.
                EtoHelpers.CreateImageButton(SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_undo_48_filled), Colors.SteelBlue, 6,
                    (_, _) =>
                    {
                        TimeUpdate = false;
                        dateTimePickerJump.Value = DateTime.Now;
                        map2d.DateTimeUtc = DateTime.UtcNow;
                        buttonPlayPause!.Checked = false;
                        previousDateCalculation = default;
                        previousDateTime = default;
                        cmbTimeUnit.SelectedValue = timeDataSource.First(f => f.EnumValue == TimeInterval.Second);
                        nsSpeedPerTimeAmount.Value = 1;
                        SetTitle();
                    })));

        buttonPlayPause = new CheckedButton(delegate (object? _, CheckedChangeEventArguments args)
            {
                TimeUpdate = args.Checked;
            }
        )
        {
            CheckedSvgImage = SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_pause_48_filled),
            UncheckedSvgImage = SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_play_48_filled),
        };

        // The play button, jump hour +/- buttons.
        mapControlLayout.Rows.Add(EtoHelpers.LabelWrapperWithControls(UI.Time, 5, 5,
            buttonPlayPause,
            EtoHelpers.CreateImageButton(
                SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_previous_24_filled),
                Colors.SteelBlue, 6, (_, _) =>
                {
                    map2d.DateTimeUtc = map2d.DateTimeUtc.TruncateToHours().AddHours(-1);
                    dateTimePickerJump.Value = map2d.DateTimeUtc.ToLocalTime();
                    SetTitle();
                }, UI.HourMinusOne),
            EtoHelpers.CreateImageButton(
                SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_next_24_filled),
                Colors.SteelBlue, 6, (_, _) =>
                {
                    map2d.DateTimeUtc = map2d.DateTimeUtc.TruncateToHours().AddHours(1);
                    dateTimePickerJump.Value = map2d.DateTimeUtc.ToLocalTime();
                    SetTitle();
                }, UI.HourPlusOne, ButtonImagePosition.Right)
        ));

        // Handler for the timer.
        timer.Elapsed += ElapsedHandler;

        // The check box controls.
        cbInvertEastWest = new CheckBox { Text = UI.InvertEastWest, ThreeState = false };
        cbInvertEastWest.CheckedChanged += CbInvertEastWest_CheckedChanged;
        mapControlLayout.Rows.Add(EtoHelpers.PaddingWrap(cbInvertEastWest, Globals.DefaultPadding));

        cbDrawConstellationBorders = new CheckBox { Text = UI.DrawConstellationBorders, ThreeState = false };
        cbDrawConstellationBorders.CheckedChanged += CbDrawConstellationBorders_CheckedChanged;
        mapControlLayout.Rows.Add(EtoHelpers.PaddingWrap(cbDrawConstellationBorders, Globals.DefaultPadding));

        cbDrawConstellations = new CheckBox { Text = UI.DrawConstellations, ThreeState = false };
        cbDrawConstellations.CheckedChanged += CbDrawConstellationsCheckedChanged;
        mapControlLayout.Rows.Add(EtoHelpers.PaddingWrap(cbDrawConstellations, Globals.DefaultPadding));

        cbDrawConstellationNames = new CheckBox { Text = UI.DrawConstellationNames, ThreeState = false };
        cbDrawConstellationNames.CheckedChanged += CbDrawConstellationNamesCheckedChanged;
        mapControlLayout.Rows.Add(EtoHelpers.PaddingWrap(cbDrawConstellationNames, Globals.DefaultPadding));

        cbSkipCalculatedObjects = new CheckBox { Text = UI.SkipCalculatedObjects, ThreeState = false };
        cbSkipCalculatedObjects.CheckedChanged += CbSkipCalculatedObjects_CheckedChanged;
        mapControlLayout.Rows.Add(EtoHelpers.PaddingWrap(cbSkipCalculatedObjects, Globals.DefaultPadding));

        cbDrawCrossHair = new CheckBox { Text = UI.DrawCrossHair, ThreeState = false };
        cbDrawCrossHair.CheckedChanged += CbDrawCrossHair_CheckedChanged;
        mapControlLayout.Rows.Add(EtoHelpers.PaddingWrap(cbDrawCrossHair, Globals.DefaultPadding));

        // The geographic location change controls.
        cmbJumpLocation = new ComboBox { AutoComplete = true };
        cmbJumpLocation.DataStore = Cities.CitiesList;
        cmbJumpLocation.ItemTextBinding = new PropertyBinding<string>(nameof(CityLatLonCoordinate.CityName));

        mapControlLayout.Rows.Add(EtoHelpers.LabelWrapperWithControls(UI.JumpToLcation, Globals.DefaultPadding,
            Globals.DefaultPadding,
            cmbJumpLocation,
            EtoHelpers.CreateImageButton(
                SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_undo_48_filled),
                Colors.SteelBlue, 6, RevertLocation_Click)
        ));

        nsLatitude = new NumericStepper { DecimalPlaces = 10, MinValue = -90, MaxValue = 90 };
        nsLongitude = new NumericStepper { DecimalPlaces = 10, MinValue = -180, MaxValue = 180 };

        mapControlLayout.Rows.Add(new TableLayout(new TableRow(
            new TableCell(
                EtoHelpers.LabelWrap(UI.Latitude, nsLatitude),
                true),
            new TableCell(
                EtoHelpers.LabelWrap(UI.Longitude, nsLongitude),
                true))));

        // The object information controls.

        Font font = Globals.Settings.DataFont ?? SettingsFontData.Empty;

        lbObjectNameValue = new Label { Text = UI.NAChar, TextColor = Colors.SteelBlue, Font = font, };
        lbRightAscensionValue = new Label { Text = UI.NAChar, TextColor = Colors.SteelBlue, Font = font, };
        lbDeclinationValue = new Label { Text = UI.NAChar, TextColor = Colors.SteelBlue, Font = font, };
        lbHorizontalXValue = new Label { Text = UI.NAChar, TextColor = Colors.SteelBlue, Font = font, };
        lbHorizontalYValue = new Label { Text = UI.NAChar, TextColor = Colors.SteelBlue, Font = font, };
        cbAboveHorizonValue = new CheckBox { ThreeState = false, Text = UI.AboveHorizon, };

        objectInfoTableNameRaDec =
            FluentTableLayoutBuilder.New()
                .WithRow(Globals.DefaultPadding,
                    EtoHelpers.PaddingWrap(new Label { Text = UI.ObjectName }, Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(lbObjectNameValue, Globals.DefaultPadding))
                .WithRow(Globals.DefaultPadding, EtoHelpers.LabelWrap(UI.RightAscension, lbRightAscensionValue),
                    EtoHelpers.LabelWrap(UI.Declination, lbDeclinationValue))
                .GetTable();

        objectInfoTableHorizontalCoordinates = FluentTableLayoutBuilder.New()
            .WithRow(Globals.DefaultPadding,
                EtoHelpers.PaddingWrap(new Label { Text = UI.HorizontalCoordinatesInDegrees }))
            .WithRow(Globals.DefaultPadding, EtoHelpers.PaddingWrap(lbHorizontalXValue),
                EtoHelpers.PaddingWrap(lbHorizontalYValue))
            .GetTable();

        mapControlLayout.Rows.Add(objectInfoTableNameRaDec);
        mapControlLayout.Rows.Add(objectInfoTableHorizontalCoordinates);
        mapControlLayout.Rows.Add(EtoHelpers.PaddingWrap(cbAboveHorizonValue));
        mapControlLayout.Rows.Add(EtoHelpers.PaddingWrap(new Label { Text = UI.Coordinates }));

        lbMouseCoordinateHeightValue = new Label { Text = UI.NAChar, TextColor = Colors.SteelBlue, Font = font, };
        lbMouseCoordinateAzimuthValue = new Label { Text = UI.NAChar, TextColor = Colors.SteelBlue, Font = font, };
        lbMouseCoordinateRightAscensionValue = new Label { Text = UI.NAChar, TextColor = Colors.SteelBlue, Font = font, };
        lbMouseCoordinateDeclinationValue = new Label { Text = UI.NAChar, TextColor = Colors.SteelBlue, Font = font, };

        mousePositionLayout = FluentTableLayoutBuilder.New()
            .WithSpacing(Globals.DefaultPadding)
            .WithRootRow(new Label { Text = UI.Height }, lbMouseCoordinateHeightValue)
            .WithRootRow(new Label { Text = UI.Azimuth }, lbMouseCoordinateAzimuthValue)
            .WithRootRow(new Label { Text = UI.RightAscension }, lbMouseCoordinateRightAscensionValue)
            .WithRootRow(new Label { Text = UI.Declination }, lbMouseCoordinateDeclinationValue)
            .GetTable();

        mapControlLayout.Rows.Add(mousePositionLayout);

        lbCompassDirectionValue = new Label { Text = UI.NAChar, TextColor = Colors.SteelBlue, Font = font, };
        mapControlLayout.Rows.Add(EtoHelpers.LabelWrap(UI.CompassDirection, EtoHelpers.PaddingWrap(lbCompassDirectionValue), Globals.DefaultPadding));

        cmbJumpLocation.SelectedValueChanged += CmbJumpLocation_SelectedValueChanged;
        nsLatitude.ValueChanged += NsLatitude_ValueChanged;
        nsLongitude.ValueChanged += NsLongitude_ValueChanged;

        cwCompass = new CompassView { Width = PreviousSplitterSize, Height = PreviousSplitterSize, };

        SetTitle();

        // Leave this and the compass to the last!
        mapControlLayout.Rows.Add(new TableRow { ScaleHeight = true });
        mapControlLayout.Rows.Add(cwCompass);
    }

    private bool InvertEastWest => map2d.InvertEastWest;
    private bool timeUpdate;
    private List<SolarSystemObjectGraphics> solarSystemObjects = new();

    #region InternalEvents
    private void FormSkyMap2D_Shown(object? sender, EventArgs e)
    {
        splitterMain!.PositionChanged -= SplitterMainPositionChanged;
        splitterMain!.Position = ClientSize.Width - PreviousSplitterSize;
        splitterMain.PositionChanged += SplitterMainPositionChanged;
    }

    private void SplitterMainPositionChanged(object? sender, EventArgs e)
    {
        if (sender is Splitter splitter)
        {
            PreviousSplitterSize = ClientSize.Width - splitter.Position;
        }
    }

    private void Map2d_CoordinatesChanged(object? sender, Common.EventsAndDelegates.LocationChangedEventArgs e)
    {
        nsLatitude!.Value = e.Latitude;
        nsLongitude!.Value = e.Longitude;
        var city = Cities.GetNearestCity(e.Latitude, e.Longitude);
        cmbJumpLocation!.SelectedValueChanged -= CmbJumpLocation_SelectedValueChanged;
        cmbJumpLocation.Text = city.CityName ?? city.CityNameAscii;
        cmbJumpLocation.SelectedValueChanged += CmbJumpLocation_SelectedValueChanged;
        SetTitle();
    }

    private void FormSkyMap2D_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
    {
        timer.Stop();
    }

    private void FormSkyMap2D_SizeChanged(object? sender, EventArgs e)
    {
        splitterMain!.PositionChanged -= SplitterMainPositionChanged;
        splitterMain!.Position = ClientSize.Width - PreviousSplitterSize;
        splitterMain.PositionChanged += SplitterMainPositionChanged;
    }

    private void NsLongitude_ValueChanged(object? sender, EventArgs e)
    {
        map2d.Longitude = nsLongitude!.Value;
    }

    private void NsLatitude_ValueChanged(object? sender, EventArgs e)
    {
        map2d.Latitude = nsLatitude!.Value;
    }

    private void RevertLocation_Click(object? sender, EventArgs e)
    {
        cmbJumpLocation!.Text = Globals.Settings.DefaultLocationName;
        map2d.Latitude = Globals.Settings.Latitude;
        map2d.Longitude = Globals.Settings.Longitude;
        nsLatitude!.Value = Globals.Settings.Latitude;
        nsLongitude!.Value = Globals.Settings.Longitude;
        SetTitle();
    }

    private void CmbJumpLocation_SelectedValueChanged(object? sender, EventArgs e)
    {
        if (cmbJumpLocation!.SelectedValue == null)
        {
            return;
        }

        var value = (CityLatLonCoordinate)cmbJumpLocation.SelectedValue;
        nsLatitude!.Value = value.Latitude;
        nsLongitude!.Value = value.Longitude;
        map2d.Latitude = value.Latitude;
        map2d.Longitude = value.Longitude;
    }

    private DateTime previousDateTime;
    private DateTime previousDateCalculation;

    private void ElapsedHandler(object? sender, EventArgs e)
    {
        if (!IsRealTimeSpeed)
        {
            if (previousDateTime != default && previousDateCalculation != default)
            {
                var timePassed = (DateTime.UtcNow - previousDateCalculation).TotalSeconds;
                previousDateTime = previousDateTime.AddSeconds(timePassed / 1.0 * TimeIncrementSecond);
                dateTimePickerJump!.Value = previousDateTime.ToLocalTime();
                map2d.DateTimeUtc = previousDateTime;
                previousDateCalculation = DateTime.UtcNow;
            }
            else
            {
                previousDateCalculation = DateTime.UtcNow;
                previousDateTime = DateTime.UtcNow;
                dateTimePickerJump!.Value = previousDateTime.ToLocalTime();
                map2d.DateTimeUtc = previousDateTime;
            }
        }
        else
        {
            var dateTime = DateTime.UtcNow;
            dateTimePickerJump!.Value = dateTime.ToLocalTime();
            map2d.DateTimeUtc = dateTime;
        }
        SetTitle();
    }

    private void CbDrawCrossHair_CheckedChanged(object? sender, EventArgs e)
    {
        map2d.DrawCrossHair = cbDrawCrossHair!.Checked == true;
    }

    private void CbSkipCalculatedObjects_CheckedChanged(object? sender, EventArgs e)
    {
        map2d.SkipCalculatedObjects = cbSkipCalculatedObjects!.Checked == true;
    }

    private void CbDrawConstellationNamesCheckedChanged(object? sender, EventArgs e)
    {
        map2d.DrawConstellationNames = cbDrawConstellationNames!.Checked == true;
    }

    private void CbInvertEastWest_CheckedChanged(object? sender, EventArgs e)
    {
        map2d.InvertEastWest = cbInvertEastWest!.Checked == true;
        cwCompass!.InvertEastWestAxis = cbInvertEastWest!.Checked == true;
    }

    private void CbDrawConstellationsCheckedChanged(object? sender, EventArgs e)
    {
        map2d.DrawConstellations = cbDrawConstellations!.Checked == true;
    }

    private void CbDrawConstellationBorders_CheckedChanged(object? sender, EventArgs e)
    {
        map2d.DrawConstellationBoundaries = cbDrawConstellationBorders!.Checked == true;
    }
    #endregion

    #region PrivateMethodsAndProperties

    private bool IsRealTimeSpeed => Math.Abs((nsSpeedPerTimeAmount?.Value ?? 1) - 1) <
                                    EtoForms.Controls.Globals.FloatingPointTolerance &&
                                    ((EnumStringItem<TimeInterval>?)cmbTimeUnit?.SelectedValue)?.EnumValue ==
                                    TimeInterval.Second;

    private double TimeIncrementSecond
    {
        get
        {
            if (IsRealTimeSpeed)
            {
                return 1;
            }

            var unit = ((EnumStringItem<TimeInterval>?)cmbTimeUnit?.SelectedValue)?.EnumValue;

            if (unit == null)
            {
                return 1;
            }

            return unit switch
            {
                TimeInterval.Millisecond => nsSpeedPerTimeAmount!.Value / 1000.0,
                TimeInterval.Second => nsSpeedPerTimeAmount!.Value,
                TimeInterval.Minute => nsSpeedPerTimeAmount!.Value * 60,
                TimeInterval.Hour => nsSpeedPerTimeAmount!.Value * 3600,
                TimeInterval.Day => nsSpeedPerTimeAmount!.Value * 86400,
                TimeInterval.Week => nsSpeedPerTimeAmount!.Value * 604800,
                TimeInterval.Month => nsSpeedPerTimeAmount!.Value * 30.436875 * 86400,
                TimeInterval.Year => nsSpeedPerTimeAmount!.Value * 365.2425 * 86400,
                _ => 1
            };
        }
    }
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

    /// <summary>
    /// Loads the embedded star catalog to be used by the map.
    /// </summary>
    private void LoadEmbeddedCatalog()
    {
        var yaleBrightProvider = new YaleBrightProvider();

        using var reader = new StreamReader(new MemoryStream(StarMap2D.EtoForms.Properties.Resources.YaleBrightStars));

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

    private void SetTitle()
    {
        Title = string.Format(UI.SkyMapTitle, map2d.Latitude, map2d.Longitude,
            map2d.DateTimeUtc.ToLocalTime().ToString(CultureInfo.CurrentCulture),
            (map2d.SiderealTime / 15).ToString("F4", Globals.FormattingCulture));
    }

    /// <summary>
    /// Loads the program settings.
    /// </summary>
    private void LoadSettings()
    {
        map2d.Locale = Globals.Settings.Locale!;

        map2d.Plot2D!.Latitude = Globals.Settings.Latitude;
        map2d.Plot2D.Longitude = Globals.Settings.Longitude;

        solarSystemObjects = SolarSystemObjectGraphics.MergeWithDefaults(Globals.Settings.KnownObjects!,
            Globals.Settings.Locale!);

        cbDrawCrossHair!.Checked = Globals.Settings.DrawCrossHair;
        cbDrawConstellationBorders!.Checked = Globals.Settings.DrawConstellationBorders;
        cbDrawConstellationNames!.Checked = Globals.Settings.DrawConstellationLabels;
        cbDrawConstellations!.Checked = Globals.Settings.DrawConstellationLines;

        cmbJumpLocation!.Text = Globals.Settings.DefaultLocationName;

        nsLatitude!.Value = Globals.Settings.Latitude;
        nsLongitude!.Value = Globals.Settings.Longitude;
    }
    #endregion
}