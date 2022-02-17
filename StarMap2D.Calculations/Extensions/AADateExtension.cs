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

using AASharp;

namespace StarMap2D.Calculations.Extensions;

/// <summary>
/// Extension methods for the <see cref="AASDate"/> class.
/// </summary>
// ReSharper disable once InconsistentNaming
public static class AADateExtension
{
    /// <summary>
    /// Gets the current UTC date and time in gregorian calendar.
    /// </summary>
    /// <returns>The current UTC date and time.</returns>
    public static AASDate Now()
    {
        var dateTime = DateTime.UtcNow;
        return new AASDate(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute,
            dateTime.Second, true);
    }

    /// <summary>
    /// Adds the specified amount of seconds to the specified <see cref="AASDate"/> class instance without <see cref="DateTime"/> conversion in between.
    /// </summary>
    /// <param name="value">The <see cref="AASDate"/> value.</param>
    /// <param name="seconds">The amount of seconds to add.</param>
    /// <returns>A new instance to a <see cref="AASDate"/> class with specified amount of seconds added into.</returns>
    public static AASDate AddSecondsFast(this AASDate value, double seconds)
    {
        var secondsInDay = 24 * 60 * 60D;
        var jd = value.Julian + seconds / secondsInDay;

        return new AASDate(jd, value.InGregorianCalendar);
    }

    /// <summary>
    /// Gets the decimal hours of the specified <see cref="AASDate"/> instance.
    /// </summary>
    /// <param name="value">The <see cref="AASDate"/> value.</param>
    /// <returns>The decimal hours of the <see cref="AASDate"/> instance.</returns>
    public static double Hours(this AASDate value)
    {
        return value.Hour + value.Minute / 60.0 + value.Second / 3600.0;
    }

    /// <summary>
    /// Gets the decimal hours of the specified <see cref="AASDate"/> instance.
    /// </summary>
    /// <param name="value">The <see cref="AASDate"/> value.</param>
    /// <param name="addHours">An amount of hours to add to the value.</param>
    /// <returns>The decimal hours of the <see cref="AASDate"/> instance.</returns>
    public static double Hours(this AASDate value, double addHours)
    {
        return (value.Hour + value.Minute / 60.0 + value.Second / 3600.0 + addHours) % 24;
    }


    /// <summary>
    /// Converts the value of the specified <see cref="AASDate"/> instance to the equivalent OLE Automation date.
    /// </summary>
    /// <param name="value">The <see cref="AASDate"/> value.</param>
    /// <returns>A double-precision floating-point number that contains an OLE Automation date equivalent to the value of this instance.</returns>
    // ReSharper disable once InconsistentNaming
    public static double ToAODate(this AASDate value)
    {
        return value.Julian - 2415018.5;
    }

    /// <summary>
    /// Gets the Julian Days (JD) of the specified <see cref="AASDate"/> value.
    /// </summary>
    /// <param name="value">The value to get the Julian Date for.</param>
    /// <returns>The Julian Date (JD).</returns>
    // ReSharper disable once InconsistentNaming
    public static double GetJD(this AASDate value)
    {
        return AASDate.DateToJD(value.Year, value.Month, value.Day, value.InGregorianCalendar);
    }

    /// <summary>
    /// Gets a new instance of the <see cref="AASDate"/> with specified time values.
    /// </summary>
    /// <param name="value">The <see cref="AASDate"/> value.</param>
    /// <param name="hour">The new hour value.</param>
    /// <param name="minute">The new minute value.</param>
    /// <param name="second">The new second value.</param>
    /// <returns>S new instance of the <see cref="AASDate"/>.</returns>
    public static AASDate WithTime(this AASDate value, int hour, int minute, int second)
    {
        return new AASDate(value.Year, value.Month, value.Day, hour, minute, second, value.InGregorianCalendar);
    }

    /// <summary>
    /// Converts the specified <see cref="AASDate"/> value to <see cref="DateTime"/> value.
    /// </summary>
    /// <param name="value">The <see cref="AASDate"/> value to convert.</param>
    /// <returns> A <see cref="DateTime"/> value.</returns>
    public static DateTime ToDateTime(this AASDate value)
    {
        return new DateTime((int)value.Year, (int)value.Month, (int)value.Day, (int)value.Hour, (int)value.Minute,
            (int)value.Second, DateTimeKind.Utc);
    }

    /// <summary>
    /// Adds the specified amount of seconds to the specified <see cref="AASDate"/> class instance.
    /// </summary>
    /// <param name="value">The <see cref="AASDate"/> value.</param>
    /// <param name="seconds">The amount of seconds to add.</param>
    /// <returns>A new instance to a <see cref="AASDate"/> class with specified amount of seconds added into.</returns>
    public static AASDate AddSeconds(this AASDate value, double seconds)
    {
        var dateTime = new DateTime((int)value.Year, (int)value.Month, (int)value.Day, (int)value.Hour, (int)value.Minute, (int)value.Second, DateTimeKind.Utc);
        dateTime = dateTime.AddSeconds(seconds);
        return new AASDate(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute,
            dateTime.Second, true);
    }

    /// <summary>
    /// Adds the specified amount of days to the specified <see cref="AASDate"/> class instance.
    /// </summary>
    /// <param name="value">The <see cref="AASDate"/> value.</param>
    /// <param name="days">The amount of days to add.</param>
    /// <returns>A new instance to a <see cref="AASDate"/> class with specified amount of days added into.</returns>
    public static AASDate AddDays(this AASDate value, double days)
    {
        return value.AddSeconds(days * 24.0 * 60.0 * 60.0);
    }
}