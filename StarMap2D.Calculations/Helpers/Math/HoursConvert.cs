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
    /// Class HMS format to degrees or radians and vice versa.
    /// </summary>
    public class HoursConvert
    {
        /// <summary>
        /// Converts the specified hours, minutes and seconds to degrees.
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <param name="minutes">The minutes.</param>
        /// <param name="seconds">The seconds.</param>
        /// <returns>The specified hours, minutes and seconds converted into degrees.</returns>
        public static double HoursToDegrees(double hours, double minutes, double seconds)
        {
            return (hours + minutes / 60.0 + seconds / 3600.0) * 15.0;
        }

        /// <summary>
        /// Converts the specified decimal hours to degrees.
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <returns>The specified decimal hours converted into degrees.</returns>
        public static double DecimalHoursToDegrees(double hours)
        {
            var hour = System.Math.Floor(hours);
            var minutes = (hours - hour) * 100.0;
            var seconds = 0.0;

            return HoursToDegrees(hour, minutes, seconds);
        }

        /// <summary>
        /// Converts the specified hours, minutes and seconds to radians.
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <param name="minutes">The minutes.</param>
        /// <param name="seconds">The seconds.</param>
        /// <returns>The specified hours, minutes and seconds converted into radians.</returns>
        public static double HoursToRadians(double hours, double minutes, double seconds)
        {
            return HoursToDegrees(hours, minutes, seconds) * MathDegrees.DegreesRadians;
        }

        /// <summary>
        /// Converts the specified decimal hours to radians.
        /// </summary>
        /// <param name="hours">The hours.</param>
        /// <returns>The specified decimal hours converted into radians.</returns>
        public static double HoursToRadians(double hours)
        {
            return DecimalHoursToDegrees(hours) * MathDegrees.DegreesRadians;
        }

        /// <summary>
        /// Convert degrees to decimal hours.
        /// </summary>
        /// <param name="degrees">The degrees.</param>
        /// <returns>A value converted to decimal hours.</returns>
        public static double DecimalDegreesToHms(double degrees)
        {
            var hour = System.Math.Floor(degrees / 15.0);
            var decimals = degrees / 15.0 - hour;
            return hour + decimals;
        }
    }
}
