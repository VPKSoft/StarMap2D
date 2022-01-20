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
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.CustomControls;
using StarMap2D.Drawing;
using VPKSoft.LangLib;
using VPKSoft.StarCatalogs.Providers;

namespace StarMap2D.Forms
{
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

            map2d.MapCircleColor = Color.Black;

            map2d.Plot2D = new(Properties.Settings.Default.Latitude, Properties.Settings.Default.Longitude)
            {
                Radius = Math.Min(map2d.Width, map2d.Height)
            };

            base.Text = DBLangEngine.GetMessage("", "Sky Map [Latitude: {0:F5}, Longitude: {1:F5}]|A title for a window containing a sky map control with latitude and longitude coordinates.", map2d.Plot2D.Latitude, map2d.Plot2D.Longitude);

            // TODO::Parametrize! (base64 in settings?)
            cache.SetImage("Mars", Properties.Resources.planet_mars);
            cache.SetImage("Sun", Properties.Resources.sun_svg);
            cache.SetImage("Mercury", Properties.Resources.planet_mercury);
            cache.SetImage("Venus", Properties.Resources.planet_venus);
            cache.SetImage("Moon", Properties.Resources.moon_svg);
            cache.SetImage("Ceres", Properties.Resources.minor_planet_ceres);

            map2d.StarMapObjects.Add(new StarMapObject
            {
                CalculatePosition = (aaDate, precision, latitude, longitude, radius) => 
                    map2d.Plot2D.Project2D(SolarSystemObjects.GetSunPosition(aaDate, precision, longitude, latitude)),
                ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => cache["Sun", Color.Yellow, Color.Black, new Size(16, 16)]! },
                IsLocationCalculated = true
            });

            map2d.StarMapObjects.Add(new StarMapObject
            {
                CalculatePosition = (aaDate, precision, latitude, longitude, radius) => 
                    map2d.Plot2D.Project2D(SolarSystemObjects.GetMoonPosition(aaDate, precision, longitude, latitude)),
                ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => cache["Moon", Color.Yellow, Color.Black, new Size(16, 16)]! },
                IsLocationCalculated = true
            });

            map2d.StarMapObjects.Add(new StarMapObject
            {
                CalculatePosition = (aaDate, precision, latitude, longitude, radius) => 
                    map2d.Plot2D.Project2D(SolarSystemObjects.GetObjectPosition(AASEllipticalObject.MERCURY, aaDate, precision, longitude, latitude)),
                ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => cache["Mercury", Color.Yellow, Color.Black, new Size(16, 16)]! },
                IsLocationCalculated = true
            });
            
            map2d.StarMapObjects.Add(new StarMapObject
            {
                CalculatePosition = (aaDate, precision, latitude, longitude, radius) => 
                    map2d.Plot2D.Project2D(SolarSystemObjects.GetObjectPosition(AASEllipticalObject.VENUS, aaDate, precision, longitude, latitude)),
                ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => cache["Venus", Color.Yellow, Color.Black, new Size(16, 16)]! },
                IsLocationCalculated = true
            });

            var bodies = new SmallBodies();

            map2d.StarMapObjects.Add(new StarMapObject
            {
                CalculatePosition = (aaDate, precision, latitude, longitude, radius) =>
                {
                    var ceres = bodies[SolarSystemSmallBodies.Ceres];
                    var details = AASElliptical.Calculate(aaDate.Julian, ref ceres, false);
                    var coordinate = new AAS2DCoordinate
                        { X = details.AstrometricGeocentricRA % 360, Y = details.AstrometricGeocentricDeclination }.ToHorizontal(aaDate, latitude, longitude);
                    return map2d.Plot2D.Project2D(coordinate);
                },
                ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => cache["Ceres", Color.Yellow, Color.Black, new Size(16, 16)]! },
                IsLocationCalculated = true
            });

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
        }

        private SvgImageCache cache = new();

        private static FormSkyMap2D? singletonInstance;

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
        #region CraphicsChangeBroadcast

        private static List<FormSkyMap2D> instances = new();
        #endregion

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

        #region InternalEvents
        private void tmSetTime_Tick(object sender, EventArgs e)
        {
            map2d.CurrentTimeUtc = map2d.CurrentTimeUtc.AddSeconds(60);

            Text = DBLangEngine.GetMessage("msgSkyMap", "Sky Map|A title for a window with a sky chart/map.") +
                   @$" [{map2d.Plot2D?.DateTimeUtc.ToLocalTime().ToString(CultureInfo.InvariantCulture)}]";
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            tmSetTime.Enabled = false;
            var dateTime = dateTimePicker1.Value;

            btPlayPause.Text = @">";

            map2d.CurrentTimeUtc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour,
                dateTime.Minute, 0, DateTimeKind.Local).ToUniversalTime();
        }

        private void btPlayPause_Click(object sender, EventArgs e)
        {
            tmSetTime.Enabled = !tmSetTime.Enabled;
            btPlayPause.Text = tmSetTime.Enabled ? @"||" : @">";
        }

        private void map2d_CoordinatesChanged(object sender, CustomControls.EventArguments.LocationChangedEventArgs e)
        {
            Text = DBLangEngine.GetMessage("", "Sky Map [Latitude: {0:F5}, Longitude: {1:F5}]|A title for a window containing a sky map control with latitude and longitude coordinates.", e.Latitude, e.Longitude);
        }

        private void FormSkyMap2D_FormClosed(object sender, FormClosedEventArgs e)
        {
            singletonInstance = null;
        }
        #endregion
    }
}
