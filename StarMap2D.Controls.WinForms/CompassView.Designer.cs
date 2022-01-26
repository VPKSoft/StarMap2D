namespace StarMap2D.Controls.WinForms
{
    partial class CompassView
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
            this.imageButton1 = new StarMap2D.Controls.WinForms.ImageButton();
            this.lbNorthEast = new System.Windows.Forms.Label();
            this.lbNorth = new System.Windows.Forms.Label();
            this.lbSouth = new System.Windows.Forms.Label();
            this.lbWest = new System.Windows.Forms.Label();
            this.lbEast = new System.Windows.Forms.Label();
            this.lbSouthWest = new System.Windows.Forms.Label();
            this.lbSouthEast = new System.Windows.Forms.Label();
            this.lbNorthWest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageButton1
            // 
            this.imageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton1.Checked = false;
            this.imageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton1.DisabledColor = System.Drawing.Color.LightGray;
            this.imageButton1.ImageCheckedSvg = null;
            this.imageButton1.ImageColor = System.Drawing.Color.Black;
            this.imageButton1.ImageColorChecked = System.Drawing.Color.SteelBlue;
            this.imageButton1.ImageSvg = "compass";
            this.imageButton1.IsCheckedButton = false;
            this.imageButton1.Location = new System.Drawing.Point(20, 20);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(200, 200);
            this.imageButton1.TabIndex = 9;
            // 
            // lbNorthEast
            // 
            this.lbNorthEast.Location = new System.Drawing.Point(3, 24);
            this.lbNorthEast.Name = "lbNorthEast";
            this.lbNorthEast.Size = new System.Drawing.Size(69, 24);
            this.lbNorthEast.TabIndex = 17;
            this.lbNorthEast.Text = "NE";
            this.lbNorthEast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNorth
            // 
            this.lbNorth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNorth.Location = new System.Drawing.Point(70, 0);
            this.lbNorth.Name = "lbNorth";
            this.lbNorth.Size = new System.Drawing.Size(100, 24);
            this.lbNorth.TabIndex = 10;
            this.lbNorth.Text = "N";
            this.lbNorth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSouth
            // 
            this.lbSouth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbSouth.Location = new System.Drawing.Point(70, 216);
            this.lbSouth.Name = "lbSouth";
            this.lbSouth.Size = new System.Drawing.Size(100, 24);
            this.lbSouth.TabIndex = 11;
            this.lbSouth.Text = "S";
            this.lbSouth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWest
            // 
            this.lbWest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWest.Location = new System.Drawing.Point(216, 70);
            this.lbWest.Name = "lbWest";
            this.lbWest.Size = new System.Drawing.Size(24, 100);
            this.lbWest.TabIndex = 12;
            this.lbWest.Text = "W";
            this.lbWest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEast
            // 
            this.lbEast.Location = new System.Drawing.Point(0, 70);
            this.lbEast.Name = "lbEast";
            this.lbEast.Size = new System.Drawing.Size(24, 100);
            this.lbEast.TabIndex = 13;
            this.lbEast.Text = "E";
            this.lbEast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSouthWest
            // 
            this.lbSouthWest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSouthWest.Location = new System.Drawing.Point(168, 192);
            this.lbSouthWest.Name = "lbSouthWest";
            this.lbSouthWest.Size = new System.Drawing.Size(69, 24);
            this.lbSouthWest.TabIndex = 14;
            this.lbSouthWest.Text = "SW";
            this.lbSouthWest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSouthEast
            // 
            this.lbSouthEast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSouthEast.Location = new System.Drawing.Point(3, 192);
            this.lbSouthEast.Name = "lbSouthEast";
            this.lbSouthEast.Size = new System.Drawing.Size(69, 24);
            this.lbSouthEast.TabIndex = 15;
            this.lbSouthEast.Text = "SE";
            this.lbSouthEast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNorthWest
            // 
            this.lbNorthWest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNorthWest.Location = new System.Drawing.Point(168, 24);
            this.lbNorthWest.Name = "lbNorthWest";
            this.lbNorthWest.Size = new System.Drawing.Size(69, 24);
            this.lbNorthWest.TabIndex = 16;
            this.lbNorthWest.Text = "NW";
            this.lbNorthWest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompassView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbNorthEast);
            this.Controls.Add(this.lbNorth);
            this.Controls.Add(this.lbSouth);
            this.Controls.Add(this.lbWest);
            this.Controls.Add(this.lbEast);
            this.Controls.Add(this.lbSouthWest);
            this.Controls.Add(this.lbSouthEast);
            this.Controls.Add(this.lbNorthWest);
            this.Controls.Add(this.imageButton1);
            this.Name = "CompassView";
            this.Size = new System.Drawing.Size(240, 240);
            this.Resize += new System.EventHandler(this.CompassView_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private ImageButton imageButton1;
        private Label lbNorthEast;
        private Label lbNorth;
        private Label lbSouth;
        private Label lbWest;
        private Label lbEast;
        private Label lbSouthWest;
        private Label lbSouthEast;
        private Label lbNorthWest;
    }
}
