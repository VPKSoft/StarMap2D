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

using StarMap2D.Calculations.Enumerations;
using StarMap2D.Calculations.Helpers.Math;

namespace StarMap2D.Calculations.Helpers.DateAndTime;

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

    /// <summary>
    /// Truncates the <see cref="DateTime"/> to hours removing minutes, seconds and fractional parts.
    /// </summary>
    /// <param name="dateTime">The date time.</param>
    /// <returns>A mew <see cref="DateTime"/>.</returns>
    public static DateTime TruncateToHours(this DateTime dateTime)
    {
        return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0, dateTime.Kind);
    }

    /// <summary>
    /// Adds the value of specified interval to the date and time.
    /// </summary>
    /// <param name="dateTime">The date time.</param>
    /// <param name="value">The value to add.</param>
    /// <param name="interval">The interval type to add.</param>
    /// <returns>A new <see cref="DateTime"/> object adjusted with the specified value of interval amount.</returns>
    public static DateTime AddInterval(this DateTime dateTime, double value, TimeInterval interval)
    {
        switch (interval)
        {
            case TimeInterval.Millisecond:
                return dateTime.AddMilliseconds(value);
            case TimeInterval.Second:
                return dateTime.AddSeconds(value);
            case TimeInterval.Minute:
                return dateTime.AddMinutes(value);
            case TimeInterval.Hour:
                return dateTime.AddHours(value);
            case TimeInterval.Day:
                return dateTime.AddDays(value);
            case TimeInterval.Week:
                return dateTime.AddDays(7.0 * value);
            case TimeInterval.Month:
                return dateTime.AddDays(30.436875 * value);
            case TimeInterval.Year:
                return dateTime.AddDays(365.2425 * value);
            default:
                return dateTime.AddSeconds(0);
        }
    }

    /// <summary>
    /// Converts the specified <see cref="DateTime" /> into local sidereal time using the specified longitude.
    /// </summary>
    /// <param name="value">The <see cref="DateTime" /> value to convert.</param>
    /// <param name="longitude">The longitude of the geographic location to get the local sidereal time for.</param>
    /// <returns>The local sidereal time.</returns>
    /// <remarks>
    /// The specified date and time is converted into Coordinated Universal Time (UTC) before conversion.
    /// If the <see cref="DateTime.Kind"/> is already <see cref="DateTimeKind.Utc"/>, no conversion occurs.
    /// </remarks>
    // (C): https://github.com/Blank2275/AstroCoordsJS
    public static double ToLocalSiderealTime(this DateTime value, double longitude)
    {
        return SiderealTime.CalculateLocalSiderealTime(value.ToUniversalTime(), longitude);
    }
}