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

namespace StarMap2D.Calculations.Helpers.Math
{
    /// <summary>
    /// Calculations for circle shape.
    /// </summary>
    public class Circle
    {
        /// <summary>
        /// Checks if the specified point is inside a specified circle.
        /// </summary>
        /// <param name="circleX">The center point X-coordinate of the circle.</param>
        /// <param name="circleY">The center point Y-coordinate of the circle.</param>
        /// <param name="radius">The radius of the circle.</param>
        /// <param name="x">The X-coordinate of the point to check for.</param>
        /// <param name="y">The Y-coordinate of the point to check for.</param>
        /// <returns><c>true</c> if the point is inside the circle, <c>false</c> otherwise.</returns>
        /// <remarks>Copyright (C): https://www.geeksforgeeks.org/find-if-a-point-lies-inside-or-on-circle/.</remarks>
        public static bool PointIsInside(double circleX, double circleY, double radius, double x, double y)
        {
            if ((x - circleX) * (x - circleX) + (y - circleY) * (y - circleY) <= radius * radius)
            {
                return true;
            }

            return false;
        }
    }
}
