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

using Eto.Drawing;
using Eto.Forms;
using System;

namespace StarMap2D.EtoForms.Controls;

/// <summary>
/// A control to visualize the twilight, daylight and night color sections of a day.
/// Implements the <see cref="Eto.Forms.Drawable" />
/// </summary>
/// <seealso cref="Eto.Forms.Drawable" />
public class TwilightVisualization : Drawable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TwilightVisualization"/> class.
    /// </summary>
    public TwilightVisualization()
    {
        Paint += TwilightVisualization_Paint;
    }

    private void TwilightVisualization_Paint(object? sender, PaintEventArgs e)
    {
        DrawTwilightData(e.Graphics, e.ClipRectangle);
    }

    /// <summary>
    /// Draws the twilight data onto the specified graphics.
    /// </summary>
    /// <param name="graphics">The graphics to draw on to.</param>
    /// <param name="drawArea">The drawing area rectangle.</param>
    private void DrawTwilightData(Graphics graphics, RectangleF drawArea)
    {
        bool ValidValue((double hourStart, double hourEnd) value)
        {
            return value.hourStart < value.hourEnd && value.hourStart <= 24 && value.hourEnd <= 24;
        }

        RectangleF GetValueRect((double hourStart, double hourEnd) value)
        {
            var width = drawArea.Width / 24f;
            var x1 = drawArea.Left + ((float)value.hourStart * width);
            var x2 = drawArea.Left + ((float)value.hourEnd * width);

            return new RectangleF(new PointF(x1, drawArea.Top), new PointF(x2, drawArea.Bottom));
        }

        graphics.FillRectangle(backgroundColor, drawArea);

        // Draw the night sections.
        foreach (var value in nightSections)
        {
            if (ValidValue(value))
            {
                graphics.FillRectangle(nightColor, GetValueRect(value));
            }
        }

        // Draw the nautical twilight sections.
        foreach (var value in astronomicalTwilightSections)
        {
            if (ValidValue(value))
            {
                graphics.FillRectangle(astronomicalTwilightColor, GetValueRect(value));
            }
        }

        // Draw the nautical astronomical twilight sections.
        foreach (var value in nauticalTwilightSections)
        {
            if (ValidValue(value))
            {
                graphics.FillRectangle(nauticalTwilightColor, GetValueRect(value));
            }
        }

        // Draw the nautical civil twilight sections.
        foreach (var value in civilTwilightSections)
        {
            if (ValidValue(value))
            {
                graphics.FillRectangle(civilTwilightColor, GetValueRect(value));
            }
        }

        // Draw the daylight sections. Note: There should be only one :-)
        foreach (var value in daylightSections)
        {
            if (ValidValue(value))
            {
                graphics.FillRectangle(daylightColor, GetValueRect(value));
            }
        }
    }

    private Color nightColor = Colors.Black;
    private Color astronomicalTwilightColor = Color.FromArgb(0x26, 0x3E, 0x66);
    private Color nauticalTwilightColor = Color.FromArgb(0x47, 0x73, 0xBB);
    private Color civilTwilightColor = Color.FromArgb(0x87, 0xA4, 0xD3);
    private Color daylightColor = Color.FromArgb(0xDB, 0xE9, 0xFF);
    private Color backgroundColor = Colors.Black;
    private (double hourStart, double hourEnd)[] nightSections = { (0, 1), (23, 24), };
    private (double hourStart, double hourEnd)[] astronomicalTwilightSections = { (1, 3), (21, 23), };
    private (double hourStart, double hourEnd)[] nauticalTwilightSections = { (3, 5), (19, 21), };
    private (double hourStart, double hourEnd)[] civilTwilightSections = { (5, 7), (17, 19) };
    private (double hourStart, double hourEnd)[] daylightSections = { (7, 17), };

    #region ColorProperties    
    /// <summary>
    /// Gets or sets the color for the background of the control
    /// </summary>
    /// <value>The color of the background.</value>
    /// <remarks>Note that on some platforms (e.g. Mac), setting the background color of a control can change the performance
    /// characteristics of the control and its children, since it must enable layers to do so.</remarks>
    public new Color BackgroundColor
    {
        get => backgroundColor;

        set
        {
            if (value != backgroundColor)
            {
                backgroundColor = value;
                Invalidate();
            }
        }
    }

    /// <summary>
    /// Gets or sets the color of the night.
    /// </summary>
    /// <value>The color of the night.</value>
    public Color NightColor
    {
        get => nightColor;

        set
        {
            if (value != nightColor)
            {
                nightColor = value;
                Invalidate();
            }
        }
    }

    /// <summary>
    /// Gets or sets the color of the astronomical twilight.
    /// </summary>
    /// <value>The color of the astronomical twilight.</value>
    public Color AstronomicalTwilightColor
    {
        get => astronomicalTwilightColor;

        set
        {
            if (value != astronomicalTwilightColor)
            {
                astronomicalTwilightColor = value;
                Invalidate();
            }
        }
    }

    /// <summary>
    /// Gets or sets the color of the nautical twilight.
    /// </summary>
    /// <value>The color of the nautical twilight.</value>
    public Color NauticalTwilightColor
    {
        get => nauticalTwilightColor;

        set
        {
            if (value != nauticalTwilightColor)
            {
                nauticalTwilightColor = value;
                Invalidate();
            }
        }
    }

    /// <summary>
    /// Gets or sets the color of the civil twilight.
    /// </summary>
    /// <value>The color of the civil twilight.</value>
    public Color CivilTwilightColor
    {
        get => civilTwilightColor;

        set
        {
            if (value != civilTwilightColor)
            {
                civilTwilightColor = value;
                Invalidate();
            }
        }
    }

    /// <summary>
    /// Gets or sets the color of the daylight.
    /// </summary>
    /// <value>The color of the daylight.</value>
    public Color DaylightColor
    {
        get => daylightColor;

        set
        {
            if (value != daylightColor)
            {
                daylightColor = value;
                Invalidate();
            }
        }
    }
    #endregion

    #region TwilightSections
    private bool SectionTupleChanged((double hourStart, double hourEnd)[] valueNew,
        (double hourStart, double hourEnd)[] valuePrevious)
    {
        if (valueNew.Length != valuePrevious.Length)
        {
            return true;
        }

        for (int i = 0; i < valueNew.Length; i++)
        {
            if (Math.Abs(valueNew[i].hourStart - valuePrevious[i].hourStart) > Globals.FloatingPointTolerance ||
                Math.Abs(valueNew[i].hourEnd - valuePrevious[i].hourEnd) > Globals.FloatingPointTolerance)
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Gets or sets the night sections.
    /// </summary>
    /// <value>The night sections.</value>
    public (double hourStart, double hourEnd)[] NightSections
    {
        get => nightSections;

        set
        {
            if (SectionTupleChanged(value, nightSections))
            {
                nightSections = value;
                Invalidate();
            }
        }
    }


    /// <summary>
    /// Gets or sets the astronomical twilight sections.
    /// </summary>
    /// <value>The astronomical twilight sections.</value>
    public (double hourStart, double hourEnd)[] AstronomicalTwilightSections
    {
        get => astronomicalTwilightSections;

        set
        {
            if (SectionTupleChanged(value, astronomicalTwilightSections))
            {
                astronomicalTwilightSections = value;
                Invalidate();
            }
        }
    }

    /// <summary>
    /// Gets or sets the nautical twilight sections.
    /// </summary>
    /// <value>The nautical twilight sections.</value>
    public (double hourStart, double hourEnd)[] NauticalTwilightSections
    {
        get => nauticalTwilightSections;

        set
        {
            if (SectionTupleChanged(value, nauticalTwilightSections))
            {
                nauticalTwilightSections = value;
                Invalidate();
            }
        }
    }

    /// <summary>
    /// Gets or sets the civil twilight sections.
    /// </summary>
    /// <value>The civil twilight sections.</value>
    public (double hourStart, double hourEnd)[] CivilTwilightSections
    {
        get => civilTwilightSections;

        set
        {
            if (SectionTupleChanged(value, civilTwilightSections))
            {
                civilTwilightSections = value;
                Invalidate();
            }
        }
    }

    /// <summary>
    /// Gets or sets the daylight sections.
    /// </summary>
    /// <value>The daylight sections.</value>
    public (double hourStart, double hourEnd)[] DaylightSections
    {
        get => daylightSections;

        set
        {
            if (SectionTupleChanged(value, daylightSections))
            {
                daylightSections = value;
                Invalidate();
            }
        }
    }
    #endregion
}