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

using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarMap2D.Calculations.Constellations.ConstellationClasses;
using StarMap2D.Calculations.Constellations.StaticData;
using StarMap2D.Calculations.Helpers.Math;
using VPKSoft.StarCatalogs;

namespace StarMap2D.Tests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void TestPointInPolygon()
        {
            // Positive coordinates test.
            var coordinates = new[]
            {
                new PointDouble { X = 2, Y = 2 },
                new PointDouble { X = 6, Y = 2 },
                new PointDouble { X = 6, Y = 5 },
                new PointDouble { X = 2, Y = 5 },
            };

            Assert.IsTrue(PolygonShapes.PointInPolygon(coordinates, 4, 3.5));
            Assert.IsFalse(PolygonShapes.PointInPolygon(coordinates, 2, 1.9));

            // Partially negative coordinates test.
            coordinates = new[]
            {
                new PointDouble { X = -2, Y = -2 },
                new PointDouble { X = 6, Y = -2 },
                new PointDouble { X = 6, Y = 3 },
                new PointDouble { X = -2, Y = 3 },
            };

            Assert.IsTrue(PolygonShapes.PointInPolygon(coordinates, -1, -1));
        }

        [TestMethod]
        public void TestStarBoundary()
        {
            var orion = new Orion();
            var coordinates = orion.Boundary.ToList()
                .Select(f => new PointDouble { X = f.RightAscension, Y = f.Declination }).ToArray();

            // Test that the constellation Orion is inside Orion boundaries ;-)
            foreach (var line in orion.ConstellationLines)
            {
                var lineStarStart =
                    ConstellationStars.ConstellationStarsSMap.FirstOrDefault(f =>
                        f.InternalId == line.StartIdentifier);

                var lineStarEnd =
                    ConstellationStars.ConstellationStarsSMap.FirstOrDefault(f =>
                        f.InternalId == line.EndIdentifier);

                Assert.IsNotNull(lineStarStart);
                Assert.IsNotNull(lineStarEnd);

                var inPolygon = PolygonShapes.PointInPolygon(coordinates, lineStarStart.RightAscension,
                    lineStarStart.Declination);
                Assert.IsTrue(inPolygon);

                inPolygon = PolygonShapes.PointInPolygon(coordinates, lineStarEnd.RightAscension,
                    lineStarEnd.Declination);
                Assert.IsTrue(inPolygon);
            }
        }
    }
}