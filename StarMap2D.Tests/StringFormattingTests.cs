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
using VPKSoft.StarCatalogs.HelperClasses;

namespace StarMap2D.Tests;

[TestClass]
public class StringFormattingTests
{
    [TestMethod]
    public void TestStarNamePrettify()
    {
        var name = "12Alp2CVn";
        var expected = "12 Alp 2 CVn";
        Assert.AreEqual(name.PrettifyStarName(), expected);

        name = "48Iot Cnc";
        expected = "48 Iot Cnc";
        Assert.AreEqual(name.PrettifyStarName(), expected);
    }
}