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

namespace StarMap2D.Common.Utilities;

/// <summary>
/// Some extensions for the <see cref="DateOnly"/> type.
/// </summary>
public static class DateOnlyExtensions
{
    /// <summary>
    /// Converts the value to a <see cref="DateTime"/> value.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="kind">The <see cref="DateTimeKind"/> kind.</param>
    /// <returns>A converted <see cref="DateTime"/> value.</returns>
    public static DateTime ToDateTime(this DateOnly value, DateTimeKind kind)
    {
        return new DateTime(value.Year, value.Month, value.Day, 0, 0, 0, kind);
    }

    /// <summary>
    /// Converts the value to a <see cref="DateTime"/> value.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A converted <see cref="DateTime"/> value.</returns>
    public static DateTime ToDateTime(this DateOnly value)
    {
        return new DateTime(value.Year, value.Month, value.Day);
    }
}