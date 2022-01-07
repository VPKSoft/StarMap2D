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

namespace StarMap2D.Calculations.Plotting.Interfaces
{
    /// <summary>
    /// An interface for an object plotted to the star map.
    /// </summary>
    /// <typeparam name="T">The type of the graphics provider for the object.</typeparam>
    public interface IStarMapObject2D<T>
    {
        /// <summary>
        /// Gets or sets a value indicating whether the location of is star map 2D object is calculated. Ie. The Sun.
        /// </summary>
        /// <value><c>true</c> if this instance is location calculated; otherwise, <c>false</c>.</value>
        bool IsLocationCalculated { get; set; }

        /// <summary>
        /// A delegate for the <see cref="IStarMapObject2D{T}.CalculatePosition"/> property.
        /// </summary>
        /// <param name="aasDate">An instance to the <see cref="AASDate"/> class.</param>
        /// <param name="highPrecision">A value indicating whether to prefer high precision in the position calculation.</param>
        /// <param name="latitude">The latitude of the observer.</param>
        /// <param name="longitude">The longitude of the observer.</param>
        /// <param name="radius">The radius of the 2D projection of the star map.</param>
        /// <returns>An instance to a <see cref="PointDouble"/> class for the result of the calculation.</returns>
        public delegate PointDouble CalculatePositionDelegate(AASDate aasDate, bool highPrecision, double latitude,
            double longitude, double radius);

        /// <summary>
        /// A delegate to calculate the position of the star map 2D object if the <see cref="IsLocationCalculated"/> is set to <c>true</c>.
        /// </summary>
        CalculatePositionDelegate? CalculatePosition { get; set; }

        /// <summary>
        /// Gets or sets the right ascension of the object if the <see cref="IsLocationCalculated"/> is set to <c>false</c>.
        /// </summary>
        /// <value>The right ascension of the object.</value>
        public double RightAscension { get; set; }

        /// <summary>
        /// Gets or sets the right declination of the object if the <see cref="IsLocationCalculated"/> is set to <c>false</c>.
        /// </summary>
        /// <value>The declination of the object.</value>
        public double Declination { get; set; }

        /// <summary>
        /// Gets or sets the object graphics data for plotting the object to a star map.
        /// </summary>
        /// <value>The graphics data for plotting the object to a star map.</value>
        public T? ObjectGraphics { get; set; }

        /// <summary>
        /// Gets or sets the magnitude of the object.
        /// </summary>
        /// <value>The magnitude of the object.</value>
        public double Magnitude { get; set; }
    }
}
