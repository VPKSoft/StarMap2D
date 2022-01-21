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
}