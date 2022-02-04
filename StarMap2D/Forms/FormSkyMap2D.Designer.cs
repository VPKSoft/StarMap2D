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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbLongitude = new System.Windows.Forms.Label();
            this.nudLongitude = new System.Windows.Forms.NumericUpDown();
            this.lbLatitude = new System.Windows.Forms.Label();
            this.nudLatitude = new System.Windows.Forms.NumericUpDown();
            this.cmbJumpToLocation = new System.Windows.Forms.ComboBox();
            this.btResetLocation = new StarMap2D.Controls.WinForms.ImageButton();
            this.lbJumpToLocation = new System.Windows.Forms.Label();
            this.pnDateTime = new System.Windows.Forms.Panel();
            this.btGo = new StarMap2D.Controls.WinForms.ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRevertSpeed = new StarMap2D.Controls.WinForms.ImageButton();
            this.cmbTimeType = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbSpeedPerSecond = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.compassView1 = new StarMap2D.Controls.WinForms.CompassView();
            this.cbInvertEastWest = new System.Windows.Forms.CheckBox();
            this.cbShowConstellationBorders = new System.Windows.Forms.CheckBox();
            this.cbConstellationLines = new System.Windows.Forms.CheckBox();
            this.cbConstellationNames = new System.Windows.Forms.CheckBox();
            this.cbSkipCalculated = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbAboveHorizonValue = new System.Windows.Forms.CheckBox();
            this.lbAboveHorizon = new System.Windows.Forms.Label();
            this.lbHorizontalYValue = new System.Windows.Forms.Label();
            this.lbHorizontalCoordinates = new System.Windows.Forms.Label();
            this.lbRaDec = new System.Windows.Forms.Label();
            this.lbObjectName = new System.Windows.Forms.Label();
            this.lbHorizontalXValue = new System.Windows.Forms.Label();
            this.lbDeclinationValue = new System.Windows.Forms.Label();
            this.lbRightAscensionValue = new System.Windows.Forms.Label();
            this.lbObjectNameValue = new System.Windows.Forms.Label();
            this.cbDrawCrossHair = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbHour1 = new System.Windows.Forms.Label();
            this.btHourNext = new StarMap2D.Controls.WinForms.ImageButton();
            this.btHourPrevious = new StarMap2D.Controls.WinForms.ImageButton();
            this.btPlayPause = new StarMap2D.Controls.WinForms.ImageButton();
            this.tlpMain.SuspendLayout();
            this.tlpMapControls.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).BeginInit();
            this.pnDateTime.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.dtpMapDateTime.Size = new System.Drawing.Size(187, 23);
            this.dtpMapDateTime.TabIndex = 2;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpMain.Controls.Add(this.map2d, 0, 0);
            this.tlpMain.Controls.Add(this.tlpMapControls, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(998, 804);
            this.tlpMain.TabIndex = 3;
            // 
            // map2d
            // 
            this.map2d.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("map2d.BackgroundImage")));
            this.map2d.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.map2d.ConstellationBorderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(23)))), ((int)(((byte)(125)))));
            this.map2d.ConstellationLineColor = System.Drawing.Color.DeepSkyBlue;
            this.map2d.CrossHairColor = System.Drawing.Color.LimeGreen;
            this.map2d.CrossHairSize = 20;
            this.map2d.CurrentTimeUtc = new System.DateTime(2022, 2, 4, 17, 26, 19, 218);
            this.map2d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map2d.DrawConstellationBoundaries = false;
            this.map2d.DrawConstellationNames = true;
            this.map2d.DrawConstellations = true;
            this.map2d.DrawCrossHair = true;
            this.map2d.InvertEastWest = false;
            this.map2d.Latitude = 0D;
            this.map2d.Locale = "fi-FI";
            this.map2d.Location = new System.Drawing.Point(0, 0);
            this.map2d.Longitude = 0D;
            this.map2d.MagnitudeMaximum = -500D;
            this.map2d.MagnitudeMinimum = 5.5D;
            this.map2d.MapCircleColor = System.Drawing.Color.Black;
            this.map2d.Margin = new System.Windows.Forms.Padding(0);
            this.map2d.Name = "map2d";
            this.map2d.Plot2D = null;
            this.map2d.Size = new System.Drawing.Size(748, 804);
            this.map2d.SkipCalculatedObjects = false;
            this.map2d.StarColors = new System.Drawing.Color[0];
            this.map2d.StarSizes = new int[0];
            this.map2d.TabIndex = 0;
            this.map2d.CoordinatesChanged += new StarMap2D.Controls.WinForms.Map2D.OnCoordinatesChanged(this.map2d_CoordinatesChanged);
            this.map2d.MouseHoverObject += new StarMap2D.Controls.WinForms.Map2D.OnObjectUserInteraction(this.map2d_MouseHoverObject);
            this.map2d.MouseLeaveObject += new StarMap2D.Controls.WinForms.Map2D.OnObjectUserInteraction(this.map2d_MouseLeaveObject);
            this.map2d.MouseClickObject += new StarMap2D.Controls.WinForms.Map2D.OnObjectUserInteraction(this.map2d_MouseClickObject);
            this.map2d.MouseDoubleClickObject += new StarMap2D.Controls.WinForms.Map2D.OnObjectUserInteraction(this.map2d_MouseDoubleClickObject);
            // 
            // tlpMapControls
            // 
            this.tlpMapControls.ColumnCount = 2;
            this.tlpMapControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMapControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMapControls.Controls.Add(this.panel3, 0, 9);
            this.tlpMapControls.Controls.Add(this.pnDateTime, 0, 0);
            this.tlpMapControls.Controls.Add(this.panel1, 0, 1);
            this.tlpMapControls.Controls.Add(this.panel2, 0, 12);
            this.tlpMapControls.Controls.Add(this.cbInvertEastWest, 0, 3);
            this.tlpMapControls.Controls.Add(this.cbShowConstellationBorders, 0, 4);
            this.tlpMapControls.Controls.Add(this.cbConstellationLines, 0, 5);
            this.tlpMapControls.Controls.Add(this.cbConstellationNames, 0, 6);
            this.tlpMapControls.Controls.Add(this.cbSkipCalculated, 0, 7);
            this.tlpMapControls.Controls.Add(this.panel4, 0, 10);
            this.tlpMapControls.Controls.Add(this.cbDrawCrossHair, 0, 8);
            this.tlpMapControls.Controls.Add(this.panel5, 0, 2);
            this.tlpMapControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMapControls.Location = new System.Drawing.Point(751, 3);
            this.tlpMapControls.Name = "tlpMapControls";
            this.tlpMapControls.RowCount = 13;
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMapControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMapControls.Size = new System.Drawing.Size(244, 798);
            this.tlpMapControls.TabIndex = 1;
            // 
            // panel3
            // 
            this.tlpMapControls.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.lbLongitude);
            this.panel3.Controls.Add(this.nudLongitude);
            this.panel3.Controls.Add(this.lbLatitude);
            this.panel3.Controls.Add(this.nudLatitude);
            this.panel3.Controls.Add(this.cmbJumpToLocation);
            this.panel3.Controls.Add(this.btResetLocation);
            this.panel3.Controls.Add(this.lbJumpToLocation);
            this.panel3.Location = new System.Drawing.Point(3, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 104);
            this.panel3.TabIndex = 10;
            // 
            // lbLongitude
            // 
            this.lbLongitude.AutoSize = true;
            this.lbLongitude.Location = new System.Drawing.Point(119, 54);
            this.lbLongitude.Name = "lbLongitude";
            this.lbLongitude.Size = new System.Drawing.Size(61, 15);
            this.lbLongitude.TabIndex = 12;
            this.lbLongitude.Text = "Longitude";
            // 
            // nudLongitude
            // 
            this.nudLongitude.DecimalPlaces = 3;
            this.nudLongitude.Location = new System.Drawing.Point(119, 72);
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
            this.nudLongitude.ValueChanged += new System.EventHandler(this.nudLatitudeLongitude_ValueChanged);
            // 
            // lbLatitude
            // 
            this.lbLatitude.AutoSize = true;
            this.lbLatitude.Location = new System.Drawing.Point(3, 54);
            this.lbLatitude.Name = "lbLatitude";
            this.lbLatitude.Size = new System.Drawing.Size(50, 15);
            this.lbLatitude.TabIndex = 10;
            this.lbLatitude.Text = "Latitude";
            // 
            // nudLatitude
            // 
            this.nudLatitude.DecimalPlaces = 3;
            this.nudLatitude.Location = new System.Drawing.Point(3, 72);
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
            this.nudLatitude.ValueChanged += new System.EventHandler(this.nudLatitudeLongitude_ValueChanged);
            // 
            // cmbJumpToLocation
            // 
            this.cmbJumpToLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbJumpToLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbJumpToLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbJumpToLocation.FormattingEnabled = true;
            this.cmbJumpToLocation.Location = new System.Drawing.Point(3, 28);
            this.cmbJumpToLocation.Name = "cmbJumpToLocation";
            this.cmbJumpToLocation.Size = new System.Drawing.Size(229, 23);
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
            this.btResetLocation.Location = new System.Drawing.Point(196, 3);
            this.btResetLocation.Name = "btResetLocation";
            this.btResetLocation.Size = new System.Drawing.Size(36, 23);
            this.btResetLocation.TabIndex = 7;
            this.btResetLocation.Click += new System.EventHandler(this.btResetLocation_Click);
            // 
            // lbJumpToLocation
            // 
            this.lbJumpToLocation.AutoSize = true;
            this.lbJumpToLocation.Location = new System.Drawing.Point(3, 10);
            this.lbJumpToLocation.Name = "lbJumpToLocation";
            this.lbJumpToLocation.Size = new System.Drawing.Size(96, 15);
            this.lbJumpToLocation.TabIndex = 0;
            this.lbJumpToLocation.Text = "Jump to location";
            // 
            // pnDateTime
            // 
            this.pnDateTime.AutoSize = true;
            this.tlpMapControls.SetColumnSpan(this.pnDateTime, 2);
            this.pnDateTime.Controls.Add(this.dtpMapDateTime);
            this.pnDateTime.Controls.Add(this.btGo);
            this.pnDateTime.Location = new System.Drawing.Point(3, 3);
            this.pnDateTime.Name = "pnDateTime";
            this.pnDateTime.Size = new System.Drawing.Size(238, 32);
            this.pnDateTime.TabIndex = 5;
            // 
            // btGo
            // 
            this.btGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGo.Checked = false;
            this.btGo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btGo.DisabledColor = System.Drawing.Color.LightGray;
            this.btGo.ImageCheckedSvg = null;
            this.btGo.ImageColor = System.Drawing.Color.SteelBlue;
            this.btGo.ImageColorChecked = System.Drawing.Color.SteelBlue;
            this.btGo.ImageSvg = "ic_fluent_arrow_right_48_filled";
            this.btGo.IsCheckedButton = false;
            this.btGo.Location = new System.Drawing.Point(199, 6);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(36, 23);
            this.btGo.TabIndex = 6;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // panel1
            // 
            this.tlpMapControls.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btRevertSpeed);
            this.panel1.Controls.Add(this.cmbTimeType);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.lbSpeedPerSecond);
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 62);
            this.panel1.TabIndex = 7;
            // 
            // btRevertSpeed
            // 
            this.btRevertSpeed.Checked = false;
            this.btRevertSpeed.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btRevertSpeed.DisabledColor = System.Drawing.Color.LightGray;
            this.btRevertSpeed.ImageCheckedSvg = null;
            this.btRevertSpeed.ImageColor = System.Drawing.Color.SteelBlue;
            this.btRevertSpeed.ImageColorChecked = System.Drawing.Color.SteelBlue;
            this.btRevertSpeed.ImageSvg = "ic_fluent_arrow_undo_48_filled";
            this.btRevertSpeed.IsCheckedButton = false;
            this.btRevertSpeed.Location = new System.Drawing.Point(196, 3);
            this.btRevertSpeed.Name = "btRevertSpeed";
            this.btRevertSpeed.Size = new System.Drawing.Size(36, 23);
            this.btRevertSpeed.TabIndex = 7;
            this.btRevertSpeed.Click += new System.EventHandler(this.btRevertSpeed_Click);
            // 
            // cmbTimeType
            // 
            this.cmbTimeType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTimeType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTimeType.DisplayMember = "Value";
            this.cmbTimeType.FormattingEnabled = true;
            this.cmbTimeType.Items.AddRange(new object[] {
            "seconds",
            "minutes",
            "hours",
            "days",
            "months",
            "weeks",
            "years"});
            this.cmbTimeType.Location = new System.Drawing.Point(136, 28);
            this.cmbTimeType.Name = "cmbTimeType";
            this.cmbTimeType.Size = new System.Drawing.Size(96, 23);
            this.cmbTimeType.TabIndex = 2;
            this.cmbTimeType.Text = "seconds";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Location = new System.Drawing.Point(3, 28);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(127, 23);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbSpeedPerSecond
            // 
            this.lbSpeedPerSecond.AutoSize = true;
            this.lbSpeedPerSecond.Location = new System.Drawing.Point(3, 10);
            this.lbSpeedPerSecond.Name = "lbSpeedPerSecond";
            this.lbSpeedPerSecond.Size = new System.Drawing.Size(88, 15);
            this.lbSpeedPerSecond.TabIndex = 0;
            this.lbSpeedPerSecond.Text = "Speed / second";
            // 
            // panel2
            // 
            this.tlpMapControls.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.compassView1);
            this.panel2.Location = new System.Drawing.Point(3, 550);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 244);
            this.panel2.TabIndex = 8;
            // 
            // compassView1
            // 
            this.compassView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compassView1.EastName = "E";
            this.compassView1.InvertEastWest = false;
            this.compassView1.Location = new System.Drawing.Point(0, 0);
            this.compassView1.Name = "compassView1";
            this.compassView1.NorthEastName = "NE";
            this.compassView1.NorthName = "N";
            this.compassView1.NorthWestName = "NW";
            this.compassView1.Size = new System.Drawing.Size(238, 244);
            this.compassView1.SouthEastName = "SE";
            this.compassView1.SouthName = "S";
            this.compassView1.SouthWestName = "SW";
            this.compassView1.TabIndex = 0;
            this.compassView1.WestName = "W";
            // 
            // cbInvertEastWest
            // 
            this.cbInvertEastWest.AutoSize = true;
            this.cbInvertEastWest.Location = new System.Drawing.Point(3, 137);
            this.cbInvertEastWest.Name = "cbInvertEastWest";
            this.cbInvertEastWest.Size = new System.Drawing.Size(109, 19);
            this.cbInvertEastWest.TabIndex = 9;
            this.cbInvertEastWest.Text = "Invert east-west";
            this.cbInvertEastWest.UseVisualStyleBackColor = true;
            this.cbInvertEastWest.CheckedChanged += new System.EventHandler(this.cbInvertEastWest_CheckedChanged);
            // 
            // cbShowConstellationBorders
            // 
            this.cbShowConstellationBorders.AutoSize = true;
            this.tlpMapControls.SetColumnSpan(this.cbShowConstellationBorders, 2);
            this.cbShowConstellationBorders.Location = new System.Drawing.Point(3, 162);
            this.cbShowConstellationBorders.Name = "cbShowConstellationBorders";
            this.cbShowConstellationBorders.Size = new System.Drawing.Size(139, 19);
            this.cbShowConstellationBorders.TabIndex = 11;
            this.cbShowConstellationBorders.Text = "Constellation borders";
            this.cbShowConstellationBorders.UseVisualStyleBackColor = true;
            this.cbShowConstellationBorders.CheckedChanged += new System.EventHandler(this.cbShowConstellationBorders_CheckedChanged);
            // 
            // cbConstellationLines
            // 
            this.cbConstellationLines.AutoSize = true;
            this.tlpMapControls.SetColumnSpan(this.cbConstellationLines, 2);
            this.cbConstellationLines.Location = new System.Drawing.Point(3, 187);
            this.cbConstellationLines.Name = "cbConstellationLines";
            this.cbConstellationLines.Size = new System.Drawing.Size(123, 19);
            this.cbConstellationLines.TabIndex = 12;
            this.cbConstellationLines.Text = "Constellation lines";
            this.cbConstellationLines.UseVisualStyleBackColor = true;
            this.cbConstellationLines.CheckedChanged += new System.EventHandler(this.cbConstellationLines_CheckedChanged);
            // 
            // cbConstellationNames
            // 
            this.cbConstellationNames.AutoSize = true;
            this.cbConstellationNames.Location = new System.Drawing.Point(3, 212);
            this.cbConstellationNames.Name = "cbConstellationNames";
            this.cbConstellationNames.Size = new System.Drawing.Size(116, 19);
            this.cbConstellationNames.TabIndex = 13;
            this.cbConstellationNames.Text = "Constellation names";
            this.cbConstellationNames.UseVisualStyleBackColor = true;
            this.cbConstellationNames.CheckedChanged += new System.EventHandler(this.cbConstellationNames_CheckedChanged);
            // 
            // cbSkipCalculated
            // 
            this.cbSkipCalculated.AutoSize = true;
            this.tlpMapControls.SetColumnSpan(this.cbSkipCalculated, 2);
            this.cbSkipCalculated.Location = new System.Drawing.Point(3, 237);
            this.cbSkipCalculated.Name = "cbSkipCalculated";
            this.cbSkipCalculated.Size = new System.Drawing.Size(215, 19);
            this.cbSkipCalculated.TabIndex = 14;
            this.cbSkipCalculated.Text = "Skip calculated objects (i.e. the Sun)";
            this.cbSkipCalculated.UseVisualStyleBackColor = true;
            this.cbSkipCalculated.CheckedChanged += new System.EventHandler(this.cbSkipCalculated_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMapControls.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.cbAboveHorizonValue);
            this.panel4.Controls.Add(this.lbAboveHorizon);
            this.panel4.Controls.Add(this.lbHorizontalYValue);
            this.panel4.Controls.Add(this.lbHorizontalCoordinates);
            this.panel4.Controls.Add(this.lbRaDec);
            this.panel4.Controls.Add(this.lbObjectName);
            this.panel4.Controls.Add(this.lbHorizontalXValue);
            this.panel4.Controls.Add(this.lbDeclinationValue);
            this.panel4.Controls.Add(this.lbRightAscensionValue);
            this.panel4.Controls.Add(this.lbObjectNameValue);
            this.panel4.Location = new System.Drawing.Point(3, 397);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 119);
            this.panel4.TabIndex = 15;
            // 
            // cbAboveHorizonValue
            // 
            this.cbAboveHorizonValue.AutoSize = true;
            this.cbAboveHorizonValue.Location = new System.Drawing.Point(15, 96);
            this.cbAboveHorizonValue.Name = "cbAboveHorizonValue";
            this.cbAboveHorizonValue.Size = new System.Drawing.Size(15, 14);
            this.cbAboveHorizonValue.TabIndex = 9;
            this.cbAboveHorizonValue.UseVisualStyleBackColor = true;
            // 
            // lbAboveHorizon
            // 
            this.lbAboveHorizon.AutoSize = true;
            this.lbAboveHorizon.Location = new System.Drawing.Point(3, 78);
            this.lbAboveHorizon.Name = "lbAboveHorizon";
            this.lbAboveHorizon.Size = new System.Drawing.Size(84, 15);
            this.lbAboveHorizon.TabIndex = 8;
            this.lbAboveHorizon.Text = "Above horizon";
            // 
            // lbHorizontalYValue
            // 
            this.lbHorizontalYValue.AutoSize = true;
            this.lbHorizontalYValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHorizontalYValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbHorizontalYValue.Location = new System.Drawing.Point(101, 63);
            this.lbHorizontalYValue.Name = "lbHorizontalYValue";
            this.lbHorizontalYValue.Size = new System.Drawing.Size(12, 15);
            this.lbHorizontalYValue.TabIndex = 7;
            this.lbHorizontalYValue.Text = "-";
            // 
            // lbHorizontalCoordinates
            // 
            this.lbHorizontalCoordinates.AutoSize = true;
            this.lbHorizontalCoordinates.Location = new System.Drawing.Point(3, 48);
            this.lbHorizontalCoordinates.Name = "lbHorizontalCoordinates";
            this.lbHorizontalCoordinates.Size = new System.Drawing.Size(184, 15);
            this.lbHorizontalCoordinates.TabIndex = 6;
            this.lbHorizontalCoordinates.Text = "Horizontal coordinates in degrees";
            // 
            // lbRaDec
            // 
            this.lbRaDec.AutoSize = true;
            this.lbRaDec.Location = new System.Drawing.Point(3, 15);
            this.lbRaDec.Name = "lbRaDec";
            this.lbRaDec.Size = new System.Drawing.Size(155, 15);
            this.lbRaDec.TabIndex = 5;
            this.lbRaDec.Text = "Right ascension & declination";
            // 
            // lbObjectName
            // 
            this.lbObjectName.AutoSize = true;
            this.lbObjectName.Location = new System.Drawing.Point(3, 0);
            this.lbObjectName.Name = "lbObjectName";
            this.lbObjectName.Size = new System.Drawing.Size(75, 15);
            this.lbObjectName.TabIndex = 4;
            this.lbObjectName.Text = "Object name";
            // 
            // lbHorizontalXValue
            // 
            this.lbHorizontalXValue.AutoSize = true;
            this.lbHorizontalXValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHorizontalXValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbHorizontalXValue.Location = new System.Drawing.Point(15, 63);
            this.lbHorizontalXValue.Name = "lbHorizontalXValue";
            this.lbHorizontalXValue.Size = new System.Drawing.Size(12, 15);
            this.lbHorizontalXValue.TabIndex = 3;
            this.lbHorizontalXValue.Text = "-";
            // 
            // lbDeclinationValue
            // 
            this.lbDeclinationValue.AutoSize = true;
            this.lbDeclinationValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDeclinationValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbDeclinationValue.Location = new System.Drawing.Point(101, 33);
            this.lbDeclinationValue.Name = "lbDeclinationValue";
            this.lbDeclinationValue.Size = new System.Drawing.Size(12, 15);
            this.lbDeclinationValue.TabIndex = 2;
            this.lbDeclinationValue.Text = "-";
            // 
            // lbRightAscensionValue
            // 
            this.lbRightAscensionValue.AutoSize = true;
            this.lbRightAscensionValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRightAscensionValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbRightAscensionValue.Location = new System.Drawing.Point(15, 33);
            this.lbRightAscensionValue.Name = "lbRightAscensionValue";
            this.lbRightAscensionValue.Size = new System.Drawing.Size(12, 15);
            this.lbRightAscensionValue.TabIndex = 1;
            this.lbRightAscensionValue.Text = "-";
            // 
            // lbObjectNameValue
            // 
            this.lbObjectNameValue.AutoSize = true;
            this.lbObjectNameValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbObjectNameValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbObjectNameValue.Location = new System.Drawing.Point(119, 0);
            this.lbObjectNameValue.Name = "lbObjectNameValue";
            this.lbObjectNameValue.Size = new System.Drawing.Size(12, 15);
            this.lbObjectNameValue.TabIndex = 0;
            this.lbObjectNameValue.Text = "-";
            // 
            // cbDrawCrossHair
            // 
            this.cbDrawCrossHair.AutoSize = true;
            this.cbDrawCrossHair.Location = new System.Drawing.Point(3, 262);
            this.cbDrawCrossHair.Name = "cbDrawCrossHair";
            this.cbDrawCrossHair.Size = new System.Drawing.Size(106, 19);
            this.cbDrawCrossHair.TabIndex = 16;
            this.cbDrawCrossHair.Text = "Draw cross hair";
            this.cbDrawCrossHair.UseVisualStyleBackColor = true;
            this.cbDrawCrossHair.CheckedChanged += new System.EventHandler(this.cbDrawCrossHair_CheckedChanged);
            // 
            // panel5
            // 
            this.tlpMapControls.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.lbHour1);
            this.panel5.Controls.Add(this.btHourNext);
            this.panel5.Controls.Add(this.btHourPrevious);
            this.panel5.Controls.Add(this.btPlayPause);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 106);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(244, 28);
            this.panel5.TabIndex = 17;
            // 
            // lbHour1
            // 
            this.lbHour1.AutoSize = true;
            this.lbHour1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHour1.Location = new System.Drawing.Point(106, 4);
            this.lbHour1.Name = "lbHour1";
            this.lbHour1.Size = new System.Drawing.Size(30, 21);
            this.lbHour1.TabIndex = 9;
            this.lbHour1.Text = "±1";
            // 
            // btHourNext
            // 
            this.btHourNext.Checked = false;
            this.btHourNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btHourNext.DisabledColor = System.Drawing.Color.LightGray;
            this.btHourNext.ImageCheckedSvg = "ic_fluent_pause_48_filled";
            this.btHourNext.ImageColor = System.Drawing.Color.SteelBlue;
            this.btHourNext.ImageColorChecked = System.Drawing.Color.SteelBlue;
            this.btHourNext.ImageSvg = "ic_fluent_arrow_next_24_filled";
            this.btHourNext.IsCheckedButton = false;
            this.btHourNext.Location = new System.Drawing.Point(134, 3);
            this.btHourNext.Name = "btHourNext";
            this.btHourNext.Size = new System.Drawing.Size(34, 22);
            this.btHourNext.TabIndex = 8;
            this.btHourNext.Click += new System.EventHandler(this.AddDecHour_Click);
            // 
            // btHourPrevious
            // 
            this.btHourPrevious.Checked = false;
            this.btHourPrevious.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btHourPrevious.DisabledColor = System.Drawing.Color.LightGray;
            this.btHourPrevious.ImageCheckedSvg = "ic_fluent_pause_48_filled";
            this.btHourPrevious.ImageColor = System.Drawing.Color.SteelBlue;
            this.btHourPrevious.ImageColorChecked = System.Drawing.Color.SteelBlue;
            this.btHourPrevious.ImageSvg = "ic_fluent_arrow_previous_24_filled";
            this.btHourPrevious.IsCheckedButton = false;
            this.btHourPrevious.Location = new System.Drawing.Point(75, 3);
            this.btHourPrevious.Name = "btHourPrevious";
            this.btHourPrevious.Size = new System.Drawing.Size(34, 22);
            this.btHourPrevious.TabIndex = 7;
            this.btHourPrevious.Click += new System.EventHandler(this.AddDecHour_Click);
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
            this.btPlayPause.Location = new System.Drawing.Point(8, 3);
            this.btPlayPause.Name = "btPlayPause";
            this.btPlayPause.Size = new System.Drawing.Size(25, 22);
            this.btPlayPause.TabIndex = 6;
            this.btPlayPause.CheckedChanged += new System.EventHandler<StarMap2D.Controls.WinForms.EventArguments.CheckedChangeEventArguments>(this.btPlayPause_CheckedChanged);
            // 
            // FormSkyMap2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 804);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSkyMap2D";
            this.Text = "Sky Map";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSkyMap2D_FormClosed);
            this.tlpMain.ResumeLayout(false);
            this.tlpMapControls.ResumeLayout(false);
            this.tlpMapControls.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).EndInit();
            this.pnDateTime.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private Panel panel1;
        private ComboBox cmbTimeType;
        private NumericUpDown numericUpDown1;
        private Label lbSpeedPerSecond;
        private Controls.WinForms.ImageButton btRevertSpeed;
        private Panel panel2;
        private Controls.WinForms.CompassView compassView1;
        private CheckBox cbInvertEastWest;
        private Panel panel3;
        private ComboBox cmbJumpToLocation;
        private Controls.WinForms.ImageButton btResetLocation;
        private Label lbJumpToLocation;
        private CheckBox cbShowConstellationBorders;
        private CheckBox cbConstellationLines;
        private CheckBox cbConstellationNames;
        private CheckBox cbSkipCalculated;
        private Label lbLongitude;
        private NumericUpDown nudLongitude;
        private Label lbLatitude;
        private NumericUpDown nudLatitude;
        private Panel panel4;
        private Label lbObjectNameValue;
        private Label lbDeclinationValue;
        private Label lbRightAscensionValue;
        private Label lbHorizontalXValue;
        private Label lbHorizontalYValue;
        private Label lbHorizontalCoordinates;
        private Label lbRaDec;
        private Label lbObjectName;
        private CheckBox cbAboveHorizonValue;
        private Label lbAboveHorizon;
        private CheckBox cbDrawCrossHair;
        private Panel panel5;
        private Label lbHour1;
        private Controls.WinForms.ImageButton btHourNext;
        private Controls.WinForms.ImageButton btHourPrevious;
    }
}