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
/// Extension methods for the <see cref="DateTime"/> conversion from <seealso cref="AASDate"/>
/// </summary>
public static class DateTimeAADateExtensions
{
    /// <summary>
    /// Converts the specified <see cref="DateTime"/> value to a new <see cref="AASDate"/> value.
    /// </summary>
    /// <param name="value">The <see cref="DateTime"/> value to convert.</param>
    /// <returns>An instance to a <see cref="AASDate"/> class.</returns>
    // ReSharper disable once InconsistentNaming
    public static AASDate ToAASDate(this DateTime value)
    {
        return new AASDate(value.Year, value.Month, value.Day, value.Hour, value.Minute,
            value.Second, true);
    }
}