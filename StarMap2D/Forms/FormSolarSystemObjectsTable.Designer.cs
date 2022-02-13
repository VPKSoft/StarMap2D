namespace StarMap2D.Forms
{
    partial class FormSolarSystemObjectsTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSolarSystemObjectsTable));
            this.adgSolarObjects = new Zuby.ADGV.AdvancedDataGridView();
            this.lbLongitude = new System.Windows.Forms.Label();
            this.nudLongitude = new System.Windows.Forms.NumericUpDown();
            this.lbLatitude = new System.Windows.Forms.Label();
            this.nudLatitude = new System.Windows.Forms.NumericUpDown();
            this.cmbJumpToLocation = new System.Windows.Forms.ComboBox();
            this.btResetLocation = new StarMap2D.Controls.WinForms.ImageButton();
            this.lbJumpToLocation = new System.Windows.Forms.Label();
            this.lbDateAndTime = new System.Windows.Forms.Label();
            this.dtpMapDateTime = new StarMap2D.Controls.WinForms.DateAndTimePicker();
            this.btGo = new StarMap2D.Controls.WinForms.ImageButton();
            this.imageButton1 = new StarMap2D.Controls.WinForms.ImageButton();
            this.imageButton2 = new StarMap2D.Controls.WinForms.ImageButton();
            this.sdCSV = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuHideColumn = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.adgSolarObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adgSolarObjects
            // 
            this.adgSolarObjects.AllowUserToAddRows = false;
            this.adgSolarObjects.AllowUserToDeleteRows = false;
            this.adgSolarObjects.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adgSolarObjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.adgSolarObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgSolarObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgSolarObjects.FilterAndSortEnabled = true;
            this.adgSolarObjects.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgSolarObjects.Location = new System.Drawing.Point(12, 69);
            this.adgSolarObjects.Name = "adgSolarObjects";
            this.adgSolarObjects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgSolarObjects.RowHeadersVisible = false;
            this.adgSolarObjects.RowTemplate.Height = 25;
            this.adgSolarObjects.Size = new System.Drawing.Size(933, 369);
            this.adgSolarObjects.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgSolarObjects.TabIndex = 0;
            this.adgSolarObjects.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.advancedDataGridView1_SortStringChanged);
            // 
            // lbLongitude
            // 
            this.lbLongitude.AutoSize = true;
            this.lbLongitude.Location = new System.Drawing.Point(443, 19);
            this.lbLongitude.Name = "lbLongitude";
            this.lbLongitude.Size = new System.Drawing.Size(61, 15);
            this.lbLongitude.TabIndex = 12;
            this.lbLongitude.Text = "Longitude";
            // 
            // nudLongitude
            // 
            this.nudLongitude.DecimalPlaces = 3;
            this.nudLongitude.Location = new System.Drawing.Point(443, 37);
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
            this.nudLongitude.Size = new System.Drawing.Size(110, 23);
            this.nudLongitude.TabIndex = 11;
            this.nudLongitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLongitude.ValueChanged += new System.EventHandler(this.nudLongitude_ValueChanged);
            // 
            // lbLatitude
            // 
            this.lbLatitude.AutoSize = true;
            this.lbLatitude.Location = new System.Drawing.Point(327, 19);
            this.lbLatitude.Name = "lbLatitude";
            this.lbLatitude.Size = new System.Drawing.Size(50, 15);
            this.lbLatitude.TabIndex = 10;
            this.lbLatitude.Text = "Latitude";
            // 
            // nudLatitude
            // 
            this.nudLatitude.DecimalPlaces = 3;
            this.nudLatitude.Location = new System.Drawing.Point(327, 37);
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
            this.nudLatitude.Size = new System.Drawing.Size(110, 23);
            this.nudLatitude.TabIndex = 9;
            this.nudLatitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLatitude.ValueChanged += new System.EventHandler(this.nudLongitude_ValueChanged);
            // 
            // cmbJumpToLocation
            // 
            this.cmbJumpToLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbJumpToLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbJumpToLocation.FormattingEnabled = true;
            this.cmbJumpToLocation.Location = new System.Drawing.Point(559, 37);
            this.cmbJumpToLocation.Name = "cmbJumpToLocation";
            this.cmbJumpToLocation.Size = new System.Drawing.Size(276, 23);
            this.cmbJumpToLocation.TabIndex = 8;
            this.cmbJumpToLocation.SelectedValueChanged += new System.EventHandler(this.cmbJumpToLocation_SelectedValueChanged);
            // 
            // btResetLocation
            // 
            this.btResetLocation.Checked = false;
            this.btResetLocation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btResetLocation.DisabledColor = System.Drawing.Color.LightGray;
            this.btResetLocation.ImageCheckedSvg = null;
            this.btResetLocation.ImageColor = System.Drawing.Color.SteelBlue;
            this.btResetLocation.ImageColorChecked = System.Drawing.Color.SteelBlue;
            this.btResetLocation.ImageSvg = "ic_fluent_arrow_undo_48_filled";
            this.btResetLocation.IsCheckedButton = false;
            this.btResetLocation.Location = new System.Drawing.Point(841, 37);
            this.btResetLocation.Name = "btResetLocation";
            this.btResetLocation.Size = new System.Drawing.Size(36, 23);
            this.btResetLocation.TabIndex = 7;
            // 
            // lbJumpToLocation
            // 
            this.lbJumpToLocation.AutoSize = true;
            this.lbJumpToLocation.Location = new System.Drawing.Point(559, 19);
            this.lbJumpToLocation.Name = "lbJumpToLocation";
            this.lbJumpToLocation.Size = new System.Drawing.Size(96, 15);
            this.lbJumpToLocation.TabIndex = 0;
            this.lbJumpToLocation.Text = "Jump to location";
            // 
            // lbDateAndTime
            // 
            this.lbDateAndTime.AutoSize = true;
            this.lbDateAndTime.Location = new System.Drawing.Point(12, 12);
            this.lbDateAndTime.Name = "lbDateAndTime";
            this.lbDateAndTime.Size = new System.Drawing.Size(81, 15);
            this.lbDateAndTime.TabIndex = 12;
            this.lbDateAndTime.Text = "Date and time";
            // 
            // dtpMapDateTime
            // 
            this.dtpMapDateTime.AutoSize = true;
            this.dtpMapDateTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dtpMapDateTime.Location = new System.Drawing.Point(12, 37);
            this.dtpMapDateTime.Name = "dtpMapDateTime";
            this.dtpMapDateTime.ShowUpButton = false;
            this.dtpMapDateTime.Size = new System.Drawing.Size(250, 26);
            this.dtpMapDateTime.TabIndex = 13;
            this.dtpMapDateTime.Value = new System.DateTime(2022, 2, 12, 16, 22, 2, 0);
            this.dtpMapDateTime.ValueChanged += new System.EventHandler(this.dtpMapDateTime_ValueChanged);
            // 
            // btGo
            // 
            this.btGo.Checked = false;
            this.btGo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btGo.DisabledColor = System.Drawing.Color.LightGray;
            this.btGo.ImageCheckedSvg = null;
            this.btGo.ImageColor = System.Drawing.Color.SteelBlue;
            this.btGo.ImageColorChecked = System.Drawing.Color.SteelBlue;
            this.btGo.ImageSvg = "ic_fluent_arrow_right_48_filled";
            this.btGo.IsCheckedButton = false;
            this.btGo.Location = new System.Drawing.Point(268, 37);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(36, 23);
            this.btGo.TabIndex = 14;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // imageButton1
            // 
            this.imageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton1.Checked = false;
            this.imageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton1.DisabledColor = System.Drawing.Color.LightGray;
            this.imageButton1.ImageCheckedSvg = null;
            this.imageButton1.ImageColor = System.Drawing.Color.SteelBlue;
            this.imageButton1.ImageColorChecked = System.Drawing.Color.SteelBlue;
            this.imageButton1.ImageSvg = "ic_fluent_document_arrow_down_20_filled";
            this.imageButton1.IsCheckedButton = false;
            this.imageButton1.Location = new System.Drawing.Point(909, 8);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(36, 23);
            this.imageButton1.TabIndex = 15;
            this.imageButton1.Click += new System.EventHandler(this.imageButton1_Click);
            // 
            // imageButton2
            // 
            this.imageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton2.Checked = false;
            this.imageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton2.DisabledColor = System.Drawing.Color.LightGray;
            this.imageButton2.ImageCheckedSvg = null;
            this.imageButton2.ImageColor = System.Drawing.Color.SteelBlue;
            this.imageButton2.ImageColorChecked = System.Drawing.Color.SteelBlue;
            this.imageButton2.ImageSvg = "ic_fluent_copy_24_filled";
            this.imageButton2.IsCheckedButton = false;
            this.imageButton2.Location = new System.Drawing.Point(909, 37);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.Size = new System.Drawing.Size(36, 23);
            this.imageButton2.TabIndex = 16;
            this.imageButton2.Click += new System.EventHandler(this.imageButton2_Click);
            // 
            // sdCSV
            // 
            this.sdCSV.DefaultExt = "*.csv";
            this.sdCSV.Filter = "*.csv|Delimited data files";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHideColumn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 26);
            // 
            // mnuHideColumn
            // 
            this.mnuHideColumn.Name = "mnuHideColumn";
            this.mnuHideColumn.Size = new System.Drawing.Size(143, 22);
            this.mnuHideColumn.Text = "Hide column";
            // 
            // FormSolarSystemObjectsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.imageButton2);
            this.Controls.Add(this.imageButton1);
            this.Controls.Add(this.lbLongitude);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.nudLongitude);
            this.Controls.Add(this.dtpMapDateTime);
            this.Controls.Add(this.lbLatitude);
            this.Controls.Add(this.nudLatitude);
            this.Controls.Add(this.lbDateAndTime);
            this.Controls.Add(this.cmbJumpToLocation);
            this.Controls.Add(this.adgSolarObjects);
            this.Controls.Add(this.btResetLocation);
            this.Controls.Add(this.lbJumpToLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSolarSystemObjectsTable";
            this.Text = "Solar system object data";
            ((System.ComponentModel.ISupportInitialize)(this.adgSolarObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Zuby.ADGV.AdvancedDataGridView adgSolarObjects;
        private Label lbLongitude;
        private NumericUpDown nudLongitude;
        private Label lbLatitude;
        private NumericUpDown nudLatitude;
        private ComboBox cmbJumpToLocation;
        private Controls.WinForms.ImageButton btResetLocation;
        private Label lbJumpToLocation;
        private Label lbDateAndTime;
        private Controls.WinForms.DateAndTimePicker dtpMapDateTime;
        private Controls.WinForms.ImageButton btGo;
        private Controls.WinForms.ImageButton imageButton1;
        private Controls.WinForms.ImageButton imageButton2;
        private SaveFileDialog sdCSV;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnuHideColumn;
    }
}