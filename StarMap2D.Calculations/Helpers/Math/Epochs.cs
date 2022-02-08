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
/// A class to convert epoch B1950 to J2000.
/// </summary>
// http://www.stargazing.net/kepler/b1950.html#twig07
public class Epochs
{
    /// <summary>
    /// Changes the epoch from B1950 to J2000.
    /// </summary>
    /// <param name="raHms">The right ascension in HMS format.</param>
    /// <param name="decDms">The decimal declination in DMS format.</param>
    /// <returns>A System.ValueTuple&lt;System.Double, System.Double&gt; containing the right ascension and declination in J2000 epoch.</returns>
    /// <remarks>Formula from: http://www.stargazing.net/kepler/b1950.html.</remarks>
    public static (double RightAscension, double Declination) ChangeEpochB1950ToJ2000(double raHms, double decDms)
    {
        var ra = HoursConvert.DecimalHoursToDegrees(raHms);
        var dec = DmsConvert.DecimalDmsToDegrees(decDms);

        var x = MathDegrees.Cos(ra) * MathDegrees.Cos(dec);
        var y = MathDegrees.Sin(ra) * MathDegrees.Cos(dec);
        var z = MathDegrees.Sin(dec);

        var x2 = 0.999925708 * x - 0.0111789372 * y - 0.0048590035 * z;
        var y2 = 0.0111789372 * x + 0.9999375134 * y - 0.0000271626 * z;
        var z2 = 0.0048590036 * x - 0.0000271579 * y + 0.9999881946 * z;

        var ra2 = MathDegrees.Atan2(y2, x2);

        if (y2 < 0 && x > 0)
        {
            ra2 += 360.0;
        }

        var dec2 = MathDegrees.Asin(z2);

        ra2 = HoursConvert.DecimalDegreesToHms(ra2);

        return (ra2, dec2);
    }

    /// <summary>
    /// Changes the epoch from B1950 to J2000.
    /// </summary>
    /// <param name="ra">The right ascension in degrees.</param>
    /// <param name="dec">The decimal declination degrees.</param>
    /// <returns>A System.ValueTuple&lt;System.Double, System.Double&gt; containing the right ascension and declination in J2000 epoch.</returns>
    /// <remarks>Formula from: http://www.stargazing.net/kepler/b1950.html.</remarks>
    public static (double RightAscension, double Declination) ChangeEpochB1950ToJ2000Degrees(double ra,
        double dec)
    {
        var raHms = HoursConvert.DecimalDegreesToHms(ra);
        var decDms = DmsConvert.DecimalDegreesToDms(dec);
        return ChangeEpochB1950ToJ2000(raHms, decDms);
    }
}