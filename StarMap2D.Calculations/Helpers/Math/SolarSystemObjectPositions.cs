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

namespace StarMap2D.Calculations.Helpers.Math;

/// <summary>
/// A class to calculate solar system object locations in horizontal coordinates.
/// </summary>
public class SolarSystemObjectPositions
{
    /// <summary>
    /// Gets the sun position.
    /// </summary>
    /// <param name="aaDate">The <see cref="AASDate"/> date instance.</param>
    /// <param name="highPrecision">if set to <c>true</c> use high precision on calculations with the AASharp library.</param>
    /// <param name="longitude">The longitude of the observer.</param>
    /// <param name="latitude">The latitude of the observer.</param>
    /// <returns>A <see cref="AAS2DCoordinate"/> instance representing the sun position in horizontal coordinates.</returns>
    public static AAS2DCoordinate GetSunPosition(AASDate aaDate, bool highPrecision, double longitude,
        double latitude)
    {
        var jdSun = aaDate.Julian + AASDynamicalTime.DeltaT(aaDate.Julian) / 86400.0;
        var sunLong = AASSun.ApparentEclipticLongitude(jdSun, highPrecision);
        var sunLat = AASSun.ApparentEclipticLatitude(jdSun, highPrecision);

        return new AAS2DCoordinate { X = sunLong, Y = sunLat }.HorizontalTransform(longitude, latitude, jdSun);
    }

    /// <summary>
    /// Gets the moon position.
    /// </summary>
    /// <param name="aaDate">The <see cref="AASDate"/> date instance.</param>
    /// <param name="highPrecision">if set to <c>true</c> use high precision on calculations with the AASharp library.</param>
    /// <param name="longitude">The longitude of the observer.</param>
    /// <param name="latitude">The latitude of the observer.</param>
    /// <returns>A <see cref="AAS2DCoordinate"/> instance representing the moon position in horizontal coordinates.</returns>
    public static AAS2DCoordinate GetMoonPosition(AASDate aaDate, bool highPrecision, double longitude,
        double latitude)
    {
        var jd = aaDate.Julian + AASDynamicalTime.DeltaT(aaDate.Julian) / 86400.0;
        var moonLong = AASMoon.EclipticLongitude(jd);
        var moonLat = AASMoon.EclipticLatitude(jd);

        return new AAS2DCoordinate { X = moonLong, Y = moonLat }.HorizontalTransform(longitude, latitude, jd);
    }

    /// <summary>
    /// Gets the position of an object specified by the <paramref name="object"/> value.
    /// </summary>
    /// <param name="object">The one of the <see cref="AASEllipticalObject"/> enumeration value. </param>
    /// <param name="aaDate">The <see cref="AASDate"/> date instance.</param>
    /// <param name="highPrecision">if set to <c>true</c> use high precision on calculations with the AASharp library.</param>
    /// <param name="longitude">The longitude of the observer.</param>
    /// <param name="latitude">The latitude of the observer.</param>
    /// <returns>A <see cref="AAS2DCoordinate"/> instance representing the <paramref name="object"/> position in horizontal coordinates.</returns>
    public static AAS2DCoordinate GetObjectPosition(AASEllipticalObject @object, AASDate aaDate, bool highPrecision,
        double longitude,
        double latitude)
    {
        var jd = aaDate.Julian + AASDynamicalTime.DeltaT(aaDate.Julian) / 86400.0;

        var planetaryDetails = AASElliptical.Calculate(jd, @object, highPrecision);

        return new AAS2DCoordinate
        { X = planetaryDetails.ApparentGeocentricRA, Y = planetaryDetails.ApparentGeocentricDeclination }
            .ToHorizontal(aaDate, latitude, longitude);
    }
}