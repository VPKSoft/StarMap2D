﻿#region License
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
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.CustomControls;
using StarMap2D.StarData;

namespace StarMap2D.Forms
{
    /// <summary>
    /// A <see cref="Form"/> to visualize a 2D star map.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormSkyMap2D : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormSkyMap2D"/> class.
        /// </summary>
        public FormSkyMap2D()
        {
            InitializeComponent();

            map2d1.MapCircleColor = Color.Black;

            map2d1.Plot2D = new (61.68999617, 27.28500348);
            map2d1.Plot2D.Radius = Math.Min(map2d1.Width, map2d1.Height);
            map2d1.StarMapObjects.Add(new StarMapObject
            {
                CalculatePosition = (aaDate, precision, latitude, longitude, radius) => 
                    map2d1.Plot2D.Project2D(SolarSystemObjects.GetSunPosition(aaDate, precision, longitude, latitude)),
                ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => Properties.Resources.sun },
                IsLocationCalculated = true
            });

            map2d1.StarMapObjects.Add(new StarMapObject
            {
                CalculatePosition = (aaDate, precision, latitude, longitude, radius) => 
                    map2d1.Plot2D.Project2D(SolarSystemObjects.GetMoonPosition(aaDate, precision, longitude, latitude)),
                ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => Properties.Resources.moon },
                IsLocationCalculated = true
            });

            map2d1.StarMapObjects.Add(new StarMapObject
            {
                CalculatePosition = (aaDate, precision, latitude, longitude, radius) => 
                    map2d1.Plot2D.Project2D(SolarSystemObjects.GetObjectPosition(AASEllipticalObject.MERCURY, aaDate, precision, longitude, latitude)),
                ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => Properties.Resources.mercury },
                IsLocationCalculated = true
            });
            
            map2d1.StarMapObjects.Add(new StarMapObject
            {
                CalculatePosition = (aaDate, precision, latitude, longitude, radius) => 
                    map2d1.Plot2D.Project2D(SolarSystemObjects.GetObjectPosition(AASEllipticalObject.VENUS, aaDate, precision, longitude, latitude)),
                ObjectGraphics = new StarMapGraphics { GetImage = (_, _) => Properties.Resources.venus },
                IsLocationCalculated = true
            });
            

            map2d1.StarMapObjects.Add(new StarMapObject
            {
                RightAscension = 2.53030404466667,
                Declination =   89.26410897,
                Magnitude = -6.4,
            });
            
            map2d1.StarMapObjects.Add(new StarMapObject
            {

                RightAscension = 5.60355904,
                Declination =  -1.20191725,
                Magnitude = -6.4,
            });

            /*
            var gliese3rdProvider = new Gliese3rdProvider();
            gliese3rdProvider.LoadData(@"C:\Users\Petteri Kautonen\Downloads\catalog.dat\catalog - Copy.dat");

            foreach (var gliese3rdData in gliese3rdProvider.StarData)
            {
                map2d1.StarMapObjects.Add(new StarMapObject { RightAscension = gliese3rdData.RightAscension, Declination = gliese3rdData.Declination, Magnitude = gliese3rdData.Magnitude});
            }
            */

            /*
            var hygV3Provider = new HygV3Provider();
            hygV3Provider.LoadData(@"C:\Users\Petteri Kautonen\Downloads\catalog.dat\hygdata_v3.csv");

            foreach (var hygV3StartData in hygV3Provider.StarData)
            {
                map2d1.StarMapObjects.Add(new StarMapObject { RightAscension = hygV3StartData.RightAscension, Declination = hygV3StartData.Declination, Magnitude = hygV3StartData.Magnitude});
            }
            */

            var yaleBrightStarProvider = new YaleBrightProvider();
            yaleBrightStarProvider.LoadData(@"C:\Users\Petteri Kautonen\Downloads\catalog.dat\bsc5.dat");

            foreach (var yaleBrightStarData in yaleBrightStarProvider.StarData)
            {
                map2d1.StarMapObjects.Add(new StarMapObject { RightAscension = yaleBrightStarData.RightAscension, Declination = yaleBrightStarData.Declination, Magnitude = yaleBrightStarData.Magnitude});
            }



            /*
            var yaleSmallProvider = new YaleSmallProvider();
            yaleSmallProvider.LoadData(@"C:\Users\Petteri Kautonen\Documents\Visual Studio 2013\Projects\Starmap\Data\StarData\yale.dat");

            foreach (var yaleSmallData in yaleSmallProvider.StarData)
            {
                map2d1.StarMapObjects.Add(new StarMapObject { RightAscension = yaleSmallData.RightAscension, Declination = yaleSmallData.Declination, Magnitude = yaleSmallData.Magnitude});
            }
            */
        }

        private DateTime dateTimeEnd = new (2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Utc);


        private void tmSetTime_Tick(object sender, EventArgs e)
        {
            map2d1.CurrentTimeUtc = map2d1.CurrentTimeUtc.AddSeconds(60);

            label1.Text = map2d1.Plot2D?.DateTimeUtc.ToLocalTime().ToString(CultureInfo.InvariantCulture);
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            tmSetTime.Enabled = false;
            var dateTime = dateTimePicker1.Value;

            btPlayPause.Text = @">";

            map2d1.CurrentTimeUtc = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour,
                dateTime.Minute, 0, DateTimeKind.Local).ToUniversalTime();
        }

        private void btPlayPause_Click(object sender, EventArgs e)
        {
            tmSetTime.Enabled = !tmSetTime.Enabled;
            btPlayPause.Text = tmSetTime.Enabled ? @"||" : @">";
        }
    }
}
