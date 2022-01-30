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

using Avalonia;
using Avalonia.Media;
using Color = Avalonia.Media.Color;

namespace StarMap2D.Avalonia.Classes;

/// <summary>
/// A helper class for star drawing on a <see cref="DrawingContext"/>.
/// </summary>
public static class DrawStarImage
{
    public static void DrawStar(this DrawingContext context, Point location, int starSize, Color starColor)
    {
        var startPoint = new Point(location.X - starSize / 2.0, location.Y - starSize / 2.0);

        context.DrawGeometry(new SolidColorBrush(starColor), new Pen(), new EllipseGeometry(
            new Rect(startPoint.X, startPoint.Y, starSize, starSize)));
    }
}