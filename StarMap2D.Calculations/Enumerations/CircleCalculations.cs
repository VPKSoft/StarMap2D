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

using StarMap2D.Calculations.Helpers.Math;

namespace StarMap2D.Calculations.Enumerations;

/// <summary>
/// Calculations for circle-related math.
/// </summary>
public class CircleCalculations
{
    /// <summary>
    /// Gets the circle point at the specified angle.
    /// </summary>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="angle">The angle for the point.</param>
    /// <param name="centerX">The X-coordinate of the center point of the circle.</param>
    /// <param name="centerY">The Y-coordinate of the center point of the circle.</param>
    /// <returns>A System.ValueTuple&lt;System.Double, System.Double&gt; with the circle coordinates.</returns>
    public static (double x, double y) GetCirclePoint(double radius, double angle, double centerX, double centerY)
    {
        (double x, double y) result = (0, 0);
        result.x = centerX + radius * MathDegrees.Cos(angle);
        result.y = centerY + radius * MathDegrees.Sin(angle);
        return result;
    }

    /// <summary>
    /// Gets the circle point at the specified angle with the circle center point at coordinates (0, 0).
    /// </summary>
    /// <param name="radius">The radius of the circle.</param>
    /// <param name="angle">The angle for the point.</param>
    /// <returns>A System.ValueTuple&lt;System.Double, System.Double&gt; with the circle coordinates.</returns>
    public static (double x, double y) GetCirclePoint(double radius, double angle)
    {
        return GetCirclePoint(radius, angle, 0, 0);
    }
}