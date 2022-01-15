using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarMap2D.Calculations.Constellations.StaticData;

namespace StarMap2D.Tests
{
    [TestClass]
    public class Constellations
    {
        [TestMethod]
        public void TestSMapConstellations()
        {
            foreach (var line in ConstellationLines.LinesSMap)
            {
                var star = ConstellationStars.ConstellationStarsSMap.FirstOrDefault(f =>
                    f.InternalId == line.StartIdentifier && f.Identifier == line.Identifier);

                Assert.IsNotNull(star);

                star = ConstellationStars.ConstellationStarsSMap.FirstOrDefault(f =>
                    f.InternalId == line.StartIdentifier && f.Identifier == line.Identifier);

                Assert.IsNotNull(star);
            }
        }

        [TestMethod]
        public void TestDfConstellations()
        {
            foreach (var line in ConstellationLines.ConstellationLinesDf)
            {
                var star = ConstellationStars.ConstellationStarsDf.FirstOrDefault(f =>
                    f.InternalId == line.StartIdentifier && f.Identifier == line.Identifier);

                Assert.IsNotNull(star);

                star = ConstellationStars.ConstellationStarsDf.FirstOrDefault(f =>
                    f.InternalId == line.StartIdentifier && f.Identifier == line.Identifier);

                Assert.IsNotNull(star);
            }
        }
    }
}
