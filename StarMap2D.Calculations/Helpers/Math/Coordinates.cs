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

namespace StarMap2D.Calculations.Helpers.Math
{
    /// <summary>
    /// Coordinate transformation helpers for the <see cref="AAS2DCoordinate"/> class.
    /// </summary>
    public static class Coordinates
    {
        /// <summary>
        /// Converts the specified ecliptic coordinates to horizontal.
        /// </summary>
        /// <param name="coordinate">The coordinate.</param>
        /// <param name="aaDate">The aa date.</param>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns>AAS2DCoordinate.</returns>
        public static AAS2DCoordinate ToHorizontal(this AAS2DCoordinate coordinate, AASDate aaDate, double latitude, double longitude)
        {
            var rightAscension = coordinate.X;
            var declination = coordinate.Y;

            var meanGreenwichSiderealTime = AASSidereal.MeanGreenwichSiderealTime(aaDate.Julian);
            var meanLocalSiderealTime = meanGreenwichSiderealTime + AASCoordinateTransformation.DegreesToHours(longitude);
            var localHourAngle = meanLocalSiderealTime - rightAscension;
            var result = AASCoordinateTransformation.Equatorial2Horizontal(localHourAngle, declination, latitude);
            return result;
        }

        /// <summary>
        /// Transforms specified ecliptic coordinates into horizontal coordinates.
        /// </summary>
        /// <param name="ecliptic">The ecliptic coordinates of the object.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="latitude">The latitude.</param>
        /// <param name="julianDay">The julian day.</param>
        /// <returns>AAS2DCoordinate.</returns>
        public static AAS2DCoordinate HorizontalTransform(this AAS2DCoordinate ecliptic, double longitude, double latitude, double julianDay)
        {
            var eclipticLongitude = ecliptic.X;
            var eclipticLatitude = ecliptic.Y;

            var equatorial = AASCoordinateTransformation.Ecliptic2Equatorial(eclipticLongitude, eclipticLatitude, AASNutation.TrueObliquityOfEcliptic(julianDay));
            var ra = equatorial.X;
            var de = equatorial.Y;

            var meanSiderealTime = AASSidereal.MeanGreenwichSiderealTime(julianDay);
            var localMeanSiderealTime= meanSiderealTime + AASCoordinateTransformation.DegreesToHours(longitude);
            var lha = localMeanSiderealTime - ra;
            var coordinate = AASCoordinateTransformation.Equatorial2Horizontal(lha, de, latitude);

            return coordinate;
        }
    }
}
