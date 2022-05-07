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

namespace StarMap2D.Calculations.Extensions;

/// <summary>
/// Some time extensions for the <see cref="DateTime"/> struct.
/// </summary>
public static class HourExtensions
{
    /// <summary>
    /// Gets the decimal hours of the specified <see cref="DateTime"/> value.
    /// </summary>
    /// <param name="value">The <see cref="DateTime"/> value.</param>
    /// <returns>The time in decimal hours.</returns>
    public static double DecimalHours(this DateTime value)
    {
        var result = value.Hour + value.Minute / 60.0 + value.Second / 3600.0 + (value.Millisecond / 3_600_000.0);
        return result;
    }
}