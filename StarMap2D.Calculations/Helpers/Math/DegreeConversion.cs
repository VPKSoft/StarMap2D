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
    /// A class for degrees to radians and radians to degrees conversion.
    /// </summary>
    public static class DegreeConversion
    {
        private const decimal PiDecimal = 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679M;
        private const float PiFloat = 3.141592653589793238462643383279502884f;

        /// <summary>
        /// Converts the specified <c>double</c> degrees to radians.
        /// </summary>
        /// <param name="degrees">The degrees to convert to radians.</param>
        /// <returns>A <c>double</c> value in radians.</returns>
        public static double ConvertToRadians(double degrees)
        {
            return (System.Math.PI / 180) * degrees;
        }

        /// <summary>
        /// Converts the specified <c>decimal</c> degrees to radians.
        /// </summary>
        /// <param name="degrees">The degrees to convert to radians.</param>
        /// <returns>A <c>decimal</c> value in radians.</returns>
        public static decimal ConvertToRadians(decimal degrees)
        {
            return (PiDecimal / 180) * degrees;
        }

        /// <summary>
        /// Converts the specified <c>float</c> degrees to radians.
        /// </summary>
        /// <param name="degrees">The degrees to convert to radians.</param>
        /// <returns>A <c>float</c> value in radians.</returns>
        public static float ConvertToRadians(float degrees)
        {
            return PiFloat / 180 * degrees;
        }

        /// <summary>
        /// Converts the specified <c>double</c> radians to degrees.
        /// </summary>
        /// <param name="radians">The radians to convert to degrees.</param>
        /// <returns>A <c>double</c> value in degrees.</returns>
        public static double ConvertToDegrees(double radians)
        {
            return (180 / System.Math.PI) * radians;
        }

        /// <summary>
        /// Converts the specified <c>decimal</c> radians to degrees.
        /// </summary>
        /// <param name="radians">The radians to convert to degrees.</param>
        /// <returns>A <c>decimal</c> value in degrees.</returns>
        public static decimal ConvertToDegrees(decimal radians)
        {
            return (180 / PiDecimal) * radians;
        }

        /// <summary>
        /// Converts the specified <c>float</c> radians to degrees.
        /// </summary>
        /// <param name="radians">The radians to convert to degrees.</param>
        /// <returns>A <c>float</c> value in degrees.</returns>
        public static float ConvertToDegrees(float radians)
        {
            return (180 / PiFloat) * radians;
        }

        /// <summary>
        /// Converts the value to radians.
        /// </summary>
        /// <param name="degrees">The value in degrees.</param>
        /// <returns>The value converted to radians.</returns>
        public static double ToRadians(this double degrees)
        {
            return ConvertToRadians(degrees);
        }

        /// <summary>
        /// Converts the value to degrees.
        /// </summary>
        /// <param name="radians">The value in radians.</param>
        /// <returns>The value converted to degrees.</returns>
        public static double ToDegrees(this double radians)
        {
            return ConvertToDegrees(radians);
        }
    }
}
