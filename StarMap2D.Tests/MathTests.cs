using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarMap2D.Calculations.Constellations.ConstellationClasses;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.Calculations.Plotting;

namespace StarMap2D.Tests
{
    [TestClass]
    public class UnitTest1
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
                var inPolygon = PolygonShapes.PointInPolygon(coordinates, line.RightAscensionStart, line.DeclinationStart);
                Assert.IsTrue(inPolygon);

                inPolygon = PolygonShapes.PointInPolygon(coordinates, line.RightAscensionEnd, line.DeclinationEnd);
                Assert.IsTrue(inPolygon);
            }
        }
    }
}