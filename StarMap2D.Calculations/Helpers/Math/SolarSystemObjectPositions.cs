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
using StarMap2D.Calculations.Classes;
using StarMap2D.Calculations.Constellations.StaticData;
using StarMap2D.Calculations.Enumerations;
using StarMap2D.Calculations.Extensions;

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
    /// <param name="object">The one of the <see cref="AASEllipticalObject"/> enumeration values.</param>
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

    /// <summary>
    /// Gets the position of an object specified by the <paramref name="smallBody"/> value.
    /// </summary>
    /// <param name="smallBody">The one of the <see cref="SolarSystemSmallBodies"/> enumeration values.</param>
    /// <param name="aaDate">The <see cref="AASDate"/> date instance.</param>
    /// <param name="highPrecision">if set to <c>true</c> use high precision on calculations with the AASharp library.</param>
    /// <param name="longitude">The longitude of the observer.</param>
    /// <param name="latitude">The latitude of the observer.</param>
    /// <returns>A <see cref="AAS2DCoordinate"/> instance representing the <paramref name="smallBody"/> position in horizontal coordinates.</returns>
    public static AAS2DCoordinate GetSmallObjectPosition(SolarSystemSmallBodies smallBody, AASDate aaDate, bool highPrecision, double latitude, double longitude)
    {
        var bodies = new SmallBodies();
        var body = bodies[smallBody];
        var details = AASElliptical.Calculate(aaDate.Julian, ref body, highPrecision);
        var coordinate = new AAS2DCoordinate
            { X = details.AstrometricGeocentricRA % 360, Y = details.AstrometricGeocentricDeclination }.ToHorizontal(aaDate, latitude, longitude);
        return coordinate;
    }

    /// <summary>
    /// Gets the details for the specified solar system object.
    /// </summary>
    /// <param name="objectType">Type of the object.</param>
    /// <param name="aaDate">An instance of the <see cref="AASDate"/> class.</param>
    /// <param name="highPrecision">A value indicating whether to use high precision with the calculation.</param>
    /// <param name="latitude">The geographic latitude.</param>
    /// <param name="longitude">The geographic longitude.</param>
    /// <returns>Am instance to the <seealso cref="ObjectDetails"/> class with the specified object details.</returns>
    public static ObjectDetails GetDetails(ObjectsWithPositions objectType, AASDate aaDate, bool highPrecision, double latitude, double longitude)
    {
        var result = new ObjectDetails
        {
            DetailDateTime = aaDate.ToDateTime(),
        };

        if (objectType is
            ObjectsWithPositions.Ceres or
            ObjectsWithPositions.Chiron or
            ObjectsWithPositions.Eris or
            ObjectsWithPositions.Gonggong or
            ObjectsWithPositions.Haumea or
            ObjectsWithPositions.Juno or
            ObjectsWithPositions.Makemake or
            ObjectsWithPositions.Orcus or
            ObjectsWithPositions.Pallas or
            ObjectsWithPositions.Sedna or
            ObjectsWithPositions.Quaoar or
            ObjectsWithPositions.Vesta)
        {
            var bodies = new SmallBodies();
            var body = bodies[(SolarSystemSmallBodies)objectType];
            var details = AASElliptical.Calculate(aaDate.Julian, ref body, highPrecision);
            details.AstrometricGeocentricRA %= 360;
            result.RightAscension = HoursConvert.DecimalDegreesToHms(details.AstrometricGeocentricRA);
            result.Declination = details.AstrometricGeocentricDeclination;

            var horizontal =
                new AAS2DCoordinate
                        { X = details.AstrometricGeocentricRA, Y = details.AstrometricGeocentricDeclination }
                    .ToHorizontal(aaDate, latitude, longitude);

            result.HorizontalDegreesX = (horizontal.X + 180) % 360;
            result.HorizontalDegreesY = horizontal.Y;

            result.AboveHorizon = horizontal.X > 0;
        }

        if (objectType is
            ObjectsWithPositions.Mercury or
            ObjectsWithPositions.Venus or
            ObjectsWithPositions.Mars or
            ObjectsWithPositions.Jupiter or
            ObjectsWithPositions.Saturn or
            ObjectsWithPositions.Uranus or
            ObjectsWithPositions.Neptune or
            ObjectsWithPositions.Pluto)
        {
            var jd = aaDate.Julian + AASDynamicalTime.DeltaT(aaDate.Julian) / 86400.0;

            var planetaryDetails = AASElliptical.Calculate(jd, (AASEllipticalObject)objectType, Globals.HighPrecisionCalculations);

            result.RightAscension = planetaryDetails.ApparentGeocentricRA;
            result.Declination = planetaryDetails.ApparentGeocentricDeclination;

            var horizontal = new AAS2DCoordinate
                    { X = planetaryDetails.ApparentGeocentricRA, Y = planetaryDetails.ApparentGeocentricDeclination }
                .ToHorizontal(aaDate, latitude, longitude);
            
            result.HorizontalDegreesX = (horizontal.X + 180) % 360;
            result.HorizontalDegreesY = horizontal.Y;

            result.AboveHorizon = horizontal.Y > 0;
        }

        if (objectType == ObjectsWithPositions.Sun)
        {
            var jdSun = aaDate.Julian + AASDynamicalTime.DeltaT(aaDate.Julian) / 86400.0;
            var sunLong = AASSun.ApparentEclipticLongitude(jdSun, highPrecision);
            var sunLat = AASSun.ApparentEclipticLatitude(jdSun, highPrecision);

            var raDec = AASCoordinateTransformation.Ecliptic2Equatorial(sunLong, sunLat, AASNutation.TrueObliquityOfEcliptic(jdSun)); // RA/DEC

            result.RightAscension = raDec.X;
            result.Declination = raDec.Y;

            var horizontal =
                new AAS2DCoordinate
                        { X = sunLong, Y = sunLat }
                    .HorizontalTransform(longitude, latitude, jdSun); // Horizontal X, Y, 0 = East

            result.HorizontalDegreesX = (horizontal.X + 180) % 360;
            result.HorizontalDegreesY = horizontal.Y;
            result.HorizontalDegreesY = horizontal.Y;

            result.AboveHorizon = horizontal.Y > 0;
        }

        if (objectType == ObjectsWithPositions.Moon)
        {
            var jdSun = aaDate.Julian + AASDynamicalTime.DeltaT(aaDate.Julian) / 86400.0;
            var moonLong = AASMoon.EclipticLongitude(jdSun);
            var moonLat = AASMoon.EclipticLatitude(jdSun);

            var raDec = AASCoordinateTransformation.Ecliptic2Equatorial(moonLong, moonLat, AASNutation.TrueObliquityOfEcliptic(jdSun)); // RA/DEC

            result.RightAscension = raDec.X;
            result.Declination = raDec.Y;

            var horizontal =
                new AAS2DCoordinate
                        { X = moonLong, Y = moonLat }
                    .HorizontalTransform(longitude, latitude, jdSun); // Horizontal X, Y, 0 = East

            result.HorizontalDegreesX = (horizontal.X + 180) % 360;
            result.HorizontalDegreesY = horizontal.Y;

            result.AboveHorizon = horizontal.Y > 0;
        }

        return result;
    }
}