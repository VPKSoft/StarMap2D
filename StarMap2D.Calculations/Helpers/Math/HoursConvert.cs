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
