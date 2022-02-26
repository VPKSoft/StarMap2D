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
using System.Collections.Generic;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Calculations.Enumerations;
using StarMap2D.EtoForms.Controls.Utilities;
using StarMap2D.Localization;

namespace StarMap2D.EtoForms.Controls;

/// <summary>
/// A <see cref="Control"/> displaying a compass.
/// Implements the <see cref="Eto.Forms.Drawable" />
/// </summary>
/// <seealso cref="Eto.Forms.Drawable" />
public class CompassView : Drawable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CompassView"/> class.
    /// </summary>
    public CompassView()
    {
        Paint += CompassView_Paint;
    }

    private bool invertEastWestAxis;

    /// <summary>
    /// Gets or sets a value indicating whether invert east-west axis of the compass.
    /// </summary>
    /// <value><c>true</c> if to invert east-west axis of the compass; otherwise, <c>false</c>.</value>
    public bool InvertEastWestAxis
    {
        get => invertEastWestAxis;

        set
        {
            if (invertEastWestAxis != value)
            {
                invertEastWestAxis = value;
                Invalidate();
            }
        }
    }

    private Font font = new("Cabin", 9);

    /// <summary>
    /// Gets or sets the font to draw labels to the compass.
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

    private float textAreaSize = 35;

    /// <summary>
    /// Gets or sets the size of the area reserved for the point text values.
    /// </summary>
    /// <value>The size of the text area.</value>
    public float TextAreaSize
    {
        get => textAreaSize;

        set
        {
            if (Math.Abs(textAreaSize - value) > 0.00001)
            {
                textAreaSize = value;
                Invalidate();
            }
        }
    }

    private void CompassView_Paint(object? sender, PaintEventArgs e)
    {
        var wh = Math.Min(e.ClipRectangle.Width, e.ClipRectangle.Height);
        var whCompass = (int)(wh - TextAreaSize);

        wh -= textAreaSize / 2f;

        var size = new Size(whCompass, whCompass);
        var image = SvgToImage.ImageFromSvg(EtoForms.Controls.Properties.Resources.compass, size);

        var x = (e.ClipRectangle.Width - whCompass) / 2;
        var y = (e.ClipRectangle.Height - whCompass) / 2;

        using var brush = new SolidBrush(Colors.Black);

        e.Graphics.DrawImage(image, x, y);

        foreach (var compassDirectionValue in InvertEastWestAxis ? compassDirectionValues : compassDirectionValuesInverted)
        {
            var compassPoint = CircleCalculations.GetCirclePoint(wh / 2f, compassDirectionValue.Key - 90,
                e.ClipRectangle.MiddleX, e.ClipRectangle.MiddleY);

            var textSize = e.Graphics.MeasureString(Font, compassDirectionValue.Value);

            e.Graphics.DrawText(Font, brush, (float)compassPoint.x - textSize.Width / 2,
                (float)compassPoint.y - textSize.Height / 2, compassDirectionValue.Value);
        }
    }

    private readonly List<KeyValuePair<double, string>> compassDirectionValuesInverted = new(new[]
        {
            new KeyValuePair<double, string>(0, Units.CompassNorthShort),
            new KeyValuePair<double, string>(45, Units.CompassNorthWestShort),
            new KeyValuePair<double, string>(90, Units.CompassWestShort),
            new KeyValuePair<double, string>(135, Units.CompassSouthWestShort),
            new KeyValuePair<double, string>(180, Units.CompassSouthShort),
            new KeyValuePair<double, string>(225, Units.CompassSouthEastShort),
            new KeyValuePair<double, string>(270, Units.CompassEastShort),
            new KeyValuePair<double, string>(315, Units.CompassNorthEastShort),
        }
    );

    private readonly List<KeyValuePair<double, string>> compassDirectionValues = new(new[]
        {
            new KeyValuePair<double, string>(0, Units.CompassNorthShort),
            new KeyValuePair<double, string>(45, Units.CompassNorthEastShort),
            new KeyValuePair<double, string>(90, Units.CompassEastShort),
            new KeyValuePair<double, string>(135, Units.CompassSouthEastShort),
            new KeyValuePair<double, string>(180, Units.CompassSouthShort),
            new KeyValuePair<double, string>(225, Units.CompassSouthWestShort),
            new KeyValuePair<double, string>(270, Units.CompassWestShort),
            new KeyValuePair<double, string>(315, Units.CompassNorthWestShort),
        }
    );
}