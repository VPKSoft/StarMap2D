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
using StarMap2D.Calculations.Helpers.Math;

namespace StarMap2D.Calculations.Plotting
{
    /// <summary>
    /// A class for plotting star data to a 2D projection.
    /// </summary>
    public class Plot2D
    {
        private DateTime dateTimeUtc = DateTime.UtcNow;
        private AASDate aaDate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Plot2D"/> class.
        /// </summary>
        /// <param name="latitude">The latitude of the observer in degrees.</param>
        /// <param name="longitude">The longitude of the observer in degrees.</param>
        public Plot2D(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            DateTimeUtc = DateTime.UtcNow;
            aaDate = new AASDate(dateTimeUtc.Year, dateTimeUtc.Month, dateTimeUtc.Day, dateTimeUtc.Hour,
                dateTimeUtc.Minute, dateTimeUtc.Second, true);
        }

        /// <summary>
        /// Gets or sets the longitude of the observer in degrees.
        /// </summary>
        /// <value>The longitude of the observer in degrees.</value>
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets the latitude of the observer in degrees.
        /// </summary>
        /// <value>The latitude of the observer in degrees.</value>
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use high precision on calculations with the AASharp library.
        /// </summary>
        /// <value><c>true</c> if to use high precision on calculations with the AASharp library; otherwise, <c>false</c>.</value>
        public bool HighPrecision { get; set; }

        /// <summary>
        /// Gets or sets the radius of the 2D plot area.
        /// </summary>
        /// <value>The radius of the 2D plot area.</value>
        public double Radius { get; set; } = 500;

        /// <summary>
        /// Gets or sets the date and time in UTC.
        /// </summary>
        /// <value>The date and time in UTC.</value>
        public DateTime DateTimeUtc
        {
            get => dateTimeUtc;

            set
            {
                if (value != dateTimeUtc)
                {
                    dateTimeUtc = value;
                    aaDate = new AASDate(dateTimeUtc.Year, dateTimeUtc.Month, dateTimeUtc.Day, dateTimeUtc.Hour,
                        dateTimeUtc.Minute, dateTimeUtc.Second, true);
                }
            } 
        }

        /// <summary>
        /// Project2s the specified horizontal coordinate to 2D coordinate.
        /// </summary>
        /// <param name="coordinate">The coordinate to project.</param>
        /// <returns>The 2D coordinate.</returns>
        public PointDouble Project2D(AAS2DCoordinate coordinate)
        {
            var azimuth = ((coordinate.X + 180) % 360).ToRadians();
            var altitude = (coordinate.Y).ToRadians();
            var x = Math.Sin(azimuth) * Math.Cos(altitude);
            var y = Math.Cos(azimuth) * Math.Cos(altitude);
            var z = Math.Sin(altitude);

            var x1 = x / (z + 1);
            var y1 = y / (z + 1);

            var r = Radius / 2;
            var xR = r * (1 - x1);
            var yR = r * (1 - y1);

            return new PointDouble { X = xR, Y = yR};
        }

        /// <summary>
        /// Gets the date as known by the AASharp library.
        /// </summary>
        /// <value>The date as known by the AASharp library.</value>
        public AASDate AaDate => aaDate;
    }
}
