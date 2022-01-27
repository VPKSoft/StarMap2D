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
/// Class DMS format to degrees or radians and vice versa.
/// </summary>
public class DmsConvert
{
    /// <summary>
    /// Converts the specified degrees, minutes and seconds to degrees.
    /// </summary>
    /// <param name="degrees">The degrees.</param>
    /// <param name="minutes">The minutes.</param>
    /// <param name="seconds">The seconds.</param>
    /// <returns>The specified degrees, minutes and seconds converted into degrees.</returns>
    public static double DmsToDegrees(double degrees, double minutes, double seconds)
    {
        return (System.Math.Abs(degrees) + minutes / 60.0 + seconds / 3600.0) * System.Math.Sign(degrees);
    }

    /// <summary>
    /// Converts the specified decimal DMS to degrees.
    /// </summary>
    /// <param name="dms">The DMS decimal degrees.</param>
    /// <returns>The specified decimal DMS converted into degrees.</returns>
    public static double DecimalDmsToDegrees(double dms)
    {
        var hours = System.Math.Floor(dms);
        var minutes = (dms - hours) * 100;
        var seconds = 0.0;
        return DmsToDegrees(hours, minutes, seconds);
    }

    /// <summary>
    /// Converts the specified degrees, minutes and seconds to radians.
    /// </summary>
    /// <param name="degrees">The degrees.</param>
    /// <param name="minutes">The minutes.</param>
    /// <param name="seconds">The seconds.</param>
    /// <returns>The specified degrees, minutes and seconds converted into radians.</returns>
    public static double DmsToRadians(double degrees, double minutes, double seconds)
    {
        return DmsToDegrees(degrees, minutes, seconds) * MathDegrees.DegreesRadians;
    }

    /// <summary>
    /// Converts the specified decimal DMS to radians.
    /// </summary>
    /// <param name="dms">The DMS decimal degrees.</param>
    /// <returns>The specified decimal DMS converted into radians.</returns>
    public static double DecimalDmsToRadians(double dms)
    {
        return DecimalDmsToDegrees(dms) * MathDegrees.DegreesRadians;
    }

    /// <summary>
    /// Convert degrees tto decimal DMS degrees.
    /// </summary>
    /// <param name="degrees">The degrees.</param>
    /// <returns>A value converted to HMS format.</returns>
    public static double DecimalDegreesToDms(double degrees)
    {
        var d = System.Math.Floor(degrees);
        var decimals = (degrees - d) / 100.0 * 60;
        return d + decimals;
    }
}