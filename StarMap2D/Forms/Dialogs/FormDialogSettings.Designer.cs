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

namespace StarMap2D.Forms.Dialogs
{
    partial class FormDialogSettings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialogSettings));
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpLocation = new System.Windows.Forms.TabPage();
            this.lbSelectLocation = new System.Windows.Forms.Label();
            this.cmbSelectLocation = new System.Windows.Forms.ComboBox();
            this.nudLongitude = new System.Windows.Forms.NumericUpDown();
            this.lbLongitude = new System.Windows.Forms.Label();
            this.nudLatitude = new System.Windows.Forms.NumericUpDown();
            this.lbLatitude = new System.Windows.Forms.Label();
            this.tbLocationName = new System.Windows.Forms.TextBox();
            this.lbLocationName = new System.Windows.Forms.Label();
            this.tabColorSettings = new System.Windows.Forms.TabPage();
            this.pnConstellationBorderLineColor = new System.Windows.Forms.Panel();
            this.lbConstellationBorderLineColor = new System.Windows.Forms.Label();
            this.ceColor = new Cyotek.Windows.Forms.ColorEditor();
            this.cwColor = new Cyotek.Windows.Forms.ColorWheel();
            this.pnConstellationLineColor = new System.Windows.Forms.Panel();
            this.lbConstellationLineColor = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnMapCircleColor = new System.Windows.Forms.Panel();
            this.lbMapCircleColor = new System.Windows.Forms.Label();
            this.tcSettings.SuspendLayout();
            this.tpLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).BeginInit();
            this.tabColorSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSettings
            // 
            this.tcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcSettings.Controls.Add(this.tpLocation);
            this.tcSettings.Controls.Add(this.tabColorSettings);
            this.tcSettings.Location = new System.Drawing.Point(12, 12);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(696, 493);
            this.tcSettings.TabIndex = 1;
            // 
            // tpLocation
            // 
            this.tpLocation.Controls.Add(this.lbSelectLocation);
            this.tpLocation.Controls.Add(this.cmbSelectLocation);
            this.tpLocation.Controls.Add(this.nudLongitude);
            this.tpLocation.Controls.Add(this.lbLongitude);
            this.tpLocation.Controls.Add(this.nudLatitude);
            this.tpLocation.Controls.Add(this.lbLatitude);
            this.tpLocation.Controls.Add(this.tbLocationName);
            this.tpLocation.Controls.Add(this.lbLocationName);
            this.tpLocation.Location = new System.Drawing.Point(4, 24);
            this.tpLocation.Name = "tpLocation";
            this.tpLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocation.Size = new System.Drawing.Size(688, 465);
            this.tpLocation.TabIndex = 0;
            this.tpLocation.Text = "Location";
            this.tpLocation.UseVisualStyleBackColor = true;
            // 
            // lbSelectLocation
            // 
            this.lbSelectLocation.AutoSize = true;
            this.lbSelectLocation.Location = new System.Drawing.Point(6, 91);
            this.lbSelectLocation.Name = "lbSelectLocation";
            this.lbSelectLocation.Size = new System.Drawing.Size(84, 15);
            this.lbSelectLocation.TabIndex = 9;
            this.lbSelectLocation.Text = "Select location";
            // 
            // cmbSelectLocation
            // 
            this.cmbSelectLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSelectLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSelectLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSelectLocation.FormattingEnabled = true;
            this.cmbSelectLocation.Location = new System.Drawing.Point(6, 109);
            this.cmbSelectLocation.Name = "cmbSelectLocation";
            this.cmbSelectLocation.Size = new System.Drawing.Size(470, 23);
            this.cmbSelectLocation.TabIndex = 8;
            this.cmbSelectLocation.SelectedIndexChanged += new System.EventHandler(this.cmbSelectLocation_SelectedIndexChanged);
            // 
            // nudLongitude
            // 
            this.nudLongitude.DecimalPlaces = 15;
            this.nudLongitude.Location = new System.Drawing.Point(180, 65);
            this.nudLongitude.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudLongitude.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudLongitude.Name = "nudLongitude";
            this.nudLongitude.Size = new System.Drawing.Size(168, 23);
            this.nudLongitude.TabIndex = 5;
            // 
            // lbLongitude
            // 
            this.lbLongitude.AutoSize = true;
            this.lbLongitude.Location = new System.Drawing.Point(180, 47);
            this.lbLongitude.Name = "lbLongitude";
            this.lbLongitude.Size = new System.Drawing.Size(61, 15);
            this.lbLongitude.TabIndex = 4;
            this.lbLongitude.Text = "Longitude";
            // 
            // nudLatitude
            // 
            this.nudLatitude.DecimalPlaces = 15;
            this.nudLatitude.Location = new System.Drawing.Point(6, 65);
            this.nudLatitude.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudLatitude.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.nudLatitude.Name = "nudLatitude";
            this.nudLatitude.Size = new System.Drawing.Size(168, 23);
            this.nudLatitude.TabIndex = 3;
            // 
            // lbLatitude
            // 
            this.lbLatitude.AutoSize = true;
            this.lbLatitude.Location = new System.Drawing.Point(6, 47);
            this.lbLatitude.Name = "lbLatitude";
            this.lbLatitude.Size = new System.Drawing.Size(50, 15);
            this.lbLatitude.TabIndex = 2;
            this.lbLatitude.Text = "Latitude";
            // 
            // tbLocationName
            // 
            this.tbLocationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLocationName.Location = new System.Drawing.Point(6, 21);
            this.tbLocationName.Name = "tbLocationName";
            this.tbLocationName.Size = new System.Drawing.Size(470, 23);
            this.tbLocationName.TabIndex = 1;
            // 
            // lbLocationName
            // 
            this.lbLocationName.AutoSize = true;
            this.lbLocationName.Location = new System.Drawing.Point(6, 3);
            this.lbLocationName.Name = "lbLocationName";
            this.lbLocationName.Size = new System.Drawing.Size(86, 15);
            this.lbLocationName.TabIndex = 0;
            this.lbLocationName.Text = "Location name";
            // 
            // tabColorSettings
            // 
            this.tabColorSettings.Controls.Add(this.pnMapCircleColor);
            this.tabColorSettings.Controls.Add(this.lbMapCircleColor);
            this.tabColorSettings.Controls.Add(this.pnConstellationBorderLineColor);
            this.tabColorSettings.Controls.Add(this.lbConstellationBorderLineColor);
            this.tabColorSettings.Controls.Add(this.ceColor);
            this.tabColorSettings.Controls.Add(this.cwColor);
            this.tabColorSettings.Controls.Add(this.pnConstellationLineColor);
            this.tabColorSettings.Controls.Add(this.lbConstellationLineColor);
            this.tabColorSettings.Location = new System.Drawing.Point(4, 24);
            this.tabColorSettings.Name = "tabColorSettings";
            this.tabColorSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabColorSettings.Size = new System.Drawing.Size(688, 465);
            this.tabColorSettings.TabIndex = 1;
            this.tabColorSettings.Text = "Map color settings";
            this.tabColorSettings.UseVisualStyleBackColor = true;
            // 
            // pnConstellationBorderLineColor
            // 
            this.pnConstellationBorderLineColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(125)))));
            this.pnConstellationBorderLineColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnConstellationBorderLineColor.Location = new System.Drawing.Point(223, 32);
            this.pnConstellationBorderLineColor.Margin = new System.Windows.Forms.Padding(0);
            this.pnConstellationBorderLineColor.Name = "pnConstellationBorderLineColor";
            this.pnConstellationBorderLineColor.Size = new System.Drawing.Size(113, 23);
            this.pnConstellationBorderLineColor.TabIndex = 5;
            this.pnConstellationBorderLineColor.Tag = "ConstellationBorderLineColor";
            this.pnConstellationBorderLineColor.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // lbConstellationBorderLineColor
            // 
            this.lbConstellationBorderLineColor.AutoSize = true;
            this.lbConstellationBorderLineColor.Location = new System.Drawing.Point(6, 36);
            this.lbConstellationBorderLineColor.Name = "lbConstellationBorderLineColor";
            this.lbConstellationBorderLineColor.Size = new System.Drawing.Size(170, 15);
            this.lbConstellationBorderLineColor.TabIndex = 4;
            this.lbConstellationBorderLineColor.Text = "Constellation border line color:";
            // 
            // ceColor
            // 
            this.ceColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ceColor.Location = new System.Drawing.Point(482, 6);
            this.ceColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ceColor.Name = "ceColor";
            this.ceColor.Size = new System.Drawing.Size(202, 284);
            this.ceColor.TabIndex = 3;
            this.ceColor.ColorChanged += new System.EventHandler(this.ceColor_ColorChanged);
            // 
            // cwColor
            // 
            this.cwColor.Alpha = 1D;
            this.cwColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cwColor.Location = new System.Drawing.Point(482, 296);
            this.cwColor.Name = "cwColor";
            this.cwColor.Size = new System.Drawing.Size(200, 163);
            this.cwColor.TabIndex = 2;
            this.cwColor.ColorChanged += new System.EventHandler(this.cwColor_ColorChanged);
            // 
            // pnConstellationLineColor
            // 
            this.pnConstellationLineColor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnConstellationLineColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnConstellationLineColor.Location = new System.Drawing.Point(223, 6);
            this.pnConstellationLineColor.Margin = new System.Windows.Forms.Padding(0);
            this.pnConstellationLineColor.Name = "pnConstellationLineColor";
            this.pnConstellationLineColor.Size = new System.Drawing.Size(113, 23);
            this.pnConstellationLineColor.TabIndex = 1;
            this.pnConstellationLineColor.Tag = "ConstellationLineColor";
            this.pnConstellationLineColor.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // lbConstellationLineColor
            // 
            this.lbConstellationLineColor.AutoSize = true;
            this.lbConstellationLineColor.Location = new System.Drawing.Point(6, 10);
            this.lbConstellationLineColor.Name = "lbConstellationLineColor";
            this.lbConstellationLineColor.Size = new System.Drawing.Size(132, 15);
            this.lbConstellationLineColor.TabIndex = 0;
            this.lbConstellationLineColor.Text = "Constellation line color:";
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(12, 511);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(633, 511);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // pnMapCircleColor
            // 
            this.pnMapCircleColor.BackColor = System.Drawing.Color.Black;
            this.pnMapCircleColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMapCircleColor.Location = new System.Drawing.Point(223, 58);
            this.pnMapCircleColor.Margin = new System.Windows.Forms.Padding(0);
            this.pnMapCircleColor.Name = "pnMapCircleColor";
            this.pnMapCircleColor.Size = new System.Drawing.Size(113, 23);
            this.pnMapCircleColor.TabIndex = 7;
            this.pnMapCircleColor.Tag = "MapCircleColor";
            this.pnMapCircleColor.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // lbMapCircleColor
            // 
            this.lbMapCircleColor.AutoSize = true;
            this.lbMapCircleColor.Location = new System.Drawing.Point(6, 62);
            this.lbMapCircleColor.Name = "lbMapCircleColor";
            this.lbMapCircleColor.Size = new System.Drawing.Size(95, 15);
            this.lbMapCircleColor.TabIndex = 6;
            this.lbMapCircleColor.Text = "Map circle color:";
            // 
            // FormDialogSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 546);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tcSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialogSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StarMap2D - Settings";
            this.tcSettings.ResumeLayout(false);
            this.tpLocation.ResumeLayout(false);
            this.tpLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).EndInit();
            this.tabColorSettings.ResumeLayout(false);
            this.tabColorSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcSettings;
        private TabPage tpLocation;
        private NumericUpDown nudLatitude;
        private Label lbLatitude;
        private TextBox tbLocationName;
        private Label lbLocationName;
        private TabPage tabColorSettings;
        private NumericUpDown nudLongitude;
        private Label lbLongitude;
        private Button btOk;
        private Button btCancel;
        private Label lbSelectLocation;
        private ComboBox cmbSelectLocation;
        private Panel pnConstellationLineColor;
        private Label lbConstellationLineColor;
        private ColorDialog colorDialog1;
        private Cyotek.Windows.Forms.ColorEditor ceColor;
        private Cyotek.Windows.Forms.ColorWheel cwColor;
        private Panel pnConstellationBorderLineColor;
        private Label lbConstellationBorderLineColor;
        private Panel pnMapCircleColor;
        private Label lbMapCircleColor;
    }
}