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