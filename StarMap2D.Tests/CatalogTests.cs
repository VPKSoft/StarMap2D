using Microsoft.VisualStudio.TestTools.UnitTesting;
using VPKSoft.StarCatalogs.Providers;

namespace StarMap2D.Tests;

[TestClass]
public class CatalogTests
{
    [TestMethod]
    public void TestGliese3rd()
    {
        Assert.IsTrue(Gliese3rdProvider.TestProvider("CatalogSnapshots/Glise 3rd_1000.dat"));
    }

    [TestMethod]
    public void TestHyg30()
    {            
        Assert.IsTrue(HygV3Provider.TestProvider("CatalogSnapshots/HYG_V30_1000.dat"));
    }

    [TestMethod]
    public void TestHipparcos()
    {
        Assert.IsTrue(HipparcosProvider.TestProvider("CatalogSnapshots/Hipparcos_1000.dat"));
    }

    [TestMethod]
    public void TestTycho()
    {
        Assert.IsTrue(TychoProvider.TestProvider("CatalogSnapshots/Tycho_1000.dat"));
    }

    [TestMethod]
    public void TestYaleBright5Th()
    {
        Assert.IsTrue(YaleBrightProvider.TestProvider("CatalogSnapshots/Yale Bright Star Catalog 5th_1000.dat"));
    }

    [TestMethod]
    public void TestYaleSmall()
    {
        Assert.IsTrue(YaleSmallProvider.TestProvider("CatalogSnapshots/yale_small_904.dat"));
    }

    [TestMethod]
    public void TestPPM()
    {
        Assert.IsTrue(PpmProvider.TestProvider("CatalogSnapshots/PPM_1000", false));
    }

    [TestMethod]
    public void TestPPMra()
    {
        Assert.IsTrue(PpmProvider.TestProvider("CatalogSnapshots/PPMra_1000", true));
    }
}