namespace StarMap2D.Calculations.Helpers.Math
{
    /// <summary>
    /// Trigonometric functions in degrees rather than radian.
    /// </summary>
    public class MathDegrees
    {
        private const double RadiansDegrees = 180.0 / System.Math.PI;
        private const double DegreesRadians = System.Math.PI / 180.0;


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
            return RadiansDegrees * System.Math.Asin(d * DegreesRadians);
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
