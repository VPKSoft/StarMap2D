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
using AASharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarMap2D.Calculations.Plotting;

namespace StarMap2D.Tests;

[TestClass]
public class Test2DProjection
{
    private Random random = new();

    [TestMethod]
    public void TestProjectAndInvert()
    {
        for (int i = 0; i < 1000; i++)
        {
            var x = random.NextDouble() * 360;
            var y = random.NextDouble() * 90;
            var projected = Projection.Project2D(new AAS2DCoordinate { X = x, Y = y }, false, 500, 0, 0, 1);
            var unProjected = Projection.Invert2DProjection(projected, false, 500, 0, 0, 1);

            Trace.WriteLine($"zP = {x}, yP = {y}, xU = {unProjected.X}, yU = {unProjected.Y}");
            Assert.AreEqual(x, unProjected.X, 0.00001);
            Assert.AreEqual(y, unProjected.Y, 0.00001);
        }
    }

    [TestMethod]
    public void TestProjectAndInvertEastWest()
    {
        for (int i = 0; i < 1000; i++)
        {
            var x = random.NextDouble() * 360;
            var y = random.NextDouble() * 90;
            var projected = Projection.Project2D(new AAS2DCoordinate { X = x, Y = y }, true, 500, 0, 0, 1);
            var unProjected = Projection.Invert2DProjection(projected, true, 500, 0, 0, 1);

            Trace.WriteLine($"zP = {x}, yP = {y}, xU = {unProjected.X}, yU = {unProjected.Y}");
            Assert.AreEqual(x, unProjected.X, 0.00001);
            Assert.AreEqual(y, unProjected.Y, 0.00001);
        }
    }

}