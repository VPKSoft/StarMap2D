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

namespace StarMap2D.Forms
{
    partial class FormSkyMap2D
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSkyMap2D));
            this.tmSetTime = new System.Windows.Forms.Timer(this.components);
            this.dtpMapDateTime = new System.Windows.Forms.DateTimePicker();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.map2d = new StarMap2D.Controls.WinForms.Map2D();
            this.tlpMapControls = new System.Windows.Forms.TableLayoutPanel();
            this.pnDateTime = new System.Windows.Forms.Panel();
            this.btGo = new StarMap2D.Controls.WinForms.ImageButton();
            this.btPlayPause = new StarMap2D.Controls.WinForms.ImageButton();
            this.tlpMain.SuspendLayout();
            this.tlpMapControls.SuspendLayout();
            this.pnDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmSetTime
            // 
            this.tmSetTime.Tick += new System.EventHandler(this.tmSetTime_Tick);
            // 
            // dtpMapDateTime
            // 
            this.dtpMapDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpMapDateTime.CustomFormat = "dd\'.\'MM\'.\'yyyy HH\':\'mm";
            this.dtpMapDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMapDateTime.Location = new System.Drawing.Point(3, 6);
            this.dtpMapDateTime.Name = "dtpMapDateTime";
            this.dtpMapDateTime.ShowUpDown = true;
            this.dtpMapDateTime.Size = new System.Drawing.Size(137, 23);
            this.dtpMapDateTime.TabIndex = 2;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMain.Controls.Add(this.map2d, 0, 0);
            this.tlpMain.Controls.Add(this.tlpMapControls, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(967, 804);
            this.tlpMain.TabIndex = 3;
            // 
            // map2d
            // 
            this.map2d.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("map2d.BackgroundImage")));
            this.map2d.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.map2d.ConstellationBorderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(125)))));
            this.map2d.ConstellationLineColor = System.Drawing.Color.DeepSkyBlue;
            this.map2d.CurrentTimeUtc = new System.DateTime(2022, 1, 22, 13, 54, 54, 997);
            this.map2d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map2d.Location = new System.Drawing.Point(0, 0);
            this.map2d.MagnitudeMaximum = -500D;
            this.map2d.MagnitudeMinimum = 5.5D;
            this.map2d.MapCircleColor = System.Drawing.Color.Black;
            this.map2d.Margin = new System.Windows.Forms.Padding(0);
            this.map2d.Name = "map2d";
            this.map2d.Plot2D = null;
            this.map2d.Size = new System.Drawing.Size(767, 804);
            this.map2d.StarColors = new System.Drawing.Color[0];
            this.map2d.StarSizes = new int[0];
            this.map2d.TabIndex = 0;
            this.map2d.CoordinatesChanged += new StarMap2D.Controls.WinForms.Map2D.OnCoordinatesChanged(this.map2d_CoordinatesChanged);
            // 
            // tlpMapControls
            // 
            this.tlpMapControls.ColumnCount = 2;
            this.tlpMapControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMapControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMapControls.Controls.Add(this.pnDateTime, 0, 0);
            this.tlpMapControls.Controls.Add(this.btPlayPause, 0, 1);
            this.tlpMapControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMapControls.Location = new System.Drawing.Point(770, 3);
            this.tlpMapControls.Name = "tlpMapControls";
            this.tlpMapControls.RowCount = 4;
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMapControls.Size = new System.Drawing.Size(194, 798);
            this.tlpMapControls.TabIndex = 1;
            // 
            // pnDateTime
            // 
            this.pnDateTime.AutoSize = true;
            this.tlpMapControls.SetColumnSpan(this.pnDateTime, 2);
            this.pnDateTime.Controls.Add(this.dtpMapDateTime);
            this.pnDateTime.Controls.Add(this.btGo);
            this.pnDateTime.Location = new System.Drawing.Point(3, 3);
            this.pnDateTime.Name = "pnDateTime";
            this.pnDateTime.Size = new System.Drawing.Size(188, 32);
            this.pnDateTime.TabIndex = 5;
            // 
            // btGo
            // 
            this.btGo.Checked = false;
            this.btGo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btGo.DisabledColor = System.Drawing.Color.LightGray;
            this.btGo.Enabled = false;
            this.btGo.ImageCheckedSvg = null;
            this.btGo.ImageColor = System.Drawing.Color.SteelBlue;
            this.btGo.ImageColorChecked = System.Drawing.Color.SteelBlue;
            this.btGo.ImageSvg = "ic_fluent_arrow_right_48_filled";
            this.btGo.IsCheckedButton = false;
            this.btGo.Location = new System.Drawing.Point(146, 6);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(36, 23);
            this.btGo.TabIndex = 6;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // btPlayPause
            // 
            this.btPlayPause.Checked = false;
            this.btPlayPause.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btPlayPause.DisabledColor = System.Drawing.Color.LightGray;
            this.btPlayPause.ImageCheckedSvg = "ic_fluent_pause_48_filled";
            this.btPlayPause.ImageColor = System.Drawing.Color.SteelBlue;
            this.btPlayPause.ImageColorChecked = System.Drawing.Color.SteelBlue;
            this.btPlayPause.ImageSvg = "ic_fluent_play_circle_48_filled";
            this.btPlayPause.IsCheckedButton = true;
            this.btPlayPause.Location = new System.Drawing.Point(3, 41);
            this.btPlayPause.Name = "btPlayPause";
            this.btPlayPause.Size = new System.Drawing.Size(91, 85);
            this.btPlayPause.TabIndex = 6;
            this.btPlayPause.CheckedChanged += new System.EventHandler<StarMap2D.Controls.WinForms.EventArguments.CheckedChangeEventArguments>(this.btPlayPause_CheckedChanged);
            // 
            // FormSkyMap2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 804);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSkyMap2D";
            this.Text = "Sky Map";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSkyMap2D_FormClosed);
            this.tlpMain.ResumeLayout(false);
            this.tlpMapControls.ResumeLayout(false);
            this.tlpMapControls.PerformLayout();
            this.pnDateTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmSetTime;
        private DateTimePicker dtpMapDateTime;
        private TableLayoutPanel tlpMain;
        private StarMap2D.Controls.WinForms.Map2D map2d;
        private TableLayoutPanel tlpMapControls;
        private Panel pnDateTime;
        private StarMap2D.Controls.WinForms.ImageButton btGo;
        private Controls.WinForms.ImageButton btPlayPause;
    }
}