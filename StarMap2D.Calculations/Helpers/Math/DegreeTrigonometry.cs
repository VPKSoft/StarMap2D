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

namespace StarMap2D.Calculations.Helpers.Math
{
    /// <summary>
    /// Trigonometric functions in degrees rather than radian.
    /// </summary>
    public class MathDegrees
    {
        /// <summary>
        /// A multiplier for converting radians to degrees.
        /// </summary>
        public const double RadiansDegrees = 180.0 / System.Math.PI;

        /// <summary>
        /// A multiplier for converting degrees to radians.
        /// </summary>
        public const double DegreesRadians = System.Math.PI / 180.0;

        /// <inheritdoc cref="System.Math.Sin"/>
        public static double Sin(double a)
        {
            return System.Math.Sin(a * DegreesRadians);
        }

        /// <inheritdoc cref="System.Math.Cos"/>
        public static double Cos(double a)
        {
            return System.Math.Cos(a * DegreesRadians);
        }

        /// <inheritdoc cref="System.Math.Tan"/>
        public static double Tan(double a)
        {
            return System.Math.Tan(a * DegreesRadians) * RadiansDegrees;
        }

        /// <summary>
        /// Returns the angle whose sine is the specified number.
        /// </summary>
        /// <param name="d">A number representing a sine, where d must be greater than or equal to -1, but less than or equal to 1.</param>
        /// <returns>An angle, θ, measured in degrees, such that -180/2 ≤ θ ≤ 180/2.</returns>
        public static double Asin(double d)
        {
            return RadiansDegrees * System.Math.Asin(d);
        }

        /// <summary>
        /// Returns the angle whose cosine is the specified number.
        /// </summary>
        /// <param name="d">A number representing a cosine, where d must be greater than or equal to -1, but less than or equal to 1.</param>
        /// <returns>An angle, θ, measured in degrees, such that 0 ≤ θ ≤ 180.</returns>
        public static double Acos(double d)
        {
            return RadiansDegrees * System.Math.Acos(d * DegreesRadians);
        }

        /// <summary>
        /// Returns the angle whose tangent is the specified number.
        /// </summary>
        /// <param name="d">A number representing a tangent.</param>
        /// <returns>An angle, θ, measured in degrees, such that -180/2 ≤ θ ≤ 180/2.</returns>
        public static double Atan(double d)
        {
            return RadiansDegrees * System.Math.Atan(d * DegreesRadians);
        }

        /// <summary>
        /// Returns the angle whose tangent is the quotient of two specified numbers.
        /// </summary>
        /// <param name="y">The y coordinate of a point.</param>
        /// <param name="x">The x coordinate of a point.</param>
        /// <returns>An angle, θ, measured in degrees, such that -180 ≤ θ ≤ 180, and tan(θ) = y / x, where (x, y) is a point in the Cartesian plane.</returns>
        public static double Atan2(double y, double x)
        {
            return RadiansDegrees * System.Math.Atan2(y, x);
        }
    }
}
