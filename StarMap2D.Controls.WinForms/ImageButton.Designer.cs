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

namespace StarMap2D.Controls.WinForms
{
    partial class ImageButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnButtonImage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnButtonImage
            // 
            this.pnButtonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnButtonImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnButtonImage.Location = new System.Drawing.Point(0, 0);
            this.pnButtonImage.Margin = new System.Windows.Forms.Padding(0);
            this.pnButtonImage.Name = "pnButtonImage";
            this.pnButtonImage.Size = new System.Drawing.Size(363, 144);
            this.pnButtonImage.TabIndex = 0;
            this.pnButtonImage.SizeChanged += new System.EventHandler(this.image_Resize);
            this.pnButtonImage.Click += new System.EventHandler(this.pnButtonImage_Click);
            this.pnButtonImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnButtonImage_Paint);
            this.pnButtonImage.Resize += new System.EventHandler(this.image_Resize);
            // 
            // ImageButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnButtonImage);
            this.Name = "ImageButton";
            this.Size = new System.Drawing.Size(363, 144);
            this.SizeChanged += new System.EventHandler(this.image_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnButtonImage;
    }
}
