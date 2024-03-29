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
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Calculations.MoonCalculations;
using StarMap2D.Common.Utilities;
using StarMap2D.EtoForms.Controls.Interfaces;
using StarMap2D.EtoForms.Controls.Utilities;

namespace StarMap2D.EtoForms.Controls.MoonCalendar;

/// <summary>
/// A control to represent a single cell in a moon calendar.
/// Implements the <see cref="Eto.Forms.Panel" />
/// Implements the <see cref="StarMap2D.EtoForms.Controls.Interfaces.ICalendarCell" />
/// </summary>
/// <seealso cref="Eto.Forms.Panel" />
/// <seealso cref="StarMap2D.EtoForms.Controls.Interfaces.ICalendarCell" />
public class MoonCalendarCell : Panel, ICalendarCell
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MoonCalendarCell"/> class.
    /// </summary>
    /// <param name="date">The date for the moon phase calculation.</param>
    /// <param name="latitude">The latitude of the observer for the moon phase calculation.</param>
    /// <param name="longitude">The longitude of the observer for the moon phase calculation.</param>
    /// <param name="useMoonTilt">if set to <c>true</c> draw the moon phase disc tilt angle.</param>
    /// <param name="monthNumber">The month number to detect if the cell is out of the active month.</param>
    /// <param name="mouseClick">An action to execute when the moon visualization or the date is clicked.</param>
    public MoonCalendarCell(
        DateOnly date, double latitude, double longitude,
        bool useMoonTilt, int monthNumber,
        Action<DateTime>? mouseClick = null)
    {
        this.monthNumber = monthNumber;
        this.mouseClick = mouseClick;

        base.BackgroundColor = backgroundColor;

        MouseDown += MoonCalendarCell_MouseDown;

        Date = date;

        var moonPhase = new MoonPhase(latitude, longitude, Date.ToDateTime(), Date.ToDateTime());

        lbDate.Text = date.ToString("d.M");
        lbRise.Text = moonPhase.RiseDateTime?.ToString("HH:mm") ?? NaText;
        lbSet.Text = moonPhase.SetDateTime?.ToString("HH:mm") ?? NaText;

        lbDate.MouseDown += MoonCalendarCell_MouseDown;

        var visualization = new MoonPhaseVisualization
        {
            MoonPhase = moonPhase.Phase,
            MoonIlluminatedFraction = moonPhase.MoonIlluminatedFraction,
            MoonDiscTiltAngle = useMoonTilt ? moonPhase.MoonDiscTiltAngle : 0,
        };

        visualization.Cursor = mouseClick != null ? Cursors.Pointer : Cursors.Default;

        imageDate = new SvgImageView(
            StarMap2D.EtoForms.Controls.Properties.Resources.ic_fluent_calendar_month_28_filled,
            IndicatorImageColor)
        { Size = new Size(16, 16), };
        imageRise = new SvgImageView(
            StarMap2D.EtoForms.Controls.Properties.Resources.ic_fluent_arrow_sort_up_24_filled,
            IndicatorImageColor)
        { Size = new Size(16, 16), };
        imageSet = new SvgImageView(
            StarMap2D.EtoForms.Controls.Properties.Resources.ic_fluent_arrow_sort_down_24_filled,
            IndicatorImageColor)
        { Size = new Size(16, 16), };

        Content = new TableLayout
        {
            Rows =
            {
                EtoHelpers.TableWrap(true,
                    imageDate,
                    lbDate,
                    imageRise,
                    lbRise,
                    imageSet,
                    lbSet),
                new TableRow(visualization) { ScaleHeight = true, },
            },
        };

        base.ToolTip = $"{DateText}: {date.ToString("d.M")}" +
                       "\n" +
                       $"{RiseText}: {moonPhase.RiseDateTime?.ToString("HH:mm") ?? NaText}, {SetText}: {moonPhase.SetDateTime?.ToString("HH:mm") ?? NaText}" +
                       "\n" +
                       $"{MoonDiscIlluminationPercentageText}: {moonPhase.MoonIlluminatedFraction * 100:F1}";

        UpdateTextColors();
        UpdateImageColors();
        if (IsOutOfActiveMonth)
        {
            base.BackgroundColor = BackgroundColorOutOfMonth;
        }
        else
        {
            base.BackgroundColor = IsCurrentDate ? BackgroundColorCurrent : BackgroundColor;
        }
    }

    private void MoonCalendarCell_MouseDown(object? sender, MouseEventArgs e)
    {
        if (e.Buttons == MouseButtons.Primary)
        {
            mouseClick?.Invoke(Date.ToDateTime(DateTimeKind.Utc));
        }
    }

    private readonly Action<DateTime>? mouseClick;

    /// <summary>
    /// Gets a value indicating whether this instance is set to the current date.
    /// </summary>
    /// <value><c>true</c> if this instance is set to the current date; otherwise, <c>false</c>.</value>
    private bool IsCurrentDate => Date == DateOnly.FromDateTime(DateTime.Now);

    /// <summary>
    /// Gets a value indicating whether this instance is out of active month.
    /// </summary>
    /// <value><c>true</c> if this instance is out of active month; otherwise, <c>false</c>.</value>
    private bool IsOutOfActiveMonth => Date.Month != monthNumber;

    private Color backgroundColorCurrent = Colors.White;

    /// <summary>
    /// Gets or sets the background color for the current date.
    /// </summary>
    /// <value>The background color for the current date.</value>
    public Color BackgroundColorCurrent
    {
        get => backgroundColorCurrent;

        set
        {
            if (backgroundColorCurrent != value)
            {
                backgroundColorCurrent = value;
                base.BackgroundColor = IsCurrentDate ? backgroundColorCurrent : BackgroundColor;
            }
        }
    }

    private Color textColorOther = Colors.White;

    /// <summary>
    /// Gets or sets the text color for the non-current dates for the month.
    /// </summary>
    /// <value>The text color for the non-current dates.</value>
    public Color TextColorOther
    {
        get => textColorOther;

        set
        {
            if (textColorOther != value)
            {
                textColorOther = value;
                UpdateTextColors();
            }
        }
    }

    private Color indicatorImageColor = Colors.SteelBlue;

    /// <summary>
    /// Gets or sets the color of the indicator image.
    /// </summary>
    /// <value>The color of the indicator image.</value>
    public Color IndicatorImageColor
    {
        get => indicatorImageColor;

        set
        {
            if (value != indicatorImageColor)
            {
                indicatorImageColor = value;
                UpdateImageColors();
            }
        }
    }

    private Color indicatorImageColorActive = Colors.SteelBlue;

    /// <summary>
    /// Gets or sets the indicator image color for current day.
    /// </summary>
    /// <value>The indicator image color for current day.</value>
    public Color IndicatorImageColorActive
    {
        get => indicatorImageColorActive;

        set
        {
            if (value != indicatorImageColorActive)
            {
                indicatorImageColorActive = value;
                UpdateImageColors();
            }
        }
    }

    private Color indicatorImageColorOutOfMonth = Color.FromArgb(0x4F, 0x4F, 0x50);

    /// <summary>
    /// Gets or sets the indicator image color for current day.
    /// </summary>
    /// <value>The indicator image color for current day.</value>
    public Color IndicatorImageColorOutOfMonth
    {
        get => indicatorImageColorOutOfMonth;

        set
        {
            if (value != indicatorImageColorOutOfMonth)
            {
                indicatorImageColorOutOfMonth = value;
                UpdateImageColors();
            }
        }
    }


    private Color textColorOutOfMonth = Color.FromArgb(0x47, 0x47, 0x4B);

    /// <summary>
    /// Gets or sets the text color for the out of month dates.
    /// </summary>
    /// <value>The background color for the current date.</value>
    public Color TextColorOutOfMonth
    {
        get => textColorOutOfMonth;

        set
        {
            if (textColorOutOfMonth != value)
            {
                textColorOutOfMonth = value;
                UpdateTextColors();
            }
        }
    }

    private Color backgroundColorOutOfMonth = Color.FromArgb(0x38, 0x38, 0x3D);

    /// <summary>
    /// Gets or sets the background color for the out of month dates.
    /// </summary>
    /// <value>The background color for the out of month dates.</value>
    public Color BackgroundColorOutOfMonth
    {
        get => backgroundColorOutOfMonth;

        set
        {
            if (backgroundColorOutOfMonth != value)
            {
                backgroundColorOutOfMonth = value;
                if (IsOutOfActiveMonth)
                {
                    base.BackgroundColor = backgroundColorOutOfMonth;
                }
                else
                {
                    base.BackgroundColor = IsCurrentDate ? BackgroundColorCurrent : BackgroundColor;
                }
            }
        }
    }

    private void UpdateTextColors()
    {
        if (IsOutOfActiveMonth)
        {
            lbRise.TextColor = TextColorOutOfMonth;
            lbSet.TextColor = TextColorOutOfMonth;
            lbDate.TextColor = TextColorOutOfMonth;
        }
        else
        {
            lbRise.TextColor = IsCurrentDate ? ForeColor : TextColorOther;
            lbSet.TextColor = IsCurrentDate ? ForeColor : TextColorOther;
            lbDate.TextColor = IsCurrentDate ? ForeColor : TextColorOther;
        }
    }

    private void UpdateImageColors()
    {
        if (IsOutOfActiveMonth)
        {
            imageRise.SvgStrokeColor = IndicatorImageColorOutOfMonth;
            imageRise.SvgFillColor = IndicatorImageColorOutOfMonth;
            imageSet.SvgStrokeColor = IndicatorImageColorOutOfMonth;
            imageSet.SvgFillColor = IndicatorImageColorOutOfMonth;
            imageDate.SvgStrokeColor = IndicatorImageColorOutOfMonth;
            imageDate.SvgFillColor = IndicatorImageColorOutOfMonth;
        }
        else
        {
            imageRise.SvgStrokeColor = IsCurrentDate ? IndicatorImageColorActive : IndicatorImageColor;
            imageRise.SvgFillColor = IsCurrentDate ? IndicatorImageColorActive : IndicatorImageColor;
            imageSet.SvgStrokeColor = IsCurrentDate ? IndicatorImageColorActive : IndicatorImageColor;
            imageSet.SvgFillColor = IsCurrentDate ? IndicatorImageColorActive : IndicatorImageColor;
            imageDate.SvgStrokeColor = IsCurrentDate ? IndicatorImageColorActive : IndicatorImageColor;
            imageDate.SvgFillColor = IsCurrentDate ? IndicatorImageColorActive : IndicatorImageColor;

        }
    }

    private Color backgroundColor = Colors.Black;

    /// <inheritdoc cref="Control.BackgroundColor"/>
    public new Color BackgroundColor
    {
        get
        {
            if (base.BackgroundColor != backgroundColor)
            {
                base.BackgroundColor = backgroundColor;
            }

            return backgroundColor;
        }

        set
        {
            if (value != backgroundColor)
            {
                backgroundColor = value;
                if (IsOutOfActiveMonth)
                {
                    base.BackgroundColor = BackgroundColorOutOfMonth;
                }
                else
                {
                    base.BackgroundColor = IsCurrentDate ? BackgroundColorCurrent : BackgroundColor;
                }
            }
        }
    }

    private Color foreColor = Colors.Black;

    /// <summary>
    /// Gets or sets the foreground color of the control.
    /// </summary>
    /// <value>The foreground color of the control.</value>
    public Color ForeColor
    {
        get => foreColor;

        set
        {
            if (value != foreColor)
            {
                foreColor = value;
                UpdateTextColors();
            }
        }
    }

    /// <summary>
    /// Gets or sets the N/A (Not Available) text.
    /// </summary>
    /// <value>The N/A text.</value>
    public static string NaText { get; set; } = "-";

    /// <summary>
    /// Gets or sets the rise text.
    /// </summary>
    /// <value>The rise text.</value>
    public static string RiseText { get; set; } = "Rise";

    /// <summary>
    /// Gets or sets the set text.
    /// </summary>
    /// <value>The set text.</value>
    public static string SetText { get; set; } = "Set";

    /// <summary>
    /// Gets or sets the date text.
    /// </summary>
    /// <value>The date text.</value>
    public static string DateText { get; set; } = "Date";

    /// <summary>
    /// Gets or sets the moon disc illumination percentage text.
    /// </summary>
    /// <value>The moon disc illumination percentage text.</value>
    public static string MoonDiscIlluminationPercentageText { get; set; } = "Illumination-%";

    /// <inheritdoc cref="ICalendarCell.Date"/>
    public DateOnly Date { get; set; }

    /// <inheritdoc cref="ICalendarCell.WeekNumber"/>
    public int WeekNumber { get; set; }

    /// <inheritdoc cref="ICalendarCell.CurrentMonth"/>
    public bool CurrentMonth { get; set; }

    private readonly Label lbDate = new();
    private readonly Label lbRise = new();
    private readonly Label lbSet = new();
    private readonly int monthNumber;
    private readonly SvgImageView imageDate;
    private readonly SvgImageView imageRise;
    private readonly SvgImageView imageSet;
}