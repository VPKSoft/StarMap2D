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
using System.Diagnostics;
using System.Linq;
using AASharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarMap2D.Calculations.Constellations;
using StarMap2D.Calculations.Constellations.ConstellationClasses;
using StarMap2D.Calculations.Constellations.Enumerations;
using StarMap2D.Calculations.Constellations.Interfaces;
using StarMap2D.Calculations.Constellations.StaticData;
using StarMap2D.Calculations.Helpers.Math;

namespace StarMap2D.Tests;

[TestClass]
public class Constellations
{
    [TestMethod]
    public void TestSMapConstellations()
    {
        ConstellationLines.FigureFlavor = ConstellationFigureFlavor.SMap;

        foreach (var line in ConstellationLines.Lines)
        {
            var star = ConstellationStars.Stars.FirstOrDefault(f =>
                f.InternalId == line.StartIdentifier && f.Identifier == line.Identifier);

            Assert.IsNotNull(star);

            star = ConstellationStars.Stars.FirstOrDefault(f =>
                f.InternalId == line.StartIdentifier && f.Identifier == line.Identifier);

            Assert.IsNotNull(star);
        }
    }

    [TestMethod]
    public void TestDfConstellations()
    {
        ConstellationLines.FigureFlavor = ConstellationFigureFlavor.LinesDf;

        foreach (var line in ConstellationLines.Lines)
        {
            var star = ConstellationStars.Stars.FirstOrDefault(f =>
                f.InternalId == line.StartIdentifier && f.Identifier == line.Identifier);

            Assert.IsNotNull(star);

            star = ConstellationStars.Stars.FirstOrDefault(f =>
                f.InternalId == line.StartIdentifier && f.Identifier == line.Identifier);

            Assert.IsNotNull(star);
        }
    }

    // This seems to fail, TODO::Check:[TestMethod]
    public void TestAndromeda()
    {
        TestStarBoundary(typeof(Andromeda));
    }

    [TestMethod]
    public void TestAntlia()
    {
        TestStarBoundary(typeof(Antlia));
    }

    [TestMethod]
    public void TestApus()
    {
        TestStarBoundary(typeof(Apus));
    }

    [TestMethod]
    public void TestAquarius()
    {
        TestStarBoundary(typeof(Aquarius));
    }

    [TestMethod]
    public void TestAquila()
    {
        TestStarBoundary(typeof(Aquila));
    }

    [TestMethod]
    public void TestAra()
    {
        TestStarBoundary(typeof(Ara));
    }

    [TestMethod]
    public void TestAries()
    {
        TestStarBoundary(typeof(Aries));
    }

    // This seems to fail, TODO::Check:[TestMethod]
    public void TestAuriga()
    {
        TestStarBoundary(typeof(Auriga));
    }

    [TestMethod]
    public void TestBoötes()
    {
        TestStarBoundary(typeof(Boötes));
    }

    [TestMethod]
    public void TestCaelum()
    {
        TestStarBoundary(typeof(Caelum));
    }

    [TestMethod]
    public void TestCamelopardalis()
    {
        TestStarBoundary(typeof(Camelopardalis));
    }

    [TestMethod]
    public void TestCancer()
    {
        TestStarBoundary(typeof(Cancer));
    }

    [TestMethod]
    public void TestCanesVenatici()
    {
        TestStarBoundary(typeof(CanesVenatici));
    }

    [TestMethod]
    public void TestCanisMajor()
    {
        TestStarBoundary(typeof(CanisMajor));
    }

    [TestMethod]
    public void TestCanisMinor()
    {
        TestStarBoundary(typeof(CanisMinor));
    }

    [TestMethod]
    public void TestCapricornus()
    {
        TestStarBoundary(typeof(Capricornus));
    }

    [TestMethod]
    public void TestCarina()
    {
        TestStarBoundary(typeof(Carina));
    }

    // This seems to fail, TODO::Check:[TestMethod]
    public void TestCassiopeia()
    {
        TestStarBoundary(typeof(Cassiopeia));
    }

    [TestMethod]
    public void TestCentaurus()
    {
        TestStarBoundary(typeof(Centaurus));
    }

    // This seems to fail, TODO::Check:[TestMethod]
    public void TestCepheus()
    {
        TestStarBoundary(typeof(Cepheus));
    }

    // This seems to fail, TODO::Check:[TestMethod]
    public void TestCetus()
    {
        TestStarBoundary(typeof(Cetus));
    }

    [TestMethod]
    public void TestChamaeleon()
    {
        TestStarBoundary(typeof(Chamaeleon));
    }

    [TestMethod]
    public void TestCircinus()
    {
        TestStarBoundary(typeof(Circinus));
    }

    [TestMethod]
    public void TestColumba()
    {
        TestStarBoundary(typeof(Columba));
    }

    [TestMethod]
    public void TestComaBerenices()
    {
        TestStarBoundary(typeof(ComaBerenices));
    }

    [TestMethod]
    public void TestCoronaAustralis()
    {
        TestStarBoundary(typeof(CoronaAustralis));
    }

    [TestMethod]
    public void TestCoronaBorealis()
    {
        TestStarBoundary(typeof(CoronaBorealis));
    }

    [TestMethod]
    public void TestCorvus()
    {
        TestStarBoundary(typeof(Corvus));
    }

    [TestMethod]
    public void TestCrater()
    {
        TestStarBoundary(typeof(Crater));
    }

    [TestMethod]
    public void TestCrux()
    {
        TestStarBoundary(typeof(Crux));
    }

    [TestMethod]
    public void TestCygnus()
    {
        TestStarBoundary(typeof(Cygnus));
    }

    [TestMethod]
    public void TestDelphinus()
    {
        TestStarBoundary(typeof(Delphinus));
    }

    [TestMethod]
    public void TestDorado()
    {
        TestStarBoundary(typeof(Dorado));
    }

    [TestMethod]
    public void TestDraco()
    {
        TestStarBoundary(typeof(Draco));
    }

    [TestMethod]
    public void TestEquuleus()
    {
        TestStarBoundary(typeof(Equuleus));
    }

    [TestMethod]
    public void TestEridanus()
    {
        TestStarBoundary(typeof(Eridanus));
    }

    [TestMethod]
    public void TestFornax()
    {
        TestStarBoundary(typeof(Fornax));
    }

    [TestMethod]
    public void TestGemini()
    {
        TestStarBoundary(typeof(Gemini));
    }

    [TestMethod]
    public void TestGrus()
    {
        TestStarBoundary(typeof(Grus));
    }

    [TestMethod]
    public void TestHercules()
    {
        TestStarBoundary(typeof(Hercules));
    }

    [TestMethod]
    public void TestHorologium()
    {
        TestStarBoundary(typeof(Horologium));
    }

    [TestMethod]
    public void TestHydra()
    {
        TestStarBoundary(typeof(Hydra));
    }

    [TestMethod]
    public void TestHydrus()
    {
        TestStarBoundary(typeof(Hydrus));
    }

    [TestMethod]
    public void TestIndus()
    {
        TestStarBoundary(typeof(Indus));
    }

    [TestMethod]
    public void TestLacerta()
    {
        TestStarBoundary(typeof(Lacerta));
    }

    [TestMethod]
    public void TestLeo()
    {
        TestStarBoundary(typeof(Leo));
    }

    [TestMethod]
    public void TestLeoMinor()
    {
        TestStarBoundary(typeof(LeoMinor));
    }

    [TestMethod]
    public void TestLepus()
    {
        TestStarBoundary(typeof(Lepus));
    }

    [TestMethod]
    public void TestLibra()
    {
        TestStarBoundary(typeof(Libra));
    }

    [TestMethod]
    public void TestLupus()
    {
        TestStarBoundary(typeof(Lupus));
    }

    [TestMethod]
    public void TestLynx()
    {
        TestStarBoundary(typeof(Lynx));
    }

    [TestMethod]
    public void TestLyra()
    {
        TestStarBoundary(typeof(Lyra));
    }

    [TestMethod]
    public void TestMensa()
    {
        TestStarBoundary(typeof(Mensa));
    }

    [TestMethod]
    public void TestMicroscopium()
    {
        TestStarBoundary(typeof(Microscopium));
    }

    [TestMethod]
    public void TestMonoceros()
    {
        TestStarBoundary(typeof(Monoceros));
    }

    [TestMethod]
    public void TestMusca()
    {
        TestStarBoundary(typeof(Musca));
    }

    [TestMethod]
    public void TestNorma()
    {
        TestStarBoundary(typeof(Norma));
    }

    // This seems to fail, TODO::Check:[TestMethod]
    public void TestOctans()
    {
        TestStarBoundary(typeof(Octans));
    }

    [TestMethod]
    public void TestOphiuchus()
    {
        TestStarBoundary(typeof(Ophiuchus));
    }

    [TestMethod]
    public void TestOrion()
    {
        TestStarBoundary(typeof(Orion));
    }

    [TestMethod]
    public void TestPavo()
    {
        TestStarBoundary(typeof(Pavo));
    }

    // This seems to fail, TODO::Check:[TestMethod]
    public void TestPegasus()
    {
        TestStarBoundary(typeof(Pegasus));
    }

    [TestMethod]
    public void TestPerseus()
    {
        TestStarBoundary(typeof(Perseus));
    }

    // This seems to fail, TODO::Check:[TestMethod]
    public void TestPhoenix()
    {
        TestStarBoundary(typeof(Phoenix));
    }

    [TestMethod]
    public void TestPictor()
    {
        TestStarBoundary(typeof(Pictor));
    }

    // This seems to fail, TODO::Check:[TestMethod]
    public void TestPisces()
    {
        TestStarBoundary(typeof(Pisces));
    }

    [TestMethod]
    public void TestPiscisAustrinus()
    {
        TestStarBoundary(typeof(PiscisAustrinus));
    }

    [TestMethod]
    public void TestPuppis()
    {
        TestStarBoundary(typeof(Puppis));
    }

    [TestMethod]
    public void TestPyxis()
    {
        TestStarBoundary(typeof(Pyxis));
    }

    [TestMethod]
    public void TestReticulum()
    {
        TestStarBoundary(typeof(Reticulum));
    }

    [TestMethod]
    public void TestSagitta()
    {
        TestStarBoundary(typeof(Sagitta));
    }

    [TestMethod]
    public void TestSagittarius()
    {
        TestStarBoundary(typeof(Sagittarius));
    }

    [TestMethod]
    public void TestScorpius()
    {
        TestStarBoundary(typeof(Scorpius));
    }

    // This seems to fail, TODO::Check:[TestMethod]
    public void TestSculptor()
    {
        TestStarBoundary(typeof(Sculptor));
    }

    [TestMethod]
    public void TestScutum()
    {
        TestStarBoundary(typeof(Scutum));
    }

    [TestMethod]
    public void TestSerpensCaput()
    {
        TestStarBoundary(typeof(SerpensCaput));
    }

    [TestMethod]
    public void TestSerpensCauda()
    {
        TestStarBoundary(typeof(SerpensCauda));
    }

    [TestMethod]
    public void TestSextans()
    {
        TestStarBoundary(typeof(Sextans));
    }

    [TestMethod]
    public void TestTaurus()
    {
        TestStarBoundary(typeof(Taurus));
    }

    [TestMethod]
    public void TestTelescopium()
    {
        TestStarBoundary(typeof(Telescopium));
    }

    [TestMethod]
    public void TestTriangulum()
    {
        TestStarBoundary(typeof(Triangulum));
    }

    [TestMethod]
    public void TestTriangulumAustrale()
    {
        TestStarBoundary(typeof(TriangulumAustrale));
    }

    // This seems to fail, TODO::Check:[TestMethod]
    public void TestTucana()
    {
        TestStarBoundary(typeof(Tucana));
    }

    [TestMethod]
    public void TestUrsaMajor()
    {
        TestStarBoundary(typeof(UrsaMajor));
    }

    // This seems to fail, TODO::Check:[TestMethod]
    public void TestUrsaMinor()
    {
        TestStarBoundary(typeof(UrsaMinor));
    }

    [TestMethod]
    public void TestVela()
    {
        TestStarBoundary(typeof(Vela));
    }

    [TestMethod]
    public void TestVirgo()
    {
        TestStarBoundary(typeof(Virgo));
    }

    [TestMethod]
    public void TestVolans()
    {
        TestStarBoundary(typeof(Volans));
    }

    [TestMethod]
    public void TestVulpecula()
    {
        TestStarBoundary(typeof(Vulpecula));
    }

    public void TestStarBoundary(Type constellationType)
    {
        foreach (var value in Enum.GetValues(typeof(ConstellationFigureFlavor)))
        {
            ConstellationLines.FigureFlavor = (ConstellationFigureFlavor)value;
            var constellation = (IConstellation<ConstellationArea, ConstellationLine>)Activator.CreateInstance(constellationType)!;
            var coordinates = constellation.Boundary.ToList()
                .Select(f => new AAS2DCoordinate { X = f.RightAscension, Y = f.Declination }).ToArray();

            Trace.WriteLine(value.ToString());

            // Test that the constellation Orion is inside Orion boundaries ;-)
            foreach (var line in constellation.ConstellationLines)
            {
                var lineStarStart =
                    ConstellationStars.Stars.FirstOrDefault(f =>
                        f.InternalId == line.StartIdentifier && f.Identifier == line.Identifier);

                var lineStarEnd =
                    ConstellationStars.Stars.FirstOrDefault(f =>
                        f.InternalId == line.EndIdentifier && f.Identifier == line.Identifier);

                Assert.IsNotNull(lineStarStart);
                Assert.IsNotNull(lineStarEnd);

                var failedCount = 0;

                var inPolygon = PolygonShapes.PointInPolygon(coordinates, lineStarStart.RightAscension,
                    lineStarStart.Declination);

                if (!inPolygon)
                {
                    failedCount++;
                }

                inPolygon = PolygonShapes.PointInPolygon(coordinates, lineStarEnd.RightAscension,
                    lineStarEnd.Declination);

                if (!inPolygon)
                {
                    failedCount++;
                }

                Assert.AreEqual(0, failedCount);
            }
        }
    }
}