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

using System.Drawing.Drawing2D;


namespace StarMap2D.Drawing
{
    public static class DrawStarImage
    {
        public static void CreateStarSimple(this Graphics graphics, Point location, double radius, double magnitude,
            double starMaxSize, double minimumMagnitude)
        {
            if (magnitude > minimumMagnitude)
            {
                return;
            }

            var size = (int)(-magnitude * 1.2);

            size = size < 2 ? 2 : size;

            var startPoint = new Point(location.X - size / 2, location.Y - size / 2);

            using var solidBrush = new SolidBrush(Color.White);

            graphics.FillEllipse(solidBrush, new Rectangle(startPoint, new Size(size, size)));
        }

        public static void CreateStar(this Graphics graphics, Point location, double radius, double magnitude, double starMaxSize)
        {
            if (-magnitude > 10)
            {
                return;
            }




            var size = (int)-magnitude * 3;
            size = size < 2 ? 2 : size;

            if (size == 2)
            {
                graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(location, new Size(2, 2)));
                return;
            }

            var startPoint = new Point(location.X - size / 2, location.Y - size / 2);

            using var path = new GraphicsPath();

            path.AddEllipse(new Rectangle(new Point(startPoint.X, startPoint.Y), new Size(size, size)));

            using var brush = new PathGradientBrush(path);

            
            brush.CenterPoint = new PointF(location.X, location.Y);

            brush.CenterColor = Color.White;

            brush.SurroundColors = new []{ Color.Bisque };

            graphics.FillPath(brush, path);
        }
    }
}
