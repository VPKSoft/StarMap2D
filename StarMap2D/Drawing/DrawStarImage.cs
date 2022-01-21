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

namespace StarMap2D.Drawing;

public static class DrawStarImage
{
    public class MapDrawParameters
    {
        public MapDrawParameters(double magnitudeMinimum, double magnitudeMaximum, Color drawColor,
            int drawDiameter)
        {
            MagnitudeMinimum = magnitudeMinimum;
            MagnitudeMaximum = magnitudeMaximum;
            DrawDiameter = drawDiameter;
            DrawColor = drawColor;
        }

        public double MagnitudeMinimum { get; set; }

        public double MagnitudeMaximum { get; set; }

        public Color DrawColor { get; set; }

        public int DrawDiameter { get; set; }

        public static IReadOnlyList<MapDrawParameters> DrawParameters = new MapDrawParameters[]
        {
            new( -6, -7, Color.Yellow, 8),
            new( -5, -6, Color.White, 7),
            new( -4, -5, Color.White, 6),
            new( -3, -4, Color.White, 5),
            new( -2, -3, Color.White, 5),
            new( -1, -2, Color.White, 5),
            new( 0, -1, Color.White, 4),
            new( 1, 0, Color.LightGray, 4),
            new( 2, 1, Color.DarkGray, 4),
            new( 10, 3, Color.DarkGray, 3),
        };
    }

    public static void DrawStar(this Graphics graphics, Point location, int starSize, Color starColor)
    {
        var startPoint = new Point(location.X - starSize / 2, location.Y - starSize / 2);
        using var solidBrush = new SolidBrush(starColor);
        graphics.FillEllipse(solidBrush, new Rectangle(startPoint, new Size(starSize, starSize)));
    }

    public static void CreateStar(this Graphics graphics, Size compareSize, Point location, double magnitude)
    {

        if (!MapDrawParameters.DrawParameters.Any(f => f.MagnitudeMaximum < magnitude && f.MagnitudeMinimum >= magnitude))
        {
            return;
        }

        var multiplier = Math.Min(compareSize.Width, compareSize.Height) / 800.0;

        var parameter = MapDrawParameters.DrawParameters.First(f =>
            f.MagnitudeMaximum < magnitude && f.MagnitudeMinimum >= magnitude);

        var size = parameter.DrawDiameter;

        if (size * multiplier > size)
        {
            size = (int)(size * multiplier);
        }

        var startPoint = new Point(location.X - size / 2, location.Y - size / 2);

        using var solidBrush = new SolidBrush(parameter.DrawColor);

        graphics.FillEllipse(solidBrush, new Rectangle(startPoint, new Size(size, size)));
    }
}