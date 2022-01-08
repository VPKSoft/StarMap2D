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

using VPKSoft.StarCatalogs;

/*
 * Code © C# Helper, Determine whether a point is inside a polygon in C#.
 * http://csharphelper.com/blog/2014/07/determine-whether-a-point-is-inside-a-polygon-in-c/.
 * No license information provided.
 */

namespace StarMap2D.Calculations.Helpers.Math
{
    /// <summary>
    /// A class for calculations for different shapes.
    /// Based on the article(©): http://csharphelper.com/blog/2014/07/determine-whether-a-point-is-inside-a-polygon-in-c/.
    /// </summary>
    public class PolygonShapes
    {
        // Return True if the point is in the polygon.

        /// <summary>
        /// Gets a value indicating whether the specified point is inside a specified polygon.
        /// </summary>
        /// <param name="points">The points of the polygon.</param>
        /// <param name="x">The x-coordinate of the point.</param>
        /// <param name="y">The y-coordinate of the point.</param>
        /// <returns><c>true</c> if the point is inside the polygon, <c>false</c> otherwise.</returns>
        /// <remarks>Based on the article (©): http://csharphelper.com/blog/2014/07/determine-whether-a-point-is-inside-a-polygon-in-c/.</remarks>
        public static bool PointInPolygon(PointDouble[] points, double x, double y)
        {
            // Get the angle between the point and the
            // first and last vertices.
            var max_point = points.Length - 1;
            var total_angle = GetAngle(
                points[max_point].X, points[max_point].Y,
                x, y,
                points[0].X, points[0].Y);

            // Add the angles from the point
            // to each other pair of vertices.
            for (var i = 0; i < max_point; i++)
            {
                total_angle += GetAngle(
                    points[i].X, points[i].Y,
                    x, y,
                    points[i + 1].X, points[i + 1].Y);
            }

            // The total angle should be 2 * PI or -2 * PI if
            // the point is in the polygon and close to zero
            // if the point is outside the polygon.
            // The following statement was changed. See the comments.
            //return (Math.Abs(total_angle) > 0.000001);
            return (System.Math.Abs(total_angle) > 1);
        }

        // Return the angle ABC.
        // Return a value between PI and -PI.
        // Note that the value is the opposite of what you might
        // expect because Y coordinates increase downward.

        /// <summary>
        /// Gets the angle ABC.
        /// </summary>
        /// <param name="Ax">The ax.</param>
        /// <param name="Ay">The ay.</param>
        /// <param name="Bx">The bx.</param>
        /// <param name="By">The by.</param>
        /// <param name="Cx">The cx.</param>
        /// <param name="Cy">The cy.</param>
        /// <returns>Return a value between π and -π.</returns>
        /// <remarks>Note that the value is the opposite of what you might expect because Y coordinates increase downward.</remarks>
        private static double GetAngle(double Ax, double Ay,
            double Bx, double By, double Cx, double Cy)
        {
            // Get the dot product.
            var dot_product = DotProduct(Ax, Ay, Bx, By, Cx, Cy);

            // Get the cross product.
            var cross_product = CrossProductLength(Ax, Ay, Bx, By, Cx, Cy);

            // Calculate the angle.
            return (double)System.Math.Atan2(cross_product, dot_product);
        }

        // Return the dot product AB · BC.
        // Note that AB · BC = |AB| * |BC| * Cos(theta).
        private static double DotProduct(double Ax, double Ay,
            double Bx, double By, double Cx, double Cy)
        {
            // Get the vectors' coordinates.
            var BAx = Ax - Bx;
            var BAy = Ay - By;
            var BCx = Cx - Bx;
            var BCy = Cy - By;

            // Calculate the dot product.
            return (BAx * BCx + BAy * BCy);
        }

        // Return the cross product AB x BC.
        // The cross product is a vector perpendicular to AB
        // and BC having length |AB| * |BC| * Sin(theta) and
        // with direction given by the right-hand rule.
        // For two vectors in the X-Y plane, the result is a
        // vector with X and Y components 0 so the Z component
        // gives the vector's length and direction.

        /// <summary>
        /// Gets the cross product of AB x BC.
        /// The cross product is a vector perpendicular to AB and BC having length |AB| * |BC| * Sin(theta) and with direction given by the right-hand rule. For two vectors in the X-Y plane, the result is a vector with X and Y components 0 so the Z component gives the vector's length and direction.
        /// </summary>
        /// <param name="Ax">The ax.</param>
        /// <param name="Ay">The ay.</param>
        /// <param name="Bx">The bx.</param>
        /// <param name="By">The by.</param>
        /// <param name="Cx">The cx.</param>
        /// <param name="Cy">The cy.</param>
        /// <returns>The cross product AB x BC.</returns>
        private static double CrossProductLength(double Ax, double Ay,
            double Bx, double By, double Cx, double Cy)
        {
            // Get the vectors' coordinates.
            var BAx = Ax - Bx;
            var BAy = Ay - By;
            var BCx = Cx - Bx;
            var BCy = Cy - By;

            // Calculate the Z coordinate of the cross product.
            return (BAx * BCy - BAy * BCx);
        }
    }
}
