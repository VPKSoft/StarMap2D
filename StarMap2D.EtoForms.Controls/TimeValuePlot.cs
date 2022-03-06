﻿#region License
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
using System.Collections.ObjectModel;
using System.Linq;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.EtoForms.Controls.Plotting;

namespace StarMap2D.EtoForms.Controls
{
    /// <summary>
    /// A control to plot linear time value data.
    /// Implements the <see cref="Eto.Forms.Drawable" />
    /// </summary>
    /// <seealso cref="Eto.Forms.Drawable" />
    public class TimeValuePlot : Drawable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeValuePlot"/> class.
        /// </summary>
        public TimeValuePlot()
        {
            Paint += PlotAltitudeAzimuth_Paint;
            SizeChanged += PlotAltitudeAzimuth_SizeChanged;
            AxisData.CollectionChanged += AxisData_CollectionChanged;
        }

        private void AxisData_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RecalculateAndPaint();
        }

        private void PlotAltitudeAzimuth_SizeChanged(object? sender, EventArgs e)
        {
            RecalculateAndPaint();
        }

        private void RecalculateAndPaint()
        {
            foreach (var axisData in AxisData)
            {
                axisData.XAxisWidth = Width - AxisPadding.Horizontal;
            }
            Invalidate();
        }

        private float AxisMinimum => (float)AxisData.Min(f => f.MinimumValue);

        private float AxisMaximum => (float)AxisData.Max(f => f.MaximumValue);

        private float AxisMinMax => Math.Max(Math.Abs(AxisMinimum), Math.Abs(AxisMaximum));

        private double CombinedDataLengthMinutes
        {
            get
            {
                var minTime = AxisData.Min(f => f.StarTime);
                var maxTime = AxisData.Min(f => f.EndTime);
                return (maxTime - minTime).TotalMinutes;
            }
        }

        // TODO::Document this!
        private void PlotAltitudeAzimuth_Paint(object? sender, PaintEventArgs e)
        {
            using var backgroundBrush = new SolidBrush(base.BackgroundColor);
            e.Graphics.FillRectangle(backgroundBrush, e.ClipRectangle);

            var yCenter = (Height - AxisPadding.Vertical) / 2 + AxisPadding.Top;
            var multiplier = (Height - AxisPadding.Vertical) / 2f / Math.Max(Math.Abs(AxisMinimum), Math.Abs(AxisMaximum));

            if (AxisMinimum > 0 && AxisMaximum > 0)
            {
                yCenter = Height - AxisPadding.Bottom;
                multiplier = (Height - AxisPadding.Vertical) / Math.Max(Math.Abs(AxisMinimum), Math.Abs(AxisMaximum));
            }

            // Draw the data points of all the axes.
            foreach (var axisData in AxisData)
            {
                for (int i = 0; i < Width - AxisPadding.Horizontal - 1 && i < axisData.YValues.Length - 1; i++)
                {
                    var y1 = yCenter - (float)axisData.YValues[i] * multiplier;
                    var y2 = yCenter - (float)axisData.YValues[i] * multiplier;
                    var x1 = i + AxisPadding.Left;
                    var x2 = x1 + 1;
                    e.Graphics.DrawLine(axisData.PlotColor, new PointF(x1, y1), new PointF(x2, y2));
                }
            }

            // Draw the Y-axis markings.
            for (var i = 0.0; i < AxisMinMax; i += YLabelStepping)
            {
                var y = yCenter - (float)i * multiplier;
                e.Graphics.DrawLine(YAxisMarkerColor, new PointF(AxisPadding.Left - 10, y), new PointF(AxisPadding.Left, y));

                // TODO::Parameterize
                var yLabelText = $"{i}°";
                var size = e.Graphics.MeasureString(Font, yLabelText);
                e.Graphics.DrawText(Font, YAxisMarkerColor, (AxisPadding.Left - size.Width) / 2f, y - size.Height / 2, yLabelText);
            }

            for (var i = -YLabelStepping; i > -AxisMinMax; i -= YLabelStepping)
            {
                var y = yCenter - (float)i * multiplier;
                e.Graphics.DrawLine(YAxisMarkerColor, new PointF(AxisPadding.Left - 10, y), new PointF(AxisPadding.Left, y));

                var yLabelText = $"{i}°";
                var size = e.Graphics.MeasureString(Font, yLabelText);
                e.Graphics.DrawText(Font, YAxisMarkerColor, (AxisPadding.Left - size.Width) / 2f, y - size.Height / 2, yLabelText);
            }

            // Draw the X-axis markings.
            for (var i = 0; i <= CombinedDataLengthMinutes; i += 60)
            {
                var x = e.ClipRectangle.Left + AxisPadding.Left + (i / CombinedDataLengthMinutes) * (Width - AxisPadding.Horizontal);
                e.Graphics.DrawLine(XAxisMarkerColor,
                    new PointF((float)x, e.ClipRectangle.Bottom - AxisPadding.Bottom),
                    new PointF((float)x, e.ClipRectangle.Bottom - AxisPadding.Bottom + 10));

                // TODO::Parameterize
                var xLabelText = TimeSpan.FromMinutes(i).ToString(@"hh");
                var size = e.Graphics.MeasureString(Font, xLabelText);
                e.Graphics.DrawText(Font, YAxisMarkerColor, (float)x - size.Width / 2f, e.ClipRectangle.Bottom - 10 - size.Height, xLabelText);
            }

            var topLeft = new PointF(e.ClipRectangle.Left + AxisPadding.Left, e.ClipRectangle.Top);
            var bottomLeft = new PointF(e.ClipRectangle.Left + AxisPadding.Left, e.ClipRectangle.Bottom);
            e.Graphics.DrawLine(AxisLineColor, topLeft, bottomLeft);

            using var pen = new Pen(ZeroLineColor) { DashStyle = new DashStyle(10, 5) };
            bottomLeft = new PointF(e.ClipRectangle.Left + AxisPadding.Left, yCenter);
            var bottomRight = new PointF(e.ClipRectangle.Right, yCenter);
            e.Graphics.DrawLine(pen, bottomLeft, bottomRight);

            bottomLeft = new PointF(e.ClipRectangle.Left, e.ClipRectangle.Bottom - AxisPadding.Bottom);
            bottomRight = new PointF(e.ClipRectangle.Right, e.ClipRectangle.Bottom - AxisPadding.Bottom);
            e.Graphics.DrawLine(AxisLineColor, bottomLeft, bottomRight);

            topLeft = new PointF(e.ClipRectangle.Left + AxisPadding.Left, e.ClipRectangle.Top + AxisPadding.Top);
            var topRight = new PointF(e.ClipRectangle.Right - AxisPadding.Right, e.ClipRectangle.Top + AxisPadding.Top);
            bottomRight = new PointF(e.ClipRectangle.Right - AxisPadding.Right, e.ClipRectangle.Bottom - AxisPadding.Bottom);
            e.Graphics.DrawLine(AxisLineColor, topLeft, topRight);
            e.Graphics.DrawLine(AxisLineColor, topRight, bottomRight);
        }

        #region PublicProperties
        /// <summary>
        /// Gets or sets the color for the background of the control
        /// </summary>
        /// <value>The color of the background.</value>
        /// <remarks>Note that on some platforms (e.g. Mac), setting the background color of a control can change the performance
        /// characteristics of the control and its children, since it must enable layers to do so.</remarks>
        public new Color BackgroundColor
        {
            get => base.BackgroundColor;

            set
            {
                if (value != base.BackgroundColor)
                {
                    base.BackgroundColor = value;
                    Invalidate();
                }
            }
        }

        private Color axisLineColor = Colors.Blue;

        /// <summary>
        /// Gets or sets the color of the axis lines.
        /// </summary>
        /// <value>The color of the axis lines.</value>
        public Color AxisLineColor
        {
            get => axisLineColor;

            set
            {
                if (value != axisLineColor)
                {
                    axisLineColor = value;
                    Invalidate();
                }
            }
        }

        private Color zeroLineColor = Colors.DarkBlue;

        /// <summary>
        /// Gets or sets the color of the zero line.
        /// </summary>
        /// <value>The color of the zero line.</value>
        public Color ZeroLineColor
        {
            get => zeroLineColor;

            set
            {
                if (zeroLineColor != value)
                {
                    zeroLineColor = value;
                    Invalidate();
                }
            }
        }

        private Color xAxisMarkerColor = Colors.Cyan;

        /// <summary>
        /// Gets or sets the color of the X-axis marker.
        /// </summary>
        /// <value>The color of the X-axis marker.</value>
        public Color XAxisMarkerColor
        {
            get => xAxisMarkerColor;

            set
            {
                if (xAxisMarkerColor != value)
                {
                    xAxisMarkerColor = value;
                    Invalidate();
                }
            }
        }

        private Color yAxisMarkerColor = Colors.Cyan;

        /// <summary>
        /// Gets or sets the color of the Y-axis marker.
        /// </summary>
        /// <value>The color of the Y-axis marker.</value>
        public Color YAxisMarkerColor
        {
            get => yAxisMarkerColor;

            set
            {
                if (yAxisMarkerColor != value)
                {
                    yAxisMarkerColor = value;
                    Invalidate();
                }
            }
        }

        private Padding axisPadding = new(40);

        /// <summary>
        /// Gets or sets the axis padding.
        /// </summary>
        /// <value>The axis padding.</value>
        public Padding AxisPadding
        {
            get => axisPadding;

            set
            {
                if (value != axisPadding)
                {
                    axisPadding = value;
                    Invalidate();
                }
            }
        }

        private double hourLabelFrequency = 1;

        /// <summary>
        /// Gets or sets the hour label frequency (The X-axis).
        /// </summary>
        /// <value>The hour label frequency (The X-axis).</value>
        public double HourLabelFrequency
        {
            get => hourLabelFrequency;

            set
            {
                if (Math.Abs(hourLabelFrequency - value) > Globals.FloatingPointTolerance)
                {
                    hourLabelFrequency = value;
                    Invalidate();
                }
            }
        }

        private double yLabelStepping = 10;

        /// <summary>
        /// Gets or sets the Y-axis label stepping.
        /// </summary>
        /// <value>The Y-axis label stepping.</value>
        public double YLabelStepping
        {
            get => yLabelStepping;

            set
            {
                if (Math.Abs(yLabelStepping - value) > Globals.FloatingPointTolerance)
                {
                    yLabelStepping = value;
                    Invalidate();
                }
            }
        }

        private Font font = Globals.Font;

        /// <summary>
        /// Gets or sets the font to draw labels to the chart.
        /// </summary>
        public Font Font
        {
            get => font;

            set
            {
                if (!Equals(value, font))
                {
                    font = value;
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// Gets the axis data collection.
        /// </summary>
        /// <value>The axis data collection.</value>
        public ObservableCollection<AxisData> AxisData { get; } = new();
        #endregion
    }
}