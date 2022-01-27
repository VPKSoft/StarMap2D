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

using System.Globalization;
using AASharp;
using StarMap2D.Calculations.Constellations.StaticData;
using StarMap2D.Calculations.Enumerations;
using StarMap2D.Calculations.Helpers;
using StarMap2D.Calculations.Helpers.DateAndTime;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.Controls.WinForms.Enumerations;
using StarMap2D.Controls.WinForms.EventArguments;
using StarMap2D.Controls.WinForms.Utilities;
using StarMap2D.Utilities;
using VPKSoft.LangLib;
using VPKSoft.StarCatalogs.Providers;

namespace StarMap2D.Forms;

/// <summary>
/// A <see cref="Form"/> to visualize a 2D star map.
/// Implements the <see cref="System.Windows.Forms.Form" />
/// </summary>
/// <seealso cref="System.Windows.Forms.Form" />
public partial class FormSkyMap2D : DBLangEngineWinforms
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FormSkyMap2D"/> class.
    /// </summary>
    public FormSkyMap2D()
    {
        InitializeComponent();

        solarSystemObjects = SolarSystemObjectGraphics.MergeWithDefaults(Properties.Settings.Default.KnownObjects,
            Properties.Settings.Default.UiLanguage);

        if (Utils.ShouldLocalize() != null)
        {
            DBLangEngine.InitializeLanguage("StarMap2D.Localization.Messages", Utils.ShouldLocalize(), false);
            return; // After localization don't do anything more..
        }

        map2d.StarColors = Properties.Settings.Default.StarMagnitudeColors.Split(";")
            .Select(ColorTranslator.FromHtml).ToArray();

        map2d.StarSizes = Properties.Settings.Default.StarMagnitudeSizes.Split(';').Select(int.Parse).ToArray();

        // initialize the language/localization database..
        DBLangEngine.InitializeLanguage("StarMap2D.Localization.Messages");

        map2d.MapCircleColor = Properties.Settings.Default.MapCircleColor;

        map2d.Plot2D = new(Properties.Settings.Default.Latitude, Properties.Settings.Default.Longitude)
        {
            Radius = Math.Min(map2d.Width, map2d.Height)
        };

        SetTitle();

        CreateSolarSystemObjects();

        ListTimeIntervals();

        map2d.StarMapObjects.Add(new StarMapObject
        {
            RightAscension = 2.53030404466667,
            Declination =   89.26410897,
            Magnitude = -6.4,
        });
            
        map2d.StarMapObjects.Add(new StarMapObject
        {

            RightAscension = 5.60355904,
            Declination =  -1.20191725,
            Magnitude = -6.4,
        });

        var yaleBrightProvider = new YaleBrightProvider();

        using var reader = new StreamReader(new MemoryStream(Properties.Resources.YaleBrightStars));
            
        yaleBrightProvider.LoadData(reader.ReadAllLines());

        foreach (var yaleBrightStar in yaleBrightProvider.StarData)
        {
            map2d.StarMapObjects.Add(new StarMapObject { RightAscension = yaleBrightStar.RightAscension, Declination = yaleBrightStar.Declination, Magnitude = yaleBrightStar.Magnitude});
        }

        instances.Add(this);

        cbInvertEastWest.Checked = Properties.Settings.Default.InvertEastWest;

        cmbJumpToLocation.Items.AddRange(new Cities().CityList.ToArray<object>());
        cmbJumpToLocation.Text = Properties.Settings.Default.DefaultLocationName;
    }
    
    private readonly List<SolarSystemObjectGraphics> solarSystemObjects;

    private static FormSkyMap2D? singletonInstance;

    #region PrivateMethodsAndProperties

    private void SetTitle(double? latitude = null, double? longitude = null)
    {
        Text = DBLangEngine.GetMessage("msgSkyMap",
            "Sky Map [Latitude: {0:F5}, Longitude: {1:F5}], [Time: {2}]|A title for a window containing a sky map control with latitude and longitude coordinates, date and time.",
            latitude ?? map2d.Plot2D?.Latitude, longitude ?? map2d.Plot2D?.Longitude, map2d.CurrentTimeUtc.ToLocalTime().ToString(CultureInfo.CurrentCulture));
    }

    private void ListTimeIntervals()
    {
        cmbTimeType.Items.Clear();

        cmbTimeType.Items.Add(new KeyValuePair<TimeInterval, string>(TimeInterval.Millisecond,
            DBLangEngine.GetMessage("msgTimeIntervalMillisecond",
                "ms|An abbreviation for milliseconds.")));

        cmbTimeType.Items.Add(new KeyValuePair<TimeInterval, string>(TimeInterval.Second,
            DBLangEngine.GetMessage("msgTimeIntervalSecond",
                "s|An abbreviation for seconds.")));

        cmbTimeType.Items.Add(new KeyValuePair<TimeInterval, string>(TimeInterval.Minute,
            DBLangEngine.GetMessage("msgTimeIntervalMinute",
                "min|An abbreviation for seconds.")));

        cmbTimeType.Items.Add(new KeyValuePair<TimeInterval, string>(TimeInterval.Hour,
            DBLangEngine.GetMessage("msgTimeIntervalHour",
                "h|An abbreviation for hours.")));

        cmbTimeType.Items.Add(new KeyValuePair<TimeInterval, string>(TimeInterval.Day,
            DBLangEngine.GetMessage("msgTimeIntervalDay",
                "d|An abbreviation for days.")));

        cmbTimeType.Items.Add(new KeyValuePair<TimeInterval, string>(TimeInterval.Week,
            DBLangEngine.GetMessage("msgTimeIntervalWeek",
                "w|An abbreviation for weeks.")));

        cmbTimeType.Items.Add(new KeyValuePair<TimeInterval, string>(TimeInterval.Month,
            DBLangEngine.GetMessage("msgTimeIntervalMonth",
                "m|An abbreviation for months.")));

        cmbTimeType.Items.Add(new KeyValuePair<TimeInterval, string>(TimeInterval.Year,
            DBLangEngine.GetMessage("msgTimeIntervalYear",
                "y|An abbreviation for years.")));

        cmbTimeType.SelectedItem = new KeyValuePair<TimeInterval, string>(TimeInterval.Second,
            DBLangEngine.GetMessage("msgTimeIntervalSecond",
                "s|An abbreviation for seconds."));
    }

    private void ResetSpeed()
    {
        btPlayPause.Checked = false;
        cmbTimeType.SelectedItem = new KeyValuePair<TimeInterval, string>(TimeInterval.Second,
            DBLangEngine.GetMessage("msgTimeIntervalSecond",
                "s|An abbreviation for seconds."));

        map2d.CurrentTimeUtc = DateTime.UtcNow;
        numericUpDown1.Value = 1;
        SetTitle();

    }

    private bool InvertEastWest => map2d.InvertEastWest;

    private void CreateSolarSystemObjects()
    {
        if (map2d.Plot2D == null)
        {
            return;
        }

        var bodies = new SmallBodies();

        foreach (SolarSystemSmallBodies value in Enum.GetValues(typeof(SolarSystemSmallBodies)))
        {
            var solarSystemObject = solarSystemObjects.First(f => (int)f.ObjectType == (int)value);

            if (!solarSystemObject.Enabled)
            {
                continue;
            }

            map2d.StarMapObjects.Add(new StarMapObject
            {
                CalculatePosition = (aaDate, _, latitude, longitude, _) =>
                {
                    var body = bodies[value];
                    var details = AASElliptical.Calculate(aaDate.Julian, ref body, false);
                    var coordinate = new AAS2DCoordinate
                        { X = details.AstrometricGeocentricRA % 360, Y = details.AstrometricGeocentricDeclination }.ToHorizontal(aaDate, latitude, longitude);
                    return map2d.Plot2D.Project2D(coordinate, InvertEastWest);
                },
                ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => solarSystemObject.Image },
                IsLocationCalculated = true
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
                IsLocationCalculated = true
            });
        }

        var sun = solarSystemObjects.First(f => f.ObjectType == ObjectsWithGraphics.Sun);
        if (sun.Enabled)
        {
            map2d.StarMapObjects.Add(new StarMapObject
            {
                CalculatePosition = (aaDate, precision, latitude, longitude, _) =>
                    map2d.Plot2D.Project2D(
                        SolarSystemObjectPositions.GetSunPosition(aaDate, precision, longitude, latitude), InvertEastWest),
                ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => sun.Image },
                IsLocationCalculated = true
            });
        }

        var moon = solarSystemObjects.First(f => f.ObjectType == ObjectsWithGraphics.Moon);

        if (moon.Enabled)
        {
            map2d.StarMapObjects.Add(new StarMapObject
            {
                CalculatePosition = (aaDate, precision, latitude, longitude, _) =>
                    map2d.Plot2D.Project2D(
                        SolarSystemObjectPositions.GetMoonPosition(aaDate, precision, longitude, latitude), InvertEastWest),
                ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => moon.Image },
                IsLocationCalculated = true
            });
        }
    }

    private void cbInvertEastWest_CheckedChanged(object sender, EventArgs e)
    {
        var checkBox = (CheckBox)sender;
        map2d.InvertEastWest = checkBox.Checked;
        compassView1.InvertEastWest = checkBox.Checked;
    }

    private void cmbJumpToLocation_SelectedValueChanged(object sender, EventArgs e)
    {
        var comboBox = (ComboBox)sender;

        var value = (CityLatLonCoordinate)comboBox.SelectedItem;

        if (value != null && map2d.Plot2D != null)
        {
            map2d.Latitude = value.Latitude;
            map2d.Longitude = value.Longitude;
        }
    }

    private void btResetLocation_Click(object sender, EventArgs e)
    {
        cmbJumpToLocation.Text = Properties.Settings.Default.DefaultLocationName;
        map2d.Latitude = Properties.Settings.Default.Latitude;
        map2d.Longitude = Properties.Settings.Default.Longitude;
    }
    #endregion

    #region CraphicsChangeBroadcast

    private static List<FormSkyMap2D> instances = new();
    #endregion

    #region PublicMethods
    /// <summary>
    /// Changes the color of all the instances of the <see cref="FormSkyMap2D"/> form.
    /// </summary>
    /// <param name="color">The color value.</param>
    /// <param name="mapGraphic">The <see cref="MapGraphicValue"/> enumeration value specifying the target of the color change.</param>
    public static void ChangeColor(Color color, MapGraphicValue mapGraphic)
    {
        foreach (var instance in instances)
        {
            switch (mapGraphic)
            {
                case MapGraphicValue.MapCircleColor:
                    instance.map2d.MapCircleColor = color; break;
                case MapGraphicValue.ConstellationLineColor:
                    instance.map2d.ConstellationLineColor = color; break;
                case MapGraphicValue.ConstellationBorderLineColor:
                    instance.map2d.ConstellationBorderLineColor = color; break;
                case MapGraphicValue.MapSurroundingsColor:
                    instance.map2d.BackColor = color; break;
            }
        }
    }

    /// <summary>
    /// Displays the <see cref="FormSkyMap2D"/> window.
    /// </summary>
    /// <param name="owner">The owner of the form.</param>
    public static void Display(IWin32Window? owner)
    {
        singletonInstance ??= new FormSkyMap2D();

        if (!singletonInstance.Visible)
        {
            singletonInstance.Show(owner);
        }
        else
        {
            singletonInstance.BringToFront();
        }
    }
    #endregion
    
    #region InternalEvents
    private void tmSetTime_Tick(object sender, EventArgs e)
    {
        var intervalType = (KeyValuePair<TimeInterval, string>)cmbTimeType.SelectedItem;

        if (numericUpDown1.Value == 1 && intervalType.Key == TimeInterval.Second)
        {
            map2d.CurrentTimeUtc = DateTime.UtcNow;
        }
        else
        {
            map2d.CurrentTimeUtc = map2d.CurrentTimeUtc.AddInterval((double)numericUpDown1.Value / 10.0, intervalType.Key);
        }

        SetTitle();
    }

    private void btGo_Click(object sender, EventArgs e)
    {
        tmSetTime.Enabled = false;
        var dateTime = dtpMapDateTime.Value;

        btPlayPause.Text = @">";

        map2d.CurrentTimeUtc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour,
            dateTime.Minute, 0, DateTimeKind.Local).ToUniversalTime();
    }

    private void map2d_CoordinatesChanged(object sender, LocationChangedEventArgs e)
    {
        SetTitle(e.Latitude, e.Longitude);
    }

    private void FormSkyMap2D_FormClosed(object sender, FormClosedEventArgs e)
    {
        singletonInstance = null;
    }

    private void btPlayPause_CheckedChanged(object sender, CheckedChangeEventArguments e)
    {
        tmSetTime.Enabled = e.Checked;
    }

    private void btRevertSpeed_Click(object sender, EventArgs e)
    {
        ResetSpeed();
    }
    #endregion
}