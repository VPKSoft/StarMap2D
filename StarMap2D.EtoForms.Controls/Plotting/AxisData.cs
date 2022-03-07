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

using System;
using System.Linq;
using Eto.Drawing;

namespace StarMap2D.EtoForms.Controls.Plotting
{
    /// <summary>
    /// A class for the <see cref="TimeValuePlot"/> control axis data.
    /// </summary>
    public class AxisData
    {
        private double[] values = Array.Empty<double>();
        private double xXAxisWidth;

        /// <summary>
        /// Gets or sets the values for the Y-axis.
        /// </summary>
        /// <value>The Y-axis values.</value>
        public double[] Values
        {
            get => values;

            set
            {
                if (!values.SequenceEqual(value))
                {
                    values = value;
                    MinimumValue = values.Min();
                    MaximumValue = values.Max();
                }
            }
        }

        /// <summary>
        /// Gets or sets the Y-axis values computed to fit the visual X-axis.
        /// </summary>
        /// <value>The Y-axis values computed to fit the visual X-axis.</value>
        internal double[] YValues { get; set; } = Array.Empty<double>();

        /// <summary>
        /// Gets the Y-axis value at X-point in pixels.
        /// </summary>
        /// <param name="xPoint">The X-coordinate point.</param>
        /// <returns>The Y-coordinate value in pixels.</returns>
        internal double GetYAxisValueAtXPoint(double xPoint)
        {
            var point = (int)xPoint;
            if (point > 0 && point < YValues.Length)
            {
                return YValues[point];
            }

            return 0;
        }

        /// <summary>
        /// Gets the X-axis value at coordinate point.
        /// </summary>
        /// <param name="xPoint">The X-coordinate point value.</param>
        /// <returns>The value at the specified X-coordinate.</returns>
        internal double GetXAxisValueAtPoint(double xPoint)
        {
            return xPoint / XAxisWidth * (EndTime - StarTime).TotalMinutes;
        }

        /// <summary>
        /// Gets the X-axis length in minutes.
        /// </summary>
        /// <value>The X-axis length in minutes.</value>
        public double AxisLengthMinutes => (EndTime - StarTime).TotalMinutes;

        /// <summary>
        /// Gets the minimum value of the Y-axis.
        /// </summary>
        /// <value>The Y-axis minimum value.</value>
        public double MinimumValue { get; private set; }

        /// <summary>
        /// Gets the maximum value of the Y-axis.
        /// </summary>
        /// <value>The Y-axis maximum value.</value>
        public double MaximumValue { get; private set; }

        /// <summary>
        /// Gets or sets the visual width of the X-axis in pixels.
        /// </summary>
        /// <value>The visual width of the X-axis.</value>
        public double XAxisWidth
        {
            get => xXAxisWidth;

            set
            {
                if (Math.Abs(xXAxisWidth - value) > Globals.FloatingPointTolerance)
                {
                    if (value < 1)
                    {
                        return;
                    }

                    xXAxisWidth = value;
                    var timePerXAxisUnit = AxisLengthMinutes / xXAxisWidth;

                    YValues = new double[(int)XAxisWidth + 1];

                    var yValueIndex = 0;
                    for (var i = 0.0; i < AxisLengthMinutes; i += timePerXAxisUnit)
                    {
                        var take = (int)timePerXAxisUnit;
                        take = take < 1 ? 1 : take;

                        var yValue = values.Skip((int)i).Take(take).Average();
                        YValues[yValueIndex++] = yValue;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets the star time of the X-axis.
        /// </summary>
        /// <value>The star time of the X-axis.</value>
        public DateTime StarTime { get; set; } = DateTime.Now.Date;

        /// <summary>
        /// Gets or sets the end time of the X-axis.
        /// </summary>
        /// <value>The star end of the X-axis.</value>
        public DateTime EndTime { get; set; } = DateTime.Now.AddDays(1).Date;

        /// <summary>
        /// Gets or sets the X-axis label.
        /// </summary>
        /// <value>The X-axis label.</value>
        public string XAxisLabel { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Y-axis label.
        /// </summary>
        /// <value>The Y-axis label.</value>
        public string YAxisLabel { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the color for plotting the axis data.
        /// </summary>
        /// <value>The color for plotting the axis data.</value>
        public Color PlotColor { get; set; } = Colors.SteelBlue;
    }
}