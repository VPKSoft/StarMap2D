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
/// A class to calculate some 2D point stuff.
/// </summary>
public class PointUtils
{
    /// <summary>
    /// Gets the centroid of a polygon.
    /// </summary>
    /// <param name="points">The points of the polygon.</param>
    /// <returns>The centroid point of the polygon.</returns>
    /// <remarks>Source (with modification) Copyright (©): https://www.geeksforgeeks.org/find-the-centroid-of-a-non-self-intersecting-closed-polygon/.</remarks>
    public static (double X, double Y) GetCentroid((double X, double Y)[] points)
    {
        var answer = (0.0, 0.0);

        int n = points.GetLength(0);
        double signedArea = 0;

        // For all vertices
        for (int i = 0; i < n; i++)
        {
            var x0 = points[i].X;
            var y0 = points[i].Y;
            var x1 = points[(i + 1) % n].X;
            var y1 = points[(i + 1) % n].Y;

            // Calculate value of A
            // using shoelace formula
            double a = (x0 * y1) - (x1 * y0);
            signedArea += a;

            // Calculating coordinates of
            // centroid of polygon
            answer.Item1 += (x0 + x1) * a;
            answer.Item2 += (y0 + y1) * a;
        }
        signedArea *= 0.5;
        answer.Item1 /= (6 * signedArea);
        answer.Item2 /= (6 * signedArea);

        return answer;
    }

    /// <summary>
    /// Calculates the distance between two points.
    /// </summary>
    /// <param name="point1">The first point.</param>
    /// <param name="point2">The second point.</param>
    /// <returns>The distance between the two points.</returns>
    public static double PointDistance((double X, double Y) point1, (double X, double Y) point2)
    {
        var distance =
            System.Math.Sqrt(
                System.Math.Pow(point1.X - point2.X, 2) +
                 System.Math.Pow(point1.Y - point2.Y, 2));

        return distance;
    }
}