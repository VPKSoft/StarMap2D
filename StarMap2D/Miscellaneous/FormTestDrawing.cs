using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMap2D.Miscellaneous
{
    public partial class FormTestDrawing : Form
    {
        public FormTestDrawing()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            e.Graphics.FillEllipse(Brushes.White, new Rectangle(Point.Empty, new Size(16, 16)));
            var size = e.Graphics.MeasureString("☿", panel1.Font);
            e.Graphics.DrawString("☿", panel1.Font, Brushes.Black, (16 - size.Width) / 2, (16 - size.Height) / 2);
        }
    }
}
