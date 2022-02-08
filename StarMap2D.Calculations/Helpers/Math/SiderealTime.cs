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

namespace StarMap2D.Calculations.Helpers.Math;

/// <summary>
/// A class for sidereal time calculations.
/// </summary>
public class SiderealTime
{
    /// <summary>
    /// Calculates the local sidereal time.
    /// </summary>
    /// <param name="dateTime">The date time for the calculation.</param>
    /// <param name="longitude">The geographic longitude.</param>
    /// <returns>The local sidereal time.</returns>
    // (C): https://github.com/Blank2275/AstroCoordsJS
    public static double CalculateLocalSiderealTime(DateTime dateTime, double longitude)
    {
        dateTime = dateTime.ToUniversalTime();
        var d2000 = new DateTime(2000, 1, 1, 12, 0, 0, DateTimeKind.Utc);
        var days = (dateTime - d2000).TotalDays;
        var hours = (double)dateTime.Hour;
        var minutes = (double)dateTime.Minute;
        var seconds = (double)dateTime.Second;
        var ms = (double)dateTime.Millisecond;
        var utc = (hours * (1000 * 60 * 60) + minutes * (1000 * 60) + seconds * 1000 + ms) /
            (1000 * 60 * 60 * 24) * 360;

        var lst = 100.46 + (0.985647 * days) + longitude + utc;

        if (lst > 360)
        {
            while (lst > 360)
            {
                lst -= 360;
            }
        }
        else if (lst < 0)
        {
            while (lst < 0)
            {
                lst += 360;
            }
        }

        return lst;
    }
}