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
using StarMap2D.Calculations.Constellations.Enumerations;
using StarMap2D.Calculations.Constellations.Interfaces;
using StarMap2D.Calculations.Constellations.StaticData;
using StarMap2D.Calculations.Helpers.Math;

namespace StarMap2D.Calculations.Constellations;

/// <summary>
/// A class to help check points and constellation boundaries.
/// </summary>
public class PointInConstellation
{
    /// <summary>
    /// Gets the constellation for a specified point.
    /// </summary>
    /// <param name="rightAscension">The right ascension of the point.</param>
    /// <param name="declination">The declination of the point.</param>
    /// <returns>A <see cref="ConstellationValue"/> enumeration value if a constellation was found for the point; <c>null</c> otherwise.</returns>
    public static ConstellationValue? GetConstellationForPoint(double rightAscension, double declination)
    {
        var result = new List<(ConstellationValue Constellation, double centerDistance)>();
        foreach (var classesEnum in ConstellationClassEnumMap.ConstellationClassesEnums)
        {
            var constellation = (IConstellation<ConstellationArea, ConstellationLine>)Activator.CreateInstance(classesEnum.ConstellationClassType)!;
            var coordinates = constellation.Boundary.ToList()
                .Select(f => new AAS2DCoordinate { X = f.RightAscension, Y = f.Declination, }).ToArray();

            var inPolygon = PolygonShapes.PointInPolygon(coordinates, rightAscension, declination, out _);

            // Trust the distance to the constellation centroid in case of multiple results.
            var centroid = PointUtils.GetCentroid(coordinates.Select(f => (f.X, f.Y)).ToArray());

            var distance =
                PointUtils.PointDistance(centroid, (rightAscension, declination));

            if (inPolygon)
            {
                result.Add((classesEnum.Constellation, distance));
            }
        }

        return !result.Any()
            ? null
            : result.OrderBy(f => f.centerDistance).FirstOrDefault().Constellation;
    }
}
