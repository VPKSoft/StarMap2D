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
using StarMap2D.Common.Utilities;
using StarMap2D.Eto.Controls;
using StarMap2D.Eto.Controls.Utilities;
using StarMap2D.Eto.Properties;
using VPKSoft.StarCatalogs.Providers;

namespace StarMap2D.Eto.Forms
{
    public class FormSkyMap2D : Form
    {
        public FormSkyMap2D()
        {
            Content = map2d;

            MinimumSize = new Size(1200, 1000);

            map2d.Plot2D = new(Globals.Settings.Latitude, Globals.Settings.Longitude)
            {
                Diameter = Math.Min(map2d.Width, map2d.Height)
            };

            LoadEmbeddedCatalog();
            LoadSettings();
            CreateSolarSystemObjects();

        }

        private bool InvertEastWest => map2d.InvertEastWest;

        private List<SolarSystemObjectGraphics> solarSystemObjects = new();


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