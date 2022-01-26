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
    partial class SolarSystemObjectConfigurator
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.ceColor = new Cyotek.Windows.Forms.ColorEditor();
            this.cwColor = new Cyotek.Windows.Forms.ColorWheel();
            this.pn = new System.Windows.Forms.Panel();
            this.cbDontUse = new System.Windows.Forms.CheckBox();
            this.lbSelectedSymbolName = new System.Windows.Forms.Label();
            this.lbSelectedSymbol = new System.Windows.Forms.Label();
            this.gpColorTo = new System.Windows.Forms.GroupBox();
            this.rbSymbol = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.nudStarSize = new System.Windows.Forms.NumericUpDown();
            this.lbObjectDiameter = new System.Windows.Forms.Label();
            this.lbSolarSystemObjects = new StarMap2D.Controls.WinForms.ListBoxExtended();
            this.pnMapSymbol = new System.Windows.Forms.Panel();
            this.lbObjectName = new System.Windows.Forms.Label();
            this.tbObjectName = new System.Windows.Forms.TextBox();
            this.tlpMain.SuspendLayout();
            this.pn.SuspendLayout();
            this.gpColorTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tlpMain.Controls.Add(this.ceColor, 2, 1);
            this.tlpMain.Controls.Add(this.cwColor, 1, 2);
            this.tlpMain.Controls.Add(this.pn, 0, 0);
            this.tlpMain.Controls.Add(this.lbSolarSystemObjects, 0, 1);
            this.tlpMain.Controls.Add(this.pnMapSymbol, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.Size = new System.Drawing.Size(594, 360);
            this.tlpMain.TabIndex = 8;
            // 
            // ceColor
            // 
            this.ceColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.ceColor.Location = new System.Drawing.Point(382, 75);
            this.ceColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ceColor.Name = "ceColor";
            this.tlpMain.SetRowSpan(this.ceColor, 4);
            this.ceColor.Size = new System.Drawing.Size(208, 274);
            this.ceColor.TabIndex = 5;
            // 
            // cwColor
            // 
            this.cwColor.Alpha = 1D;
            this.cwColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.cwColor.Location = new System.Drawing.Point(162, 144);
            this.cwColor.Margin = new System.Windows.Forms.Padding(0);
            this.cwColor.Name = "cwColor";
            this.tlpMain.SetRowSpan(this.cwColor, 3);
            this.cwColor.Size = new System.Drawing.Size(216, 205);
            this.cwColor.TabIndex = 4;
            this.cwColor.ColorChanged += new System.EventHandler(this.cwColor_ColorChanged);
            // 
            // pn
            // 
            this.tlpMain.SetColumnSpan(this.pn, 3);
            this.pn.Controls.Add(this.tbObjectName);
            this.pn.Controls.Add(this.lbObjectName);
            this.pn.Controls.Add(this.cbDontUse);
            this.pn.Controls.Add(this.lbSelectedSymbolName);
            this.pn.Controls.Add(this.lbSelectedSymbol);
            this.pn.Controls.Add(this.gpColorTo);
            this.pn.Controls.Add(this.nudStarSize);
            this.pn.Controls.Add(this.lbObjectDiameter);
            this.pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Margin = new System.Windows.Forms.Padding(0);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(594, 72);
            this.pn.TabIndex = 6;
            // 
            // cbDontUse
            // 
            this.cbDontUse.AutoSize = true;
            this.cbDontUse.Location = new System.Drawing.Point(131, 5);
            this.cbDontUse.Name = "cbDontUse";
            this.cbDontUse.Size = new System.Drawing.Size(132, 19);
            this.cbDontUse.TabIndex = 13;
            this.cbDontUse.Text = "Don\'t use the object";
            this.cbDontUse.UseVisualStyleBackColor = true;
            this.cbDontUse.CheckedChanged += new System.EventHandler(this.cbDontUse_CheckedChanged);
            // 
            // lbSelectedSymbolName
            // 
            this.lbSelectedSymbolName.AutoSize = true;
            this.lbSelectedSymbolName.Location = new System.Drawing.Point(22, 20);
            this.lbSelectedSymbolName.Name = "lbSelectedSymbolName";
            this.lbSelectedSymbolName.Size = new System.Drawing.Size(12, 15);
            this.lbSelectedSymbolName.TabIndex = 12;
            this.lbSelectedSymbolName.Text = "-";
            // 
            // lbSelectedSymbol
            // 
            this.lbSelectedSymbol.AutoSize = true;
            this.lbSelectedSymbol.Location = new System.Drawing.Point(3, 5);
            this.lbSelectedSymbol.Name = "lbSelectedSymbol";
            this.lbSelectedSymbol.Size = new System.Drawing.Size(93, 15);
            this.lbSelectedSymbol.TabIndex = 11;
            this.lbSelectedSymbol.Text = "Selected symbol";
            // 
            // gpColorTo
            // 
            this.gpColorTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpColorTo.Controls.Add(this.rbSymbol);
            this.gpColorTo.Controls.Add(this.rbCircle);
            this.gpColorTo.Location = new System.Drawing.Point(342, 5);
            this.gpColorTo.Name = "gpColorTo";
            this.gpColorTo.Size = new System.Drawing.Size(248, 61);
            this.gpColorTo.TabIndex = 10;
            this.gpColorTo.TabStop = false;
            this.gpColorTo.Text = "Color changes to";
            // 
            // rbSymbol
            // 
            this.rbSymbol.AutoSize = true;
            this.rbSymbol.Location = new System.Drawing.Point(135, 22);
            this.rbSymbol.Name = "rbSymbol";
            this.rbSymbol.Size = new System.Drawing.Size(65, 19);
            this.rbSymbol.TabIndex = 1;
            this.rbSymbol.Text = "Symbol";
            this.rbSymbol.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Checked = true;
            this.rbCircle.Location = new System.Drawing.Point(6, 22);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(55, 19);
            this.rbCircle.TabIndex = 0;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // nudStarSize
            // 
            this.nudStarSize.Location = new System.Drawing.Point(131, 42);
            this.nudStarSize.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudStarSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStarSize.Name = "nudStarSize";
            this.nudStarSize.Size = new System.Drawing.Size(43, 23);
            this.nudStarSize.TabIndex = 9;
            this.nudStarSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStarSize.ValueChanged += new System.EventHandler(this.nudStarSize_ValueChanged);
            // 
            // lbObjectDiameter
            // 
            this.lbObjectDiameter.AutoSize = true;
            this.lbObjectDiameter.Location = new System.Drawing.Point(3, 44);
            this.lbObjectDiameter.Name = "lbObjectDiameter";
            this.lbObjectDiameter.Size = new System.Drawing.Size(95, 15);
            this.lbObjectDiameter.TabIndex = 8;
            this.lbObjectDiameter.Text = "Object diameter:";
            // 
            // lbSolarSystemObjects
            // 
            this.lbSolarSystemObjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSolarSystemObjects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbSolarSystemObjects.FormattingEnabled = true;
            this.lbSolarSystemObjects.Location = new System.Drawing.Point(3, 75);
            this.lbSolarSystemObjects.Name = "lbSolarSystemObjects";
            this.tlpMain.SetRowSpan(this.lbSolarSystemObjects, 4);
            this.lbSolarSystemObjects.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSolarSystemObjects.Size = new System.Drawing.Size(156, 274);
            this.lbSolarSystemObjects.TabIndex = 7;
            this.lbSolarSystemObjects.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbSolarSystemObjects_DrawItem);
            this.lbSolarSystemObjects.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lbSolarSystemObjects_MeasureItem);
            this.lbSolarSystemObjects.SelectedIndexChanged += new System.EventHandler(this.lbSolarSystemObjects_SelectedIndexChanged);
            this.lbSolarSystemObjects.SelectedValueChanged += new System.EventHandler(this.lbSolarSystemObjects_SelectedIndexChanged);
            // 
            // pnMapSymbol
            // 
            this.pnMapSymbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnMapSymbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMapSymbol.Location = new System.Drawing.Point(162, 72);
            this.pnMapSymbol.Margin = new System.Windows.Forms.Padding(0);
            this.pnMapSymbol.Name = "pnMapSymbol";
            this.pnMapSymbol.Size = new System.Drawing.Size(216, 72);
            this.pnMapSymbol.TabIndex = 8;
            // 
            // lbObjectName
            // 
            this.lbObjectName.AutoSize = true;
            this.lbObjectName.Location = new System.Drawing.Point(180, 23);
            this.lbObjectName.Name = "lbObjectName";
            this.lbObjectName.Size = new System.Drawing.Size(75, 15);
            this.lbObjectName.TabIndex = 14;
            this.lbObjectName.Text = "Object name";
            // 
            // tbObjectName
            // 
            this.tbObjectName.Location = new System.Drawing.Point(180, 41);
            this.tbObjectName.Name = "tbObjectName";
            this.tbObjectName.Size = new System.Drawing.Size(156, 23);
            this.tbObjectName.TabIndex = 15;
            this.tbObjectName.TextChanged += new System.EventHandler(this.tbObjectName_TextChanged);
            // 
            // SolarSystemObjectConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SolarSystemObjectConfigurator";
            this.Size = new System.Drawing.Size(594, 360);
            this.tlpMain.ResumeLayout(false);
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.gpColorTo.ResumeLayout(false);
            this.gpColorTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Cyotek.Windows.Forms.ColorEditor ceColor;
        private Cyotek.Windows.Forms.ColorWheel cwColor;
        private Panel pn;
        private NumericUpDown nudStarSize;
        private Label lbObjectDiameter;
        private ListBoxExtended lbSolarSystemObjects;
        private Panel pnMapSymbol;
        private Label lbSelectedSymbolName;
        private Label lbSelectedSymbol;
        private GroupBox gpColorTo;
        private RadioButton rbSymbol;
        private RadioButton rbCircle;
        private CheckBox cbDontUse;
        private TextBox tbObjectName;
        private Label lbObjectName;
    }
}
