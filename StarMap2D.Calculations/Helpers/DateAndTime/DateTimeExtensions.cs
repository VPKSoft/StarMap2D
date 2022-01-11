namespace StarMap2D.Calculations.Helpers.DateAndTime
{
    /// <summary>
    /// Some extension methods to the <see cref="DateTime"/> struct.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Converts the hour, minute, second and millisecond part into a decimal number.
        /// </summary>
        /// <param name="dt">A DateTime value of which decimal hours to get.</param>
        /// <returns>Amount of decimal hours in the given <paramref name="dt">dt</paramref></returns>
        public static double ToDecimalHour(this DateTime dt)
        {
            return dt.Hour + dt.Minute / 60.0 + (dt.Second + dt.Millisecond / 1000.0)  / 3600.0;
        }

        /// <summary>
        /// Converts the hour, minute, second and millisecond part into a decimal number divided by 24.
        /// </summary>
        /// <param name="dt">A DateTime value of which decimal hours to get and divide by 24.</param>
        /// <returns>Amount of decimal hours in the given <paramref name="dt">dt</paramref> divided by 24.</returns>
        public static double ToDecimalHourFraction(this DateTime dt)
        {
            return dt.ToDecimalHour() / 24.0;
        }
    }

}
