namespace StarMap2D.CustomControls
{
    partial class StarMagnitudeEditor
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
            this.tlpStarMagnitudes = new System.Windows.Forms.TableLayoutPanel();
            this.ceColor = new Cyotek.Windows.Forms.ColorEditor();
            this.cwColor = new Cyotek.Windows.Forms.ColorWheel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pn = new System.Windows.Forms.Panel();
            this.nudStarSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSelectedMagnitude = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpStarMagnitudes
            // 
            this.tlpStarMagnitudes.AutoScroll = true;
            this.tlpStarMagnitudes.ColumnCount = 4;
            this.tlpStarMagnitudes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpStarMagnitudes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpStarMagnitudes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpStarMagnitudes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStarMagnitudes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStarMagnitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStarMagnitudes.Location = new System.Drawing.Point(0, 0);
            this.tlpStarMagnitudes.Margin = new System.Windows.Forms.Padding(0);
            this.tlpStarMagnitudes.Name = "tlpStarMagnitudes";
            this.tlpStarMagnitudes.RowCount = 2;
            this.tlpMain.SetRowSpan(this.tlpStarMagnitudes, 4);
            this.tlpStarMagnitudes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpStarMagnitudes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpStarMagnitudes.Size = new System.Drawing.Size(162, 285);
            this.tlpStarMagnitudes.TabIndex = 0;
            // 
            // ceColor
            // 
            this.ceColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ceColor.Location = new System.Drawing.Point(382, 3);
            this.ceColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ceColor.Name = "ceColor";
            this.tlpMain.SetRowSpan(this.ceColor, 4);
            this.ceColor.Size = new System.Drawing.Size(208, 279);
            this.ceColor.TabIndex = 5;
            this.ceColor.ColorChanged += new System.EventHandler(this.controlColor_ColorChanged);
            // 
            // cwColor
            // 
            this.cwColor.Alpha = 1D;
            this.cwColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cwColor.Location = new System.Drawing.Point(162, 71);
            this.cwColor.Margin = new System.Windows.Forms.Padding(0);
            this.cwColor.Name = "cwColor";
            this.tlpMain.SetRowSpan(this.cwColor, 3);
            this.cwColor.Size = new System.Drawing.Size(216, 214);
            this.cwColor.TabIndex = 4;
            this.cwColor.ColorChanged += new System.EventHandler(this.controlColor_ColorChanged);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tlpMain.Controls.Add(this.tlpStarMagnitudes, 0, 0);
            this.tlpMain.Controls.Add(this.ceColor, 2, 0);
            this.tlpMain.Controls.Add(this.cwColor, 1, 1);
            this.tlpMain.Controls.Add(this.pn, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Size = new System.Drawing.Size(594, 285);
            this.tlpMain.TabIndex = 7;
            // 
            // pn
            // 
            this.pn.Controls.Add(this.nudStarSize);
            this.pn.Controls.Add(this.label1);
            this.pn.Controls.Add(this.lbSelectedMagnitude);
            this.pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn.Location = new System.Drawing.Point(162, 0);
            this.pn.Margin = new System.Windows.Forms.Padding(0);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(216, 71);
            this.pn.TabIndex = 6;
            // 
            // nudStarSize
            // 
            this.nudStarSize.Location = new System.Drawing.Point(128, 18);
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
            this.nudStarSize.Size = new System.Drawing.Size(85, 23);
            this.nudStarSize.TabIndex = 9;
            this.nudStarSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStarSize.ValueChanged += new System.EventHandler(this.nudStarSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Star diameter size:";
            // 
            // lbSelectedMagnitude
            // 
            this.lbSelectedMagnitude.AutoSize = true;
            this.lbSelectedMagnitude.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSelectedMagnitude.Location = new System.Drawing.Point(3, 3);
            this.lbSelectedMagnitude.Name = "lbSelectedMagnitude";
            this.lbSelectedMagnitude.Size = new System.Drawing.Size(119, 15);
            this.lbSelectedMagnitude.TabIndex = 7;
            this.lbSelectedMagnitude.Text = "Selected magnitude";
            // 
            // StarMagnitudeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "StarMagnitudeEditor";
            this.Size = new System.Drawing.Size(594, 285);
            this.tlpMain.ResumeLayout(false);
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpStarMagnitudes;
        private Cyotek.Windows.Forms.ColorEditor ceColor;
        private Cyotek.Windows.Forms.ColorWheel cwColor;
        private TableLayoutPanel tlpMain;
        private Panel pn;
        private NumericUpDown nudStarSize;
        private Label label1;
        private Label lbSelectedMagnitude;
    }
}
