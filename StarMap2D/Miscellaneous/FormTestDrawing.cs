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
using System.Drawing.Text;

namespace StarMap2D.Miscellaneous;

public partial class FormTestDrawing : Form
{
    public FormTestDrawing()
    {
        InitializeComponent();
        //pictureBox1.Image = ColorizeSvgTest();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

        var wh = trackBar2.Value;

        e.Graphics.FillEllipse(Brushes.White, new Rectangle(Point.Empty, new Size(wh, wh)));
        var size = e.Graphics.MeasureString("☿", panel1.Font);
        e.Graphics.DrawString("☿", panel1.Font, Brushes.Black, (wh - size.Width) / 2, (wh - size.Height) / 2);
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
        panel1.Font = new Font(panel1.Font.FontFamily, trackBar1.Value, FontStyle.Bold);
    }

    private void trackBar2_Scroll(object sender, EventArgs e)
    {
        panel1.Invalidate();
    }

    private void panel1_Click(object sender, EventArgs e)
    {
        if (fontDialog1.ShowDialog() == DialogResult.OK)
        {
            panel1.Font = fontDialog1.Font;
        }
    }

    //private Image ColorizeSvgTest()
    //{
    //    var svg = SvgColorize.FromBytes(Properties.Resources.minor_planet_quoar);
    //    foreach (var svgElement in svg.Descendants())
    //    {
    //        if (svgElement is SvgCircle circle)
    //        {
    //            circle.Fill = new SvgColourServer(Color.Aqua);
    //            circle.Stroke = SvgPaintServer.None;
    //        }

    //        if (svgElement is SvgPath path)
    //        {
    //            path.Fill = new SvgColourServer(Color.Yellow);
    //        }
    //    }

    //    return svg.Draw(100, 100);
    //}
}