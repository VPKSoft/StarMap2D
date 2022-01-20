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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btPlayPause = new System.Windows.Forms.Button();
            this.btGo = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.map2d = new StarMap2D.CustomControls.Map2D();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmSetTime
            // 
            this.tmSetTime.Tick += new System.EventHandler(this.tmSetTime_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd\'.\'MM\'.\'yyyy HH\':\'mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btPlayPause
            // 
            this.btPlayPause.Location = new System.Drawing.Point(100, 402);
            this.btPlayPause.Name = "btPlayPause";
            this.btPlayPause.Size = new System.Drawing.Size(71, 23);
            this.btPlayPause.TabIndex = 3;
            this.btPlayPause.Text = ">";
            this.btPlayPause.UseVisualStyleBackColor = true;
            this.btPlayPause.Click += new System.EventHandler(this.btPlayPause_Click);
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(3, 402);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(71, 23);
            this.btGo.TabIndex = 4;
            this.btGo.Text = "-->";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMain.Controls.Add(this.map2d, 0, 0);
            this.tlpMain.Controls.Add(this.tableLayoutPanel3, 1, 0);
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
            this.map2d.CurrentTimeUtc = new System.DateTime(2022, 1, 18, 18, 14, 11, 743);
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
            this.map2d.CoordinatesChanged += new StarMap2D.CustomControls.Map2D.OnCoordinatesChanged(this.map2d_CoordinatesChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dateTimePicker1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btPlayPause, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btGo, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(770, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(194, 798);
            this.tableLayoutPanel3.TabIndex = 1;
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmSetTime;
        private DateTimePicker dateTimePicker1;
        private Button btPlayPause;
        private Button btGo;
        private TableLayoutPanel tlpMain;
        private CustomControls.Map2D map2d;
        private TableLayoutPanel tableLayoutPanel3;
    }
}