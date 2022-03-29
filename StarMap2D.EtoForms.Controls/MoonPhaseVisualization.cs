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
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Common.SvgColorization;
using StarMap2D.EtoForms.Controls.Utilities;

namespace StarMap2D.EtoForms.Controls;

/// <summary>
/// A control to display moon phase.
/// Implements the <see cref="Eto.Forms.Drawable" />
/// </summary>
/// <seealso cref="Eto.Forms.Drawable" />
public class MoonPhaseVisualization : Drawable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MoonPhaseVisualization"/> class.
    /// </summary>
    public MoonPhaseVisualization()
    {
        Paint += MoonPhaseVisualization_Paint;
        SizeChanged += MoonPhaseVisualization_SizeChanged;
    }

    private void MoonPhaseVisualization_SizeChanged(object? sender, EventArgs e)
    {
        Invalidate();
    }

    private double moonPhase;
    private double moonPhaseAltered;


    /// <summary>
    /// Gets or sets the moon phase from <c>0</c> to <c>1</c> where <c>0</c> is new moon to <c>0.5</c> = full moon to waning crescent = <c>1</c>.
    /// </summary>
    /// <value>The moon phase.</value>
    public double MoonPhase
    {
        get => moonPhase;

        set
        {
            if (Math.Abs(moonPhase - value) > Globals.FloatingPointSingleTolerance)
            {
                moonPhaseAltered = value + 0.5;
                if (moonPhaseAltered > 1)
                {
                    moonPhaseAltered = moonPhaseAltered - 1;
                }

                moonPhase = value;
                Invalidate();
            }
        }
    }

    private double moonDiscTiltAngle;

    /// <summary>
    /// Gets the moon disc tilt angle relative to the horizontal line of a circle increasing counter-clockwise.
    /// </summary>
    /// <value>The moon disc tilt angle.</value>
    public double MoonDiscTiltAngle
    {
        get => moonDiscTiltAngle;

        set
        {
            if (Math.Abs(moonDiscTiltAngle - value) > Globals.FloatingPointTolerance)
            {
                moonDiscTiltAngle = value;
                Invalidate();
            }
        }
    }

    private double MoonPhaseInternal
    {
        get
        {
            return moonPhase < 0.5 ? 0.5 - moonPhase : 1 - moonPhase;
        }
    }

    private void MoonPhaseVisualization_Paint(object? sender, PaintEventArgs e)
    {
        var wh = Math.Min(e.ClipRectangle.Width, e.ClipRectangle.Height);

        var size = new Size((int)wh, (int)wh);

        var svgBytes = SvgColorize.FromBytes(StarMap2D.EtoForms.Controls.Properties.Resources.full_moon)
            .ToBytes();

        e.Graphics.FillRectangle(Colors.Black, e.ClipRectangle);

        var image = SvgToImage.ImageFromSvg(svgBytes, size,
            moonDiscTiltAngle > 0 ? (float?)moonDiscTiltAngle : null);

        var x = (e.ClipRectangle.Width - wh) / 2;
        var y = (e.ClipRectangle.Height - wh) / 2;

        e.Graphics.DrawImage(image, x, y);

        var color = Color.FromArgb(0, 0, 0, 230);

        using var path1 = new GraphicsPath();

        var waxing = MoonPhase < 0.5;

        var phaseSize = (float)MoonPhaseInternal * wh;

        var crescent = phaseSize * 2;

        if (waxing)
        {
            crescent = phaseSize * 2;
            path1.AddArc(x - 1, y - 1, wh, wh + 2, 90, 180);
            path1.AddArc(x + wh / 2f - crescent / 2f - 1, y - 1, crescent, wh + 2, 90, 180);
        }
        else
        {
            phaseSize = (float)MoonPhaseInternal * e.ClipRectangle.Width;

            crescent = e.ClipRectangle.Width / 2f - phaseSize;

            var a = wh / 2f - (float)MoonPhaseInternal * wh;

            path1.AddArc(x - 1, y - 1, wh, wh + 2, 90, 180);
            path1.AddArc(x + wh / 2f - a / 2f - 1, y - 1, crescent, wh + 2, 270, 180);
        }

        using var matrix = Matrix.Create();
        path1.Transform(matrix);

        matrix.RotateAt((float)moonDiscTiltAngle, e.ClipRectangle.Width / 2, e.ClipRectangle.Height / 2);

        path1.Transform(matrix);

        e.Graphics.FillPath(color, path1);
    }
}