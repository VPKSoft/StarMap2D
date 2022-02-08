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

namespace StarMap2D.Controls.WinForms.Drawing;

/// <summary>
/// A helper class to draw star circles to <see cref="Graphics"/>.
/// </summary>
public static class DrawStarImage
{
    /// <summary>
    /// Draws the star to with the specified arguments on the <see cref="Graphics"/> instance.
    /// </summary>
    /// <param name="graphics">The graphics instance to draw onto.</param>
    /// <param name="location">The location for the star circle.</param>
    /// <param name="starSize">Size of the star circle.</param>
    /// <param name="starColor">Color of the star circle.</param>
    public static void DrawStar(this Graphics graphics, Point location, int starSize, Color starColor)
    {
        var startPoint = new Point(location.X - starSize / 2, location.Y - starSize / 2);
        using var solidBrush = new SolidBrush(starColor);
        graphics.FillEllipse(solidBrush, new Rectangle(startPoint, new Size(starSize, starSize)));
    }
}