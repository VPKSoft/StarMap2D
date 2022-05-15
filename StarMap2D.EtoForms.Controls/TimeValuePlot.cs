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
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.EtoForms.Controls.Plotting;
using System.Collections.Generic;

namespace StarMap2D.EtoForms.Controls;

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
        MouseMove += TimeValuePlot_MouseMove;
    }

    private void TimeValuePlot_MouseMove(object? sender, MouseEventArgs e)
    {
        if (previousPlotArea?.Contains(e.Location) == true)
        {
            if (e.Location != mouseCoordinates)
            {
                Invalidate();
            }
            mouseCoordinates = e.Location;

            return;
        }

        if (mouseCoordinates != null)
        {
            mouseCoordinates = null;
            Invalidate();
        }
    }

    private void AxisData_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
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

    private float axisMinimum;

    /// <summary>
    /// Gets the axis minimum value for all axes specified in the <see cref="AxisData"/> property.
    /// </summary>
    /// <value>The axes minimum.</value>
    private float AxisMinimum
    {
        get
        {
            if (UseStaticMinimumMaximum)
            {
                return YAxesMinimum;
            }

            var calculateCurrentMinimum = (float)AxisData.Min(f => f.MinimumValue);

            if (!RememberAxesMaximum)
            {
                return calculateCurrentMinimum;
            }

            if (axisMinimum < calculateCurrentMinimum)
            {
                return axisMinimum;
            }

            axisMinimum = calculateCurrentMinimum;

            return calculateCurrentMinimum;
        }
    }

    private float axisMaximum;

    /// <summary>
    /// Gets the axis maximum value for all axes specified in the <see cref="AxisData"/> property.
    /// </summary>
    /// <value>The axes maximum.</value>
    private float AxisMaximum
    {
        get
        {
            if (UseStaticMinimumMaximum)
            {
                return YAxesMaximum;
            }

            var calculateCurrentMaximum = (float)AxisData.Max(f => f.MaximumValue);

            if (!RememberAxesMaximum)
            {
                return calculateCurrentMaximum;
            }

            if (axisMaximum > calculateCurrentMaximum)
            {
                return axisMaximum;
            }

            axisMaximum = calculateCurrentMaximum;

            return calculateCurrentMaximum;
        }
    }

    private float axisMinMax;

    /// <summary>
    /// Gets the axis absolute maximum value for all axes specified in the <see cref="AxisData"/> property.
    /// </summary>
    /// <value>The axes absolute absolute maximum.</value>
    private float AxisMinMax
    {
        get
        {
            if (UseStaticMinimumMaximum)
            {
                return Math.Max(Math.Abs(YAxesMinimum), Math.Abs(YAxesMaximum));
            }

            var calculatedCurrentMinMax = Math.Max(Math.Abs(AxisMinimum), Math.Abs(AxisMaximum));

            if (!RememberAxesMaximum)
            {
                return calculatedCurrentMinMax;
            }

            if (axisMinMax > calculatedCurrentMinMax)
            {
                return axisMinMax;
            }

            axisMinMax = calculatedCurrentMinMax;

            return calculatedCurrentMinMax;
        }
    }

    private double CombinedDataLengthMinutes
    {
        get
        {
            var minTime = AxisData.Min(f => f.StarTime);
            var maxTime = AxisData.Min(f => f.EndTime);
            return (maxTime - minTime).TotalMinutes;
        }
    }

    private void PlotAltitudeAzimuth_Paint(object? sender, PaintEventArgs e)
    {
        DrawGraph(e.Graphics, e.ClipRectangle);
    }

    private PointF? mouseCoordinates;
    private RectangleF? previousPlotArea;

    /// <summary>
    /// Draws the graph(s) and axes to the specified graphics.
    /// </summary>
    /// <param name="graphics">The graphics to draw on to.</param>
    /// <param name="drawArea">The drawing area rectangle.</param>
    private void DrawGraph(Graphics graphics, RectangleF drawArea)
    {
        previousPlotArea =
            new RectangleF(new PointF(drawArea.Left + AxisPadding.Left, drawArea.Top + AxisPadding.Top),
                new PointF(drawArea.Right - AxisPadding.Right, drawArea.Bottom - AxisPadding.Bottom));
        using var backgroundBrush = new SolidBrush(base.BackgroundColor);
        graphics.FillRectangle(backgroundBrush, drawArea);

        var yCenter = (Height - AxisPadding.Vertical) / 2 + AxisPadding.Top;
        var multiplier = (Height - AxisPadding.Vertical) / 2f / Math.Max(Math.Abs(AxisMinimum), Math.Abs(AxisMaximum));

        // If both values are positive, set the center to bottom and use a different multiplier.
        // NOTE: Never tested.
        if (AxisMinimum > 0 && AxisMaximum > 0)
        {
            yCenter = Height - AxisPadding.Bottom;
            multiplier = (Height - AxisPadding.Vertical) / Math.Max(Math.Abs(AxisMinimum), Math.Abs(AxisMaximum));
        }

        var lineY = 0f;
        var measureAddX = drawArea.Left + AxisPadding.Left;
        var measureAddY = drawArea.Top + AxisPadding.Top;

        var linePointsX = new List<float>();

        // Draw the data points of all the axes.
        foreach (var axisData in AxisData)
        {
            for (int i = 0; i < Width - AxisPadding.Horizontal - 1 && i < axisData.YValues.Length - 1; i++)
            {
                var y1 = yCenter - (float)axisData.YValues[i] * multiplier;
                var y2 = yCenter - (float)axisData.YValues[i] * multiplier;
                var x1 = i + AxisPadding.Left;
                var x2 = x1 + 1;
                graphics.DrawLine(axisData.PlotColor, new PointF(x1, y1), new PointF(x2, y2));
            }

            var measure = graphics.MeasureString(Font, axisData.XAxisLabel);

            if (!string.IsNullOrWhiteSpace(axisData.XAxisLabel))
            {
                lineY = measure.Height > lineY ? measure.Height : lineY;
                graphics.DrawText(Font, axisData.PlotColor, new PointF(measureAddX + 5, drawArea.Top + 2f),
                    axisData.XAxisLabel);
                measureAddX += measure.Width + 10f;
                linePointsX.Add(measureAddX);
            }

            if (!string.IsNullOrWhiteSpace(axisData.YAxisLabel))
            {
                measure = graphics.MeasureString(Font, axisData.YAxisLabel);
                graphics.DrawLine(AxisLineColor, new PointF(drawArea.Right - AxisPadding.Right, measureAddY),
                    new PointF(drawArea.Right, measureAddY));
                graphics.DrawText(Font, axisData.PlotColor,
                    new PointF(drawArea.Right - AxisPadding.Right + 5f,
                        measureAddY + measure.Height / 2f), axisData.YAxisLabel);
                measureAddY += measure.Height + 10f;
                graphics.DrawLine(AxisLineColor, new PointF(drawArea.Right - AxisPadding.Right, measureAddY),
                    new PointF(drawArea.Right, measureAddY));
            }
        }

        lineY += 4f;

        foreach (var p in linePointsX)
        {
            graphics.DrawLine(AxisLineColor, new PointF(p, drawArea.Top), new PointF(p, drawArea.Top + lineY));
        }

        graphics.DrawLine(AxisLineColor, new PointF(drawArea.Left + AxisPadding.Left, lineY), new PointF(drawArea.Right, lineY));


        // Draw the positive Y-axis markings.
        for (var i = 0.0; i < AxisMinMax; i += YLabelStepping)
        {
            var y = yCenter - (float)i * multiplier;
            graphics.DrawLine(YAxisMarkerColor, new PointF(AxisPadding.Left - 10, y), new PointF(AxisPadding.Left, y));

            var yLabelText = string.Format(YLabelFormat, i);
            var size = graphics.MeasureString(Font, yLabelText);
            graphics.DrawText(Font, YAxisMarkerColor, (AxisPadding.Left - size.Width) / 2f, y - size.Height / 2, yLabelText);
        }

        // Draw the negative Y-axis markings.
        for (var i = -YLabelStepping; i > -AxisMinMax; i -= YLabelStepping)
        {
            var y = yCenter - (float)i * multiplier;
            graphics.DrawLine(YAxisMarkerColor, new PointF(AxisPadding.Left - 10, y), new PointF(AxisPadding.Left, y));

            var yLabelText = string.Format(YLabelFormat, i);
            var size = graphics.MeasureString(Font, yLabelText);
            graphics.DrawText(Font, YAxisMarkerColor, (AxisPadding.Left - size.Width) / 2f, y - size.Height / 2, yLabelText);
        }

        // Draw the X-axis markings.
        for (var i = 0; i <= CombinedDataLengthMinutes; i += 60)
        {
            var timeSpan = TimeSpan.FromMinutes(i);
            if ((timeSpan.Hours % HourLabelFrequency) != 0)
            {
                // Skip according to the parametrization.
                continue;
            }

            var x = drawArea.Left + AxisPadding.Left + (i / CombinedDataLengthMinutes) * (Width - AxisPadding.Horizontal);
            graphics.DrawLine(XAxisMarkerColor,
                new PointF((float)x, drawArea.Bottom - AxisPadding.Bottom),
                new PointF((float)x, drawArea.Bottom - AxisPadding.Bottom + 10));

            var xLabelText = timeSpan.ToString(TimeLabelFormat);
            var size = graphics.MeasureString(Font, xLabelText);
            graphics.DrawText(Font, YAxisMarkerColor, (float)x - size.Width / 2f, drawArea.Bottom - 10 - size.Height, xLabelText);
        }

        // Draw the X-axis line.
        var topLeft = new PointF(drawArea.Left + AxisPadding.Left, drawArea.Top);
        var bottomLeft = new PointF(drawArea.Left + AxisPadding.Left, drawArea.Bottom);
        graphics.DrawLine(AxisLineColor, topLeft, bottomLeft);

        // Draw the zero marker line.
        using var pen = new Pen(ZeroLineColor) { DashStyle = new DashStyle(10, 5), };
        bottomLeft = new PointF(drawArea.Left + AxisPadding.Left, yCenter);
        var bottomRight = new PointF(drawArea.Right, yCenter);
        graphics.DrawLine(pen, bottomLeft, bottomRight);

        // Draw the Y-axis line.
        bottomLeft = new PointF(drawArea.Left, drawArea.Bottom - AxisPadding.Bottom);
        bottomRight = new PointF(drawArea.Right, drawArea.Bottom - AxisPadding.Bottom);
        graphics.DrawLine(AxisLineColor, bottomLeft, bottomRight);

        // Draw the to and right area limit lines.
        topLeft = new PointF(drawArea.Left + AxisPadding.Left, drawArea.Top + AxisPadding.Top);
        var topRight = new PointF(drawArea.Right - AxisPadding.Right, drawArea.Top + AxisPadding.Top);
        bottomRight = new PointF(drawArea.Right - AxisPadding.Right, drawArea.Bottom - AxisPadding.Bottom);
        graphics.DrawLine(AxisLineColor, topLeft, topRight);
        graphics.DrawLine(AxisLineColor, topRight, bottomRight);

        // Draw the cross hairs if configured to do so.
        if (DrawCrossHairs && mouseCoordinates != null)
        {
            foreach (var axisData in AxisData)
            {
                using var crossHairPen = new Pen(axisData.PlotColor) { DashStyle = new DashStyle(10, 5), };
                var yValue =
                    (float)axisData.GetYAxisValueAtXPoint(mouseCoordinates.Value.X - AxisPadding.Left -
                                                          drawArea.Left);
                var yPoint = yCenter - yValue * multiplier;

                // Draw the vertical cross hair line.
                var vertical1 = new PointF(mouseCoordinates.Value.X, drawArea.Top + AxisPadding.Top);
                var vertical2 = new PointF(mouseCoordinates.Value.X, drawArea.Bottom - axisPadding.Bottom);
                graphics.DrawLine(crossHairPen, vertical1, vertical2);

                // Draw the horizontal cross hair line.
                var horizontal1 = new PointF(drawArea.Left + AxisPadding.Left, yPoint);
                var horizontal2 = new PointF(drawArea.Right - AxisPadding.Right, yPoint);
                graphics.DrawLine(crossHairPen, horizontal1, horizontal2);

                // Draw the X-axis value label.
                var xValue = axisData.GetXAxisValueAtPoint(mouseCoordinates.Value.X - AxisPadding.Left - drawArea.Left);

                var timeLabelValue = TimeSpan.FromMinutes(xValue).ToString(CrossHairTimeLabelFormat);
                var size = graphics.MeasureString(Font, timeLabelValue);
                var timeLabelPoint = new PointF(vertical1.X - size.Width / 2f, lineY + 2f);
                graphics.DrawText(Font, axisData.PlotColor, timeLabelPoint, timeLabelValue);

                // Draw the Y-axis value label.
                var yLabelValue = string.Format(YCrossHairLabelFormat, yValue);
                size = graphics.MeasureString(Font, yLabelValue);
                var labelYPoint = new PointF(horizontal2.X, horizontal2.Y - size.Width / 2);
                graphics.DrawText(Font, axisData.PlotColor, labelYPoint, yLabelValue);

            }
        }
    }

    #region PublicProperties
    private bool useStaticMinimumMaximum = true;

    /// <summary>
    /// Gets or sets a value indicating whether to use static minimum and maximum values
    /// on the Y-axes specified by the <see cref="YAxesMinimum"/> and <see cref="YAxesMaximum"/> property values.
    /// </summary>
    /// <value><c>true</c> if to use static minimum and maximum values for the Y-axes; otherwise, <c>false</c>.</value>
    public bool UseStaticMinimumMaximum
    {
        get => useStaticMinimumMaximum;

        set
        {
            if (useStaticMinimumMaximum != value)
            {
                useStaticMinimumMaximum = value;
                Invalidate();
            }
        }
    }

    private float yAxesMinimum = -90;

    /// <summary>
    /// Gets or sets the static Y-axes minimum value.
    /// </summary>
    /// <value>The static Y-axes minimum.</value>
    public float YAxesMinimum
    {
        get => yAxesMinimum;

        set
        {
            if (Math.Abs(yAxesMinimum - value) > Globals.FloatingPointSingleTolerance)
            {
                yAxesMinimum = value;
                Invalidate();
            }
        }
    }

    private float yAxesMaximum = 90;

    /// <summary>
    /// Gets or sets the static Y-axes maximum value.
    /// </summary>
    /// <value>The static Y-axes maximum.</value>
    public float YAxesMaximum
    {
        get => yAxesMaximum;

        set
        {
            if (Math.Abs(yAxesMaximum - value) > Globals.FloatingPointSingleTolerance)
            {
                yAxesMaximum = value;
                Invalidate();
            }
        }
    }

    private bool rememberAxesMaximum = true;

    /// <summary>
    /// Gets or sets a value indicating whether to remember axes maximum value and not to rescale on data point changes.
    /// </summary>
    /// <value><c>true</c> if to remember axes maximum; otherwise, <c>false</c>.</value>
    public bool RememberAxesMaximum
    {
        get => rememberAxesMaximum;

        set
        {
            if (value != rememberAxesMaximum)
            {
                axisMinimum = default;
                axisMaximum = default;
                axisMinMax = default;
                rememberAxesMaximum = value;
            }
        }
    }

    /// <summary>
    /// Gets or sets the color for the background of the control
    /// </summary>
    /// <value>The color of the background.</value>
    /// <remarks>Note that on some platforms (g. Mac), setting the background color of a control can change the performance
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

    private string yLabelFormat = "{0:F0}°";

    /// <summary>
    /// Gets or sets the Y-axis label format.
    /// </summary>
    /// <value>The Y-axis label format.</value>
    public string YLabelFormat
    {
        get => yLabelFormat;

        set
        {
            if (yLabelFormat != value)
            {
                yLabelFormat = value;
                Invalidate();
            }
        }
    }

    private string yCrossHairLabelFormat = "{0:F2}°";

    /// <summary>
    /// Gets or sets the Y-axis cross hair label value format.
    /// </summary>
    /// <value>The Y-axis cross hair label value format.</value>
    public string YCrossHairLabelFormat
    {
        get => yCrossHairLabelFormat;

        set
        {
            if (yCrossHairLabelFormat != value && mouseCoordinates != null)
            {
                yCrossHairLabelFormat = value;
                Invalidate();
            }

            yCrossHairLabelFormat = value;
        }
    }

    private string timeLabelFormat = "hh";

    /// <summary>
    /// Gets or sets the time label format.
    /// </summary>
    /// <value>The time label format.</value>
    /// <remarks>
    /// The format is for method <see cref="TimeSpan.ToString(string)"/> method. For more info see: <para/>
    /// * https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-timespan-format-strings<para/>
    /// * https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-timespan-format-strings<para/>
    /// E.g. "hh\:mm\:ss".
    /// </remarks>
    public string TimeLabelFormat
    {
        get => timeLabelFormat;

        set
        {
            if (value != timeLabelFormat)
            {
                timeLabelFormat = value;
                Invalidate();
            }
        }
    }

    private string crossHairTimeLabelFormat = @"hh\:mm";

    /// <summary>
    /// Gets or sets the cross hair time label format.
    /// </summary>
    /// <value>The cross hair time label format.</value>
    /// <remarks>
    /// The format is for method <see cref="TimeSpan.ToString(string)"/> method. For more info see: <para/>
    /// * https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-timespan-format-strings<para/>
    /// * https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-timespan-format-strings<para/>
    /// E.g. "hh\:mm\:ss".
    /// </remarks>
    public string CrossHairTimeLabelFormat
    {
        get => crossHairTimeLabelFormat;

        set
        {
            if (crossHairTimeLabelFormat != value && mouseCoordinates != null)
            {
                crossHairTimeLabelFormat = value;
                Invalidate();
            }

            crossHairTimeLabelFormat = value;
        }
    }

    private bool drawCrossHairs;

    /// <summary>
    /// Gets or sets a value indicating whether to draw cross hairs to track the value at mouse location.
    /// </summary>
    /// <value><c>true</c> if draw cross hairs to track to value at mouse location; otherwise, <c>false</c>.</value>
    public bool DrawCrossHairs
    {
        get => drawCrossHairs;

        set
        {
            if (drawCrossHairs != value && mouseCoordinates != null)
            {
                drawCrossHairs = value;
                Invalidate();
            }

            drawCrossHairs = value;
        }
    }


    /// <summary>
    /// Gets the axes data collection.
    /// </summary>
    /// <value>The axes data collection.</value>
    public ObservableCollection<AxisData> AxisData { get; } = new();
    #endregion
}