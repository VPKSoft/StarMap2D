namespace StarMap2D.Calculations.Helpers.Math
{
    /// <summary>
    /// Class DMS format to degrees or radians and vice versa.
    /// </summary>
    public class DmsConvert
    {
        /// <summary>
        /// Converts the specified degrees, minutes and seconds to degrees.
        /// </summary>
        /// <param name="degrees">The degrees.</param>
        /// <param name="minutes">The minutes.</param>
        /// <param name="seconds">The seconds.</param>
        /// <returns>The specified degrees, minutes and seconds converted into degrees.</returns>
        public static double DmsToDegrees(double degrees, double minutes, double seconds)
        {
            return degrees + minutes / 60.0 + seconds / 3600.0;
        }

        /// <summary>
        /// Converts the specified decimal DMS to degrees.
        /// </summary>
        /// <param name="dms">The DMS decimal degrees.</param>
        /// <returns>The specified decimal DMS converted into degrees.</returns>
        public static double DecimalDmsToDegrees(double dms)
        {
            var hours = System.Math.Floor(dms);
            var minutes = (dms - hours) * 100;
            var seconds = 0.0;
            return DmsToDegrees(hours, minutes, seconds);
        }

        /// <summary>
        /// Converts the specified degrees, minutes and seconds to radians.
        /// </summary>
        /// <param name="degrees">The degrees.</param>
        /// <param name="minutes">The minutes.</param>
        /// <param name="seconds">The seconds.</param>
        /// <returns>The specified degrees, minutes and seconds converted into radians.</returns>
        public static double DmsToRadians(double degrees, double minutes, double seconds)
        {
            return DmsToDegrees(degrees, minutes, seconds) * MathDegrees.DegreesRadians;
        }

        /// <summary>
        /// Converts the specified decimal DMS to radians.
        /// </summary>
        /// <param name="dms">The DMS decimal degrees.</param>
        /// <returns>The specified decimal DMS converted into radians.</returns>
        public static double DecimalDmsToRadians(double dms)
        {
            return DecimalDmsToDegrees(dms) * MathDegrees.DegreesRadians;
        }

        /// <summary>
        /// Convert degrees tto decimal DMS degrees.
        /// </summary>
        /// <param name="degrees">The degrees.</param>
        /// <returns>A value converted to HMS format.</returns>
        public static double DecimalDegreesToDms(double degrees)
        {
            var d = System.Math.Floor(degrees);
            var decimals = (degrees - d) / 100.0 * 60;
            return d + decimals;
        }
    }
}
