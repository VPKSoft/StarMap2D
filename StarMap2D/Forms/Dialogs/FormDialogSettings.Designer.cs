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
            this.tpCommon = new System.Windows.Forms.TabPage();
            this.cbDrawCrossHair = new System.Windows.Forms.CheckBox();
            this.nudCrossHairSize = new System.Windows.Forms.NumericUpDown();
            this.lbCrossHairSize = new System.Windows.Forms.Label();
            this.lbSelectLanguageDescription = new System.Windows.Forms.Label();
            this.cmbSelectLanguageValue = new System.Windows.Forms.ComboBox();
            this.cbDrawConstellationBorders = new System.Windows.Forms.CheckBox();
            this.cbDrawConstellationLabels = new System.Windows.Forms.CheckBox();
            this.cbDrawConstellations = new System.Windows.Forms.CheckBox();
            this.cbInvertEastWest = new System.Windows.Forms.CheckBox();
            this.lbSelectLocation = new System.Windows.Forms.Label();
            this.cmbSelectLocation = new System.Windows.Forms.ComboBox();
            this.nudLongitude = new System.Windows.Forms.NumericUpDown();
            this.lbLongitude = new System.Windows.Forms.Label();
            this.nudLatitude = new System.Windows.Forms.NumericUpDown();
            this.lbLatitude = new System.Windows.Forms.Label();
            this.tbLocationName = new System.Windows.Forms.TextBox();
            this.lbLocationName = new System.Windows.Forms.Label();
            this.tabColorSettings = new System.Windows.Forms.TabPage();
            this.pnCrossHairColor = new System.Windows.Forms.Panel();
            this.lbCrossHairColor = new System.Windows.Forms.Label();
            this.pnMapTextColor = new System.Windows.Forms.Panel();
            this.lbMapTextColor = new System.Windows.Forms.Label();
            this.pnMapSurroundingsColor = new System.Windows.Forms.Panel();
            this.lbMapSurroundingsColor = new System.Windows.Forms.Label();
            this.pnMapCircleColor = new System.Windows.Forms.Panel();
            this.lbMapCircleColor = new System.Windows.Forms.Label();
            this.pnConstellationBorderLineColor = new System.Windows.Forms.Panel();
            this.lbConstellationBorderLineColor = new System.Windows.Forms.Label();
            this.ceColor = new Cyotek.Windows.Forms.ColorEditor();
            this.cwColor = new Cyotek.Windows.Forms.ColorWheel();
            this.pnConstellationLineColor = new System.Windows.Forms.Panel();
            this.lbConstellationLineColor = new System.Windows.Forms.Label();
            this.tabStarMagnitudeSettings = new System.Windows.Forms.TabPage();
            this.nudMagnitudeMinimum = new System.Windows.Forms.NumericUpDown();
            this.lbMagnitudeMinimum = new System.Windows.Forms.Label();
            this.nudMagnitudeMaximum = new System.Windows.Forms.NumericUpDown();
            this.lbMagnitudeMaximum = new System.Windows.Forms.Label();
            this.lbMagnitudeLimits = new System.Windows.Forms.Label();
            this.starMagnitudeEditor1 = new StarMap2D.Controls.WinForms.StarMagnitudeEditor();
            this.tabObjectSymbols = new System.Windows.Forms.TabPage();
            this.btResetSymbols = new System.Windows.Forms.Button();
            this.solarSystemObjectConfigurator1 = new StarMap2D.Controls.WinForms.SolarSystemObjectConfigurator();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tcSettings.SuspendLayout();
            this.tpCommon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossHairSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).BeginInit();
            this.tabColorSettings.SuspendLayout();
            this.tabStarMagnitudeSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagnitudeMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagnitudeMaximum)).BeginInit();
            this.tabObjectSymbols.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSettings
            // 
            this.tcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcSettings.Controls.Add(this.tpCommon);
            this.tcSettings.Controls.Add(this.tabColorSettings);
            this.tcSettings.Controls.Add(this.tabStarMagnitudeSettings);
            this.tcSettings.Controls.Add(this.tabObjectSymbols);
            this.tcSettings.Location = new System.Drawing.Point(12, 12);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(696, 493);
            this.tcSettings.TabIndex = 1;
            // 
            // tpCommon
            // 
            this.tpCommon.Controls.Add(this.cbDrawCrossHair);
            this.tpCommon.Controls.Add(this.nudCrossHairSize);
            this.tpCommon.Controls.Add(this.lbCrossHairSize);
            this.tpCommon.Controls.Add(this.lbSelectLanguageDescription);
            this.tpCommon.Controls.Add(this.cmbSelectLanguageValue);
            this.tpCommon.Controls.Add(this.cbDrawConstellationBorders);
            this.tpCommon.Controls.Add(this.cbDrawConstellationLabels);
            this.tpCommon.Controls.Add(this.cbDrawConstellations);
            this.tpCommon.Controls.Add(this.cbInvertEastWest);
            this.tpCommon.Controls.Add(this.lbSelectLocation);
            this.tpCommon.Controls.Add(this.cmbSelectLocation);
            this.tpCommon.Controls.Add(this.nudLongitude);
            this.tpCommon.Controls.Add(this.lbLongitude);
            this.tpCommon.Controls.Add(this.nudLatitude);
            this.tpCommon.Controls.Add(this.lbLatitude);
            this.tpCommon.Controls.Add(this.tbLocationName);
            this.tpCommon.Controls.Add(this.lbLocationName);
            this.tpCommon.Location = new System.Drawing.Point(4, 24);
            this.tpCommon.Name = "tpCommon";
            this.tpCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tpCommon.Size = new System.Drawing.Size(688, 465);
            this.tpCommon.TabIndex = 0;
            this.tpCommon.Text = "Common";
            this.tpCommon.UseVisualStyleBackColor = true;
            // 
            // cbDrawCrossHair
            // 
            this.cbDrawCrossHair.AutoSize = true;
            this.cbDrawCrossHair.Location = new System.Drawing.Point(7, 247);
            this.cbDrawCrossHair.Name = "cbDrawCrossHair";
            this.cbDrawCrossHair.Size = new System.Drawing.Size(106, 19);
            this.cbDrawCrossHair.TabIndex = 32;
            this.cbDrawCrossHair.Text = "Draw cross hair";
            this.cbDrawCrossHair.UseVisualStyleBackColor = true;
            // 
            // nudCrossHairSize
            // 
            this.nudCrossHairSize.Location = new System.Drawing.Point(226, 266);
            this.nudCrossHairSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCrossHairSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCrossHairSize.Name = "nudCrossHairSize";
            this.nudCrossHairSize.Size = new System.Drawing.Size(81, 23);
            this.nudCrossHairSize.TabIndex = 31;
            this.nudCrossHairSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lbCrossHairSize
            // 
            this.lbCrossHairSize.AutoSize = true;
            this.lbCrossHairSize.Location = new System.Drawing.Point(226, 248);
            this.lbCrossHairSize.Name = "lbCrossHairSize";
            this.lbCrossHairSize.Size = new System.Drawing.Size(81, 15);
            this.lbCrossHairSize.TabIndex = 30;
            this.lbCrossHairSize.Text = "Cross hair size";
            // 
            // lbSelectLanguageDescription
            // 
            this.lbSelectLanguageDescription.AutoSize = true;
            this.lbSelectLanguageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectLanguageDescription.Location = new System.Drawing.Point(5, 300);
            this.lbSelectLanguageDescription.Margin = new System.Windows.Forms.Padding(20, 17, 20, 17);
            this.lbSelectLanguageDescription.Name = "lbSelectLanguageDescription";
            this.lbSelectLanguageDescription.Size = new System.Drawing.Size(153, 13);
            this.lbSelectLanguageDescription.TabIndex = 29;
            this.lbSelectLanguageDescription.Text = "Language (a restart is required)";
            this.lbSelectLanguageDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSelectLanguageValue
            // 
            this.cmbSelectLanguageValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSelectLanguageValue.DisplayMember = "DisplayName";
            this.cmbSelectLanguageValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectLanguageValue.FormattingEnabled = true;
            this.cmbSelectLanguageValue.Location = new System.Drawing.Point(6, 320);
            this.cmbSelectLanguageValue.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.cmbSelectLanguageValue.Name = "cmbSelectLanguageValue";
            this.cmbSelectLanguageValue.Size = new System.Drawing.Size(500, 23);
            this.cmbSelectLanguageValue.TabIndex = 28;
            this.cmbSelectLanguageValue.ValueMember = "Name";
            // 
            // cbDrawConstellationBorders
            // 
            this.cbDrawConstellationBorders.AutoSize = true;
            this.cbDrawConstellationBorders.Location = new System.Drawing.Point(6, 222);
            this.cbDrawConstellationBorders.Name = "cbDrawConstellationBorders";
            this.cbDrawConstellationBorders.Size = new System.Drawing.Size(167, 19);
            this.cbDrawConstellationBorders.TabIndex = 13;
            this.cbDrawConstellationBorders.Text = "Draw constellation borders";
            this.cbDrawConstellationBorders.UseVisualStyleBackColor = true;
            // 
            // cbDrawConstellationLabels
            // 
            this.cbDrawConstellationLabels.AutoSize = true;
            this.cbDrawConstellationLabels.Location = new System.Drawing.Point(24, 197);
            this.cbDrawConstellationLabels.Name = "cbDrawConstellationLabels";
            this.cbDrawConstellationLabels.Size = new System.Drawing.Size(157, 19);
            this.cbDrawConstellationLabels.TabIndex = 12;
            this.cbDrawConstellationLabels.Text = "Draw constellation labels";
            this.cbDrawConstellationLabels.UseVisualStyleBackColor = true;
            // 
            // cbDrawConstellations
            // 
            this.cbDrawConstellations.AutoSize = true;
            this.cbDrawConstellations.Location = new System.Drawing.Point(6, 172);
            this.cbDrawConstellations.Name = "cbDrawConstellations";
            this.cbDrawConstellations.Size = new System.Drawing.Size(129, 19);
            this.cbDrawConstellations.TabIndex = 11;
            this.cbDrawConstellations.Text = "Draw constellations";
            this.cbDrawConstellations.UseVisualStyleBackColor = true;
            this.cbDrawConstellations.CheckedChanged += new System.EventHandler(this.cbDrawConstellations_CheckedChanged);
            // 
            // cbInvertEastWest
            // 
            this.cbInvertEastWest.AutoSize = true;
            this.cbInvertEastWest.Location = new System.Drawing.Point(7, 147);
            this.cbInvertEastWest.Name = "cbInvertEastWest";
            this.cbInvertEastWest.Size = new System.Drawing.Size(193, 19);
            this.cbInvertEastWest.TabIndex = 10;
            this.cbInvertEastWest.Text = "Invert east-west axis of the map";
            this.cbInvertEastWest.UseVisualStyleBackColor = true;
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
            this.tabColorSettings.Controls.Add(this.pnCrossHairColor);
            this.tabColorSettings.Controls.Add(this.lbCrossHairColor);
            this.tabColorSettings.Controls.Add(this.pnMapTextColor);
            this.tabColorSettings.Controls.Add(this.lbMapTextColor);
            this.tabColorSettings.Controls.Add(this.pnMapSurroundingsColor);
            this.tabColorSettings.Controls.Add(this.lbMapSurroundingsColor);
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
            // pnCrossHairColor
            // 
            this.pnCrossHairColor.BackColor = System.Drawing.Color.Lime;
            this.pnCrossHairColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnCrossHairColor.Location = new System.Drawing.Point(223, 136);
            this.pnCrossHairColor.Margin = new System.Windows.Forms.Padding(0);
            this.pnCrossHairColor.Name = "pnCrossHairColor";
            this.pnCrossHairColor.Size = new System.Drawing.Size(113, 23);
            this.pnCrossHairColor.TabIndex = 14;
            this.pnCrossHairColor.Tag = "CrossHairColor";
            this.pnCrossHairColor.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // lbCrossHairColor
            // 
            this.lbCrossHairColor.AutoSize = true;
            this.lbCrossHairColor.Location = new System.Drawing.Point(6, 140);
            this.lbCrossHairColor.Name = "lbCrossHairColor";
            this.lbCrossHairColor.Size = new System.Drawing.Size(183, 15);
            this.lbCrossHairColor.TabIndex = 13;
            this.lbCrossHairColor.Text = "Map text color (object labels, etc)";
            // 
            // pnMapTextColor
            // 
            this.pnMapTextColor.BackColor = System.Drawing.Color.DarkViolet;
            this.pnMapTextColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMapTextColor.Location = new System.Drawing.Point(223, 110);
            this.pnMapTextColor.Margin = new System.Windows.Forms.Padding(0);
            this.pnMapTextColor.Name = "pnMapTextColor";
            this.pnMapTextColor.Size = new System.Drawing.Size(113, 23);
            this.pnMapTextColor.TabIndex = 12;
            this.pnMapTextColor.Tag = "MapTextColor";
            this.pnMapTextColor.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // lbMapTextColor
            // 
            this.lbMapTextColor.AutoSize = true;
            this.lbMapTextColor.Location = new System.Drawing.Point(6, 114);
            this.lbMapTextColor.Name = "lbMapTextColor";
            this.lbMapTextColor.Size = new System.Drawing.Size(183, 15);
            this.lbMapTextColor.TabIndex = 11;
            this.lbMapTextColor.Text = "Map text color (object labels, etc)";
            // 
            // pnMapSurroundingsColor
            // 
            this.pnMapSurroundingsColor.BackColor = System.Drawing.SystemColors.Control;
            this.pnMapSurroundingsColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMapSurroundingsColor.Location = new System.Drawing.Point(223, 84);
            this.pnMapSurroundingsColor.Margin = new System.Windows.Forms.Padding(0);
            this.pnMapSurroundingsColor.Name = "pnMapSurroundingsColor";
            this.pnMapSurroundingsColor.Size = new System.Drawing.Size(113, 23);
            this.pnMapSurroundingsColor.TabIndex = 10;
            this.pnMapSurroundingsColor.Tag = "MapSurroundingsColor";
            this.pnMapSurroundingsColor.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // lbMapSurroundingsColor
            // 
            this.lbMapSurroundingsColor.AutoSize = true;
            this.lbMapSurroundingsColor.Location = new System.Drawing.Point(6, 88);
            this.lbMapSurroundingsColor.Name = "lbMapSurroundingsColor";
            this.lbMapSurroundingsColor.Size = new System.Drawing.Size(137, 15);
            this.lbMapSurroundingsColor.TabIndex = 9;
            this.lbMapSurroundingsColor.Text = "Map surroundings color:";
            this.lbMapSurroundingsColor.Click += new System.EventHandler(this.colorPanel_Click);
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
            // tabStarMagnitudeSettings
            // 
            this.tabStarMagnitudeSettings.Controls.Add(this.nudMagnitudeMinimum);
            this.tabStarMagnitudeSettings.Controls.Add(this.lbMagnitudeMinimum);
            this.tabStarMagnitudeSettings.Controls.Add(this.nudMagnitudeMaximum);
            this.tabStarMagnitudeSettings.Controls.Add(this.lbMagnitudeMaximum);
            this.tabStarMagnitudeSettings.Controls.Add(this.lbMagnitudeLimits);
            this.tabStarMagnitudeSettings.Controls.Add(this.starMagnitudeEditor1);
            this.tabStarMagnitudeSettings.Location = new System.Drawing.Point(4, 24);
            this.tabStarMagnitudeSettings.Name = "tabStarMagnitudeSettings";
            this.tabStarMagnitudeSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabStarMagnitudeSettings.Size = new System.Drawing.Size(688, 465);
            this.tabStarMagnitudeSettings.TabIndex = 2;
            this.tabStarMagnitudeSettings.Text = "Star magnitudes";
            this.tabStarMagnitudeSettings.UseVisualStyleBackColor = true;
            // 
            // nudMagnitudeMinimum
            // 
            this.nudMagnitudeMinimum.DecimalPlaces = 2;
            this.nudMagnitudeMinimum.Location = new System.Drawing.Point(87, 374);
            this.nudMagnitudeMinimum.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.nudMagnitudeMinimum.Name = "nudMagnitudeMinimum";
            this.nudMagnitudeMinimum.Size = new System.Drawing.Size(120, 23);
            this.nudMagnitudeMinimum.TabIndex = 5;
            this.nudMagnitudeMinimum.Value = new decimal(new int[] {
            55,
            0,
            0,
            65536});
            // 
            // lbMagnitudeMinimum
            // 
            this.lbMagnitudeMinimum.AutoSize = true;
            this.lbMagnitudeMinimum.Location = new System.Drawing.Point(6, 376);
            this.lbMagnitudeMinimum.Name = "lbMagnitudeMinimum";
            this.lbMagnitudeMinimum.Size = new System.Drawing.Size(60, 15);
            this.lbMagnitudeMinimum.TabIndex = 4;
            this.lbMagnitudeMinimum.Text = "Minimum";
            // 
            // nudMagnitudeMaximum
            // 
            this.nudMagnitudeMaximum.DecimalPlaces = 2;
            this.nudMagnitudeMaximum.Location = new System.Drawing.Point(87, 345);
            this.nudMagnitudeMaximum.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.nudMagnitudeMaximum.Name = "nudMagnitudeMaximum";
            this.nudMagnitudeMaximum.Size = new System.Drawing.Size(120, 23);
            this.nudMagnitudeMaximum.TabIndex = 3;
            this.nudMagnitudeMaximum.Value = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            // 
            // lbMagnitudeMaximum
            // 
            this.lbMagnitudeMaximum.AutoSize = true;
            this.lbMagnitudeMaximum.Location = new System.Drawing.Point(6, 347);
            this.lbMagnitudeMaximum.Name = "lbMagnitudeMaximum";
            this.lbMagnitudeMaximum.Size = new System.Drawing.Size(62, 15);
            this.lbMagnitudeMaximum.TabIndex = 2;
            this.lbMagnitudeMaximum.Text = "Maximum";
            // 
            // lbMagnitudeLimits
            // 
            this.lbMagnitudeLimits.AutoSize = true;
            this.lbMagnitudeLimits.Location = new System.Drawing.Point(6, 320);
            this.lbMagnitudeLimits.Name = "lbMagnitudeLimits";
            this.lbMagnitudeLimits.Size = new System.Drawing.Size(97, 15);
            this.lbMagnitudeLimits.TabIndex = 1;
            this.lbMagnitudeLimits.Text = "Magnitude limits";
            // 
            // starMagnitudeEditor1
            // 
            this.starMagnitudeEditor1.Location = new System.Drawing.Point(6, 6);
            this.starMagnitudeEditor1.MagnitudeValueFormat = "Selected magnitude: {0}";
            this.starMagnitudeEditor1.Name = "starMagnitudeEditor1";
            this.starMagnitudeEditor1.SelectedMagnitude = 2147483647;
            this.starMagnitudeEditor1.Size = new System.Drawing.Size(580, 311);
            this.starMagnitudeEditor1.StarMagnitudeColors = "";
            this.starMagnitudeEditor1.StarMagnitudes = "";
            this.starMagnitudeEditor1.TabIndex = 0;
            // 
            // tabObjectSymbols
            // 
            this.tabObjectSymbols.Controls.Add(this.btResetSymbols);
            this.tabObjectSymbols.Controls.Add(this.solarSystemObjectConfigurator1);
            this.tabObjectSymbols.Location = new System.Drawing.Point(4, 24);
            this.tabObjectSymbols.Name = "tabObjectSymbols";
            this.tabObjectSymbols.Padding = new System.Windows.Forms.Padding(3);
            this.tabObjectSymbols.Size = new System.Drawing.Size(688, 465);
            this.tabObjectSymbols.TabIndex = 3;
            this.tabObjectSymbols.Text = "Known object symbols";
            this.tabObjectSymbols.UseVisualStyleBackColor = true;
            // 
            // btResetSymbols
            // 
            this.btResetSymbols.Location = new System.Drawing.Point(6, 366);
            this.btResetSymbols.Name = "btResetSymbols";
            this.btResetSymbols.Size = new System.Drawing.Size(75, 23);
            this.btResetSymbols.TabIndex = 1;
            this.btResetSymbols.Text = "Reset";
            this.btResetSymbols.UseVisualStyleBackColor = true;
            this.btResetSymbols.Click += new System.EventHandler(this.btResetSymbols_Click);
            // 
            // solarSystemObjectConfigurator1
            // 
            this.solarSystemObjectConfigurator1.Location = new System.Drawing.Point(3, 3);
            this.solarSystemObjectConfigurator1.MapBackgroundColor = System.Drawing.SystemColors.Window;
            this.solarSystemObjectConfigurator1.Margin = new System.Windows.Forms.Padding(0);
            this.solarSystemObjectConfigurator1.Name = "solarSystemObjectConfigurator1";
            this.solarSystemObjectConfigurator1.Size = new System.Drawing.Size(594, 360);
            this.solarSystemObjectConfigurator1.TabIndex = 0;
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
            this.tpCommon.ResumeLayout(false);
            this.tpCommon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrossHairSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).EndInit();
            this.tabColorSettings.ResumeLayout(false);
            this.tabColorSettings.PerformLayout();
            this.tabStarMagnitudeSettings.ResumeLayout(false);
            this.tabStarMagnitudeSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagnitudeMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagnitudeMaximum)).EndInit();
            this.tabObjectSymbols.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcSettings;
        private TabPage tpCommon;
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
        private Panel pnMapSurroundingsColor;
        private Label lbMapSurroundingsColor;
        private TabPage tabStarMagnitudeSettings;
        private StarMap2D.Controls.WinForms.StarMagnitudeEditor starMagnitudeEditor1;
        private NumericUpDown nudMagnitudeMinimum;
        private Label lbMagnitudeMinimum;
        private NumericUpDown nudMagnitudeMaximum;
        private Label lbMagnitudeMaximum;
        private Label lbMagnitudeLimits;
        private TabPage tabObjectSymbols;
        private Controls.WinForms.SolarSystemObjectConfigurator solarSystemObjectConfigurator1;
        private Button btResetSymbols;
        private CheckBox cbInvertEastWest;
        private Panel pnMapTextColor;
        private Label lbMapTextColor;
        private CheckBox cbDrawConstellationBorders;
        private CheckBox cbDrawConstellationLabels;
        private CheckBox cbDrawConstellations;
        private Label lbSelectLanguageDescription;
        private ComboBox cmbSelectLanguageValue;
        private Panel pnCrossHairColor;
        private Label lbCrossHairColor;
        private CheckBox cbDrawCrossHair;
        private NumericUpDown nudCrossHairSize;
        private Label lbCrossHairSize;
    }
}