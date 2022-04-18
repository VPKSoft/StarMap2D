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

using System.Globalization;

namespace StarMap2D.Common.Utilities;

/// <summary>
/// Some extensions for the <see cref="DateTime"/> type.
/// </summary>
public static class DateTimeExtensions
{
    /// <summary>
    /// Gets a value indicating whether the month is different for the specified <see cref="DateTime"/> and the comparison value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="comparisonDate">The comparison date.</param>
    /// <returns><c>true</c> if the month or year differs in comparison, <c>false</c> otherwise.</returns>
    public static bool MonthChanged(this DateTime value, DateTime comparisonDate)
    {
        return value.Year != comparisonDate.Year || value.Month != comparisonDate.Month;
    }

    /// <summary>
    /// Gets whe week number of the specified <see cref="DateTime"/> value.
    /// </summary>
    /// <param name="value">The value the get the week number for.</param>
    /// <returns>The week number of the specified date and time.</returns>
    public static int WeekOfTheYear(this DateTime value)
    {
        var formatInfo = DateTimeFormatInfo.CurrentInfo;
        var calendar = formatInfo.Calendar;

        return calendar.GetWeekOfYear(value, formatInfo.CalendarWeekRule, formatInfo.FirstDayOfWeek);
    }

    /// <summary>
    /// Gets the week starting <see cref="DateTime"/> value for the specified date and time.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>DateTime.</returns>
    public static DateTime WeekStartDate(this DateTime value)
    {
        var week = value.WeekOfTheYear();

        while (value.AddDays(-1).WeekOfTheYear() == week)
        {
            value = value.AddDays(-1);
        }

        return value;
    }
}