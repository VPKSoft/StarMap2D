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
    partial class FormPlanetDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanetDetails));
            this.cmbPlanetSelection = new System.Windows.Forms.ComboBox();
            this.lbPlanetSelection = new System.Windows.Forms.Label();
            this.lbMassKg = new System.Windows.Forms.Label();
            this.lbDiameter = new System.Windows.Forms.Label();
            this.tbMassKgValue = new System.Windows.Forms.TextBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbOrbitalInclination = new System.Windows.Forms.Label();
            this.tbOrbitalVelocityValue = new System.Windows.Forms.TextBox();
            this.lbOrbitalVelocity = new System.Windows.Forms.Label();
            this.lbOrbitalPeriod = new System.Windows.Forms.Label();
            this.tbDiameterValue = new System.Windows.Forms.TextBox();
            this.tbDensityValue = new System.Windows.Forms.TextBox();
            this.tbGravityValue = new System.Windows.Forms.TextBox();
            this.lbDensity = new System.Windows.Forms.Label();
            this.lbGravity = new System.Windows.Forms.Label();
            this.lbAphelion = new System.Windows.Forms.Label();
            this.tbAphelionValue = new System.Windows.Forms.TextBox();
            this.lbPerihelion = new System.Windows.Forms.Label();
            this.tbPerihelionValue = new System.Windows.Forms.TextBox();
            this.tbDistanceFromSunValue = new System.Windows.Forms.TextBox();
            this.lbDistanceFromSun = new System.Windows.Forms.Label();
            this.lbLengthOfDay = new System.Windows.Forms.Label();
            this.tbLengthOfDayValue = new System.Windows.Forms.TextBox();
            this.lbRotationPeriod = new System.Windows.Forms.Label();
            this.tbRotationPeriodValue = new System.Windows.Forms.TextBox();
            this.lbEscapeVelocity = new System.Windows.Forms.Label();
            this.tbEscapeVelocityValue = new System.Windows.Forms.TextBox();
            this.tbOrbitalPeriodValue = new System.Windows.Forms.TextBox();
            this.lbOrbitalEccentricity = new System.Windows.Forms.Label();
            this.lbObliquityToOrbit = new System.Windows.Forms.Label();
            this.lbMeanTemperature = new System.Windows.Forms.Label();
            this.tbOrbitalInclinationValue = new System.Windows.Forms.TextBox();
            this.tblbObliquityToOrbitValue = new System.Windows.Forms.TextBox();
            this.tbMeanTemperatureValue = new System.Windows.Forms.TextBox();
            this.tbOrbitalEccentricityValue = new System.Windows.Forms.TextBox();
            this.lbSurfacePressure = new System.Windows.Forms.Label();
            this.lbNumberOfMoons = new System.Windows.Forms.Label();
            this.lbRingSystem = new System.Windows.Forms.Label();
            this.lbGlobalMagneticField = new System.Windows.Forms.Label();
            this.tbSurfacePressureValue = new System.Windows.Forms.TextBox();
            this.tbNumberOfMoonsValue = new System.Windows.Forms.TextBox();
            this.tbRingSystemValue = new System.Windows.Forms.TextBox();
            this.tbGlobalMagneticFieldValue = new System.Windows.Forms.TextBox();
            this.lbRightAscension = new System.Windows.Forms.Label();
            this.lbDeclination = new System.Windows.Forms.Label();
            this.lbHorizontalX = new System.Windows.Forms.Label();
            this.lbHorizontalY = new System.Windows.Forms.Label();
            this.tbRightAscensionValue = new System.Windows.Forms.TextBox();
            this.tbDeclinationValue = new System.Windows.Forms.TextBox();
            this.tbHorizontalXValue = new System.Windows.Forms.TextBox();
            this.tbHorizontalYValue = new System.Windows.Forms.TextBox();
            this.lbAboveHorizon = new System.Windows.Forms.Label();
            this.tbAboveHorizonValue = new System.Windows.Forms.TextBox();
            this.lbAdditionalInformation = new System.Windows.Forms.Label();
            this.lbLongitude = new System.Windows.Forms.Label();
            this.nudLongitude = new System.Windows.Forms.NumericUpDown();
            this.lbLatitude = new System.Windows.Forms.Label();
            this.nudLatitude = new System.Windows.Forms.NumericUpDown();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.dtpMapDateTime = new System.Windows.Forms.DateTimePicker();
            this.btCopyAllToClipboard = new StarMap2D.Controls.WinForms.ImageButton();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPlanetSelection
            // 
            this.cmbPlanetSelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPlanetSelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPlanetSelection.FormattingEnabled = true;
            this.cmbPlanetSelection.Location = new System.Drawing.Point(125, 12);
            this.cmbPlanetSelection.Name = "cmbPlanetSelection";
            this.cmbPlanetSelection.Size = new System.Drawing.Size(284, 23);
            this.cmbPlanetSelection.TabIndex = 0;
            this.cmbPlanetSelection.SelectedIndexChanged += new System.EventHandler(this.cmbPlanetSelection_SelectedIndexChanged);
            // 
            // lbPlanetSelection
            // 
            this.lbPlanetSelection.AutoSize = true;
            this.lbPlanetSelection.Location = new System.Drawing.Point(12, 15);
            this.lbPlanetSelection.Name = "lbPlanetSelection";
            this.lbPlanetSelection.Size = new System.Drawing.Size(40, 15);
            this.lbPlanetSelection.TabIndex = 1;
            this.lbPlanetSelection.Text = "Planet";
            // 
            // lbMassKg
            // 
            this.lbMassKg.AutoSize = true;
            this.lbMassKg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbMassKg.Location = new System.Drawing.Point(3, 80);
            this.lbMassKg.Name = "lbMassKg";
            this.lbMassKg.Size = new System.Drawing.Size(81, 15);
            this.lbMassKg.TabIndex = 2;
            this.lbMassKg.Tag = "9";
            this.lbMassKg.Text = "Mass (10²⁴ kg)";
            // 
            // lbDiameter
            // 
            this.lbDiameter.AutoSize = true;
            this.lbDiameter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbDiameter.Location = new System.Drawing.Point(197, 80);
            this.lbDiameter.Name = "lbDiameter";
            this.lbDiameter.Size = new System.Drawing.Size(83, 15);
            this.lbDiameter.TabIndex = 4;
            this.lbDiameter.Tag = "10";
            this.lbDiameter.Text = "Diameter (km)";
            // 
            // tbMassKgValue
            // 
            this.tbMassKgValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMassKgValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbMassKgValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMassKgValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbMassKgValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbMassKgValue.Location = new System.Drawing.Point(3, 98);
            this.tbMassKgValue.Name = "tbMassKgValue";
            this.tbMassKgValue.Size = new System.Drawing.Size(188, 16);
            this.tbMassKgValue.TabIndex = 5;
            this.tbMassKgValue.Tag = "9";
            this.tbMassKgValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Controls.Add(this.lbOrbitalInclination, 0, 10);
            this.tlpMain.Controls.Add(this.tbOrbitalVelocityValue, 3, 9);
            this.tlpMain.Controls.Add(this.lbOrbitalVelocity, 3, 8);
            this.tlpMain.Controls.Add(this.lbOrbitalPeriod, 2, 8);
            this.tlpMain.Controls.Add(this.lbDiameter, 1, 4);
            this.tlpMain.Controls.Add(this.lbMassKg, 0, 4);
            this.tlpMain.Controls.Add(this.tbMassKgValue, 0, 5);
            this.tlpMain.Controls.Add(this.tbDiameterValue, 1, 5);
            this.tlpMain.Controls.Add(this.tbDensityValue, 2, 5);
            this.tlpMain.Controls.Add(this.tbGravityValue, 3, 5);
            this.tlpMain.Controls.Add(this.lbDensity, 2, 4);
            this.tlpMain.Controls.Add(this.lbGravity, 3, 4);
            this.tlpMain.Controls.Add(this.lbAphelion, 1, 8);
            this.tlpMain.Controls.Add(this.tbAphelionValue, 1, 9);
            this.tlpMain.Controls.Add(this.lbPerihelion, 0, 8);
            this.tlpMain.Controls.Add(this.tbPerihelionValue, 0, 9);
            this.tlpMain.Controls.Add(this.tbDistanceFromSunValue, 3, 7);
            this.tlpMain.Controls.Add(this.lbDistanceFromSun, 3, 6);
            this.tlpMain.Controls.Add(this.lbLengthOfDay, 2, 6);
            this.tlpMain.Controls.Add(this.tbLengthOfDayValue, 2, 7);
            this.tlpMain.Controls.Add(this.lbRotationPeriod, 1, 6);
            this.tlpMain.Controls.Add(this.tbRotationPeriodValue, 1, 7);
            this.tlpMain.Controls.Add(this.lbEscapeVelocity, 0, 6);
            this.tlpMain.Controls.Add(this.tbEscapeVelocityValue, 0, 7);
            this.tlpMain.Controls.Add(this.tbOrbitalPeriodValue, 2, 9);
            this.tlpMain.Controls.Add(this.lbOrbitalEccentricity, 1, 10);
            this.tlpMain.Controls.Add(this.lbObliquityToOrbit, 2, 10);
            this.tlpMain.Controls.Add(this.lbMeanTemperature, 3, 10);
            this.tlpMain.Controls.Add(this.tbOrbitalInclinationValue, 0, 11);
            this.tlpMain.Controls.Add(this.tblbObliquityToOrbitValue, 2, 11);
            this.tlpMain.Controls.Add(this.tbMeanTemperatureValue, 3, 11);
            this.tlpMain.Controls.Add(this.tbOrbitalEccentricityValue, 1, 11);
            this.tlpMain.Controls.Add(this.lbSurfacePressure, 0, 12);
            this.tlpMain.Controls.Add(this.lbNumberOfMoons, 1, 12);
            this.tlpMain.Controls.Add(this.lbRingSystem, 2, 12);
            this.tlpMain.Controls.Add(this.lbGlobalMagneticField, 3, 12);
            this.tlpMain.Controls.Add(this.tbSurfacePressureValue, 0, 13);
            this.tlpMain.Controls.Add(this.tbNumberOfMoonsValue, 1, 13);
            this.tlpMain.Controls.Add(this.tbRingSystemValue, 2, 13);
            this.tlpMain.Controls.Add(this.tbGlobalMagneticFieldValue, 3, 13);
            this.tlpMain.Controls.Add(this.lbRightAscension, 0, 2);
            this.tlpMain.Controls.Add(this.lbDeclination, 1, 2);
            this.tlpMain.Controls.Add(this.lbHorizontalX, 2, 2);
            this.tlpMain.Controls.Add(this.lbHorizontalY, 3, 2);
            this.tlpMain.Controls.Add(this.tbRightAscensionValue, 0, 3);
            this.tlpMain.Controls.Add(this.tbDeclinationValue, 1, 3);
            this.tlpMain.Controls.Add(this.tbHorizontalXValue, 2, 3);
            this.tlpMain.Controls.Add(this.tbHorizontalYValue, 3, 3);
            this.tlpMain.Controls.Add(this.lbAboveHorizon, 0, 0);
            this.tlpMain.Controls.Add(this.tbAboveHorizonValue, 0, 1);
            this.tlpMain.Controls.Add(this.lbAdditionalInformation, 2, 0);
            this.tlpMain.Location = new System.Drawing.Point(12, 69);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 15;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(776, 278);
            this.tlpMain.TabIndex = 6;
            // 
            // lbOrbitalInclination
            // 
            this.lbOrbitalInclination.AutoSize = true;
            this.lbOrbitalInclination.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbOrbitalInclination.Location = new System.Drawing.Point(3, 191);
            this.lbOrbitalInclination.Name = "lbOrbitalInclination";
            this.lbOrbitalInclination.Size = new System.Drawing.Size(154, 15);
            this.lbOrbitalInclination.TabIndex = 27;
            this.lbOrbitalInclination.Tag = "21";
            this.lbOrbitalInclination.Text = "Orbital inclination (degrees)";
            // 
            // tbOrbitalVelocityValue
            // 
            this.tbOrbitalVelocityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrbitalVelocityValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbOrbitalVelocityValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOrbitalVelocityValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbOrbitalVelocityValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbOrbitalVelocityValue.Location = new System.Drawing.Point(585, 172);
            this.tbOrbitalVelocityValue.Name = "tbOrbitalVelocityValue";
            this.tbOrbitalVelocityValue.ReadOnly = true;
            this.tbOrbitalVelocityValue.Size = new System.Drawing.Size(188, 16);
            this.tbOrbitalVelocityValue.TabIndex = 26;
            this.tbOrbitalVelocityValue.Tag = "20";
            this.tbOrbitalVelocityValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // lbOrbitalVelocity
            // 
            this.lbOrbitalVelocity.AutoSize = true;
            this.lbOrbitalVelocity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbOrbitalVelocity.Location = new System.Drawing.Point(585, 154);
            this.lbOrbitalVelocity.Name = "lbOrbitalVelocity";
            this.lbOrbitalVelocity.Size = new System.Drawing.Size(122, 15);
            this.lbOrbitalVelocity.TabIndex = 25;
            this.lbOrbitalVelocity.Tag = "20";
            this.lbOrbitalVelocity.Text = "OrbitalVelocity (km/s)";
            // 
            // lbOrbitalPeriod
            // 
            this.lbOrbitalPeriod.AutoSize = true;
            this.lbOrbitalPeriod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbOrbitalPeriod.Location = new System.Drawing.Point(391, 154);
            this.lbOrbitalPeriod.Name = "lbOrbitalPeriod";
            this.lbOrbitalPeriod.Size = new System.Drawing.Size(112, 15);
            this.lbOrbitalPeriod.TabIndex = 23;
            this.lbOrbitalPeriod.Tag = "19";
            this.lbOrbitalPeriod.Text = "OrbitalPeriod (days)";
            // 
            // tbDiameterValue
            // 
            this.tbDiameterValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDiameterValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbDiameterValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDiameterValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDiameterValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbDiameterValue.Location = new System.Drawing.Point(197, 98);
            this.tbDiameterValue.Name = "tbDiameterValue";
            this.tbDiameterValue.ReadOnly = true;
            this.tbDiameterValue.Size = new System.Drawing.Size(188, 16);
            this.tbDiameterValue.TabIndex = 6;
            this.tbDiameterValue.Tag = "10";
            this.tbDiameterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // tbDensityValue
            // 
            this.tbDensityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDensityValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbDensityValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDensityValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDensityValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbDensityValue.Location = new System.Drawing.Point(391, 98);
            this.tbDensityValue.Name = "tbDensityValue";
            this.tbDensityValue.ReadOnly = true;
            this.tbDensityValue.Size = new System.Drawing.Size(188, 16);
            this.tbDensityValue.TabIndex = 7;
            this.tbDensityValue.Tag = "11";
            this.tbDensityValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // tbGravityValue
            // 
            this.tbGravityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGravityValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbGravityValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGravityValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbGravityValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbGravityValue.Location = new System.Drawing.Point(585, 98);
            this.tbGravityValue.Name = "tbGravityValue";
            this.tbGravityValue.ReadOnly = true;
            this.tbGravityValue.Size = new System.Drawing.Size(188, 16);
            this.tbGravityValue.TabIndex = 8;
            this.tbGravityValue.Tag = "12";
            this.tbGravityValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // lbDensity
            // 
            this.lbDensity.AutoSize = true;
            this.lbDensity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbDensity.Location = new System.Drawing.Point(391, 80);
            this.lbDensity.Name = "lbDensity";
            this.lbDensity.Size = new System.Drawing.Size(93, 15);
            this.lbDensity.TabIndex = 16;
            this.lbDensity.Tag = "11";
            this.lbDensity.Text = " Density (kg/m³)";
            // 
            // lbGravity
            // 
            this.lbGravity.AutoSize = true;
            this.lbGravity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbGravity.Location = new System.Drawing.Point(585, 80);
            this.lbGravity.Name = "lbGravity";
            this.lbGravity.Size = new System.Drawing.Size(80, 15);
            this.lbGravity.TabIndex = 17;
            this.lbGravity.Tag = "12";
            this.lbGravity.Text = "Gravity (m/s²)";
            // 
            // lbAphelion
            // 
            this.lbAphelion.AutoSize = true;
            this.lbAphelion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbAphelion.Location = new System.Drawing.Point(197, 154);
            this.lbAphelion.Name = "lbAphelion";
            this.lbAphelion.Size = new System.Drawing.Size(102, 15);
            this.lbAphelion.TabIndex = 22;
            this.lbAphelion.Tag = "18";
            this.lbAphelion.Text = "Aphelion (10⁶ km)";
            // 
            // tbAphelionValue
            // 
            this.tbAphelionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAphelionValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbAphelionValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAphelionValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbAphelionValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbAphelionValue.Location = new System.Drawing.Point(197, 172);
            this.tbAphelionValue.Name = "tbAphelionValue";
            this.tbAphelionValue.ReadOnly = true;
            this.tbAphelionValue.Size = new System.Drawing.Size(188, 16);
            this.tbAphelionValue.TabIndex = 14;
            this.tbAphelionValue.Tag = "18";
            this.tbAphelionValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // lbPerihelion
            // 
            this.lbPerihelion.AutoSize = true;
            this.lbPerihelion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbPerihelion.Location = new System.Drawing.Point(3, 154);
            this.lbPerihelion.Name = "lbPerihelion";
            this.lbPerihelion.Size = new System.Drawing.Size(107, 15);
            this.lbPerihelion.TabIndex = 21;
            this.lbPerihelion.Tag = "17";
            this.lbPerihelion.Text = "Perihelion (10⁶ km)";
            // 
            // tbPerihelionValue
            // 
            this.tbPerihelionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPerihelionValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbPerihelionValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPerihelionValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbPerihelionValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbPerihelionValue.Location = new System.Drawing.Point(3, 172);
            this.tbPerihelionValue.Name = "tbPerihelionValue";
            this.tbPerihelionValue.ReadOnly = true;
            this.tbPerihelionValue.Size = new System.Drawing.Size(188, 16);
            this.tbPerihelionValue.TabIndex = 13;
            this.tbPerihelionValue.Tag = "17";
            this.tbPerihelionValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // tbDistanceFromSunValue
            // 
            this.tbDistanceFromSunValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDistanceFromSunValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbDistanceFromSunValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDistanceFromSunValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDistanceFromSunValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbDistanceFromSunValue.Location = new System.Drawing.Point(585, 135);
            this.tbDistanceFromSunValue.Name = "tbDistanceFromSunValue";
            this.tbDistanceFromSunValue.ReadOnly = true;
            this.tbDistanceFromSunValue.Size = new System.Drawing.Size(188, 16);
            this.tbDistanceFromSunValue.TabIndex = 12;
            this.tbDistanceFromSunValue.Tag = "16";
            this.tbDistanceFromSunValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // lbDistanceFromSun
            // 
            this.lbDistanceFromSun.AutoSize = true;
            this.lbDistanceFromSun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbDistanceFromSun.Location = new System.Drawing.Point(585, 117);
            this.lbDistanceFromSun.Name = "lbDistanceFromSun";
            this.lbDistanceFromSun.Size = new System.Drawing.Size(150, 15);
            this.lbDistanceFromSun.TabIndex = 20;
            this.lbDistanceFromSun.Tag = "16";
            this.lbDistanceFromSun.Text = "Distance from sun (10⁶ km)";
            // 
            // lbLengthOfDay
            // 
            this.lbLengthOfDay.AutoSize = true;
            this.lbLengthOfDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbLengthOfDay.Location = new System.Drawing.Point(391, 117);
            this.lbLengthOfDay.Name = "lbLengthOfDay";
            this.lbLengthOfDay.Size = new System.Drawing.Size(121, 15);
            this.lbLengthOfDay.TabIndex = 19;
            this.lbLengthOfDay.Tag = "15";
            this.lbLengthOfDay.Text = "Length of day (hours)";
            // 
            // tbLengthOfDayValue
            // 
            this.tbLengthOfDayValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLengthOfDayValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbLengthOfDayValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLengthOfDayValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbLengthOfDayValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbLengthOfDayValue.Location = new System.Drawing.Point(391, 135);
            this.tbLengthOfDayValue.Name = "tbLengthOfDayValue";
            this.tbLengthOfDayValue.ReadOnly = true;
            this.tbLengthOfDayValue.Size = new System.Drawing.Size(188, 16);
            this.tbLengthOfDayValue.TabIndex = 11;
            this.tbLengthOfDayValue.Tag = "15";
            this.tbLengthOfDayValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // lbRotationPeriod
            // 
            this.lbRotationPeriod.AutoSize = true;
            this.lbRotationPeriod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbRotationPeriod.Location = new System.Drawing.Point(197, 117);
            this.lbRotationPeriod.Name = "lbRotationPeriod";
            this.lbRotationPeriod.Size = new System.Drawing.Size(130, 15);
            this.lbRotationPeriod.TabIndex = 15;
            this.lbRotationPeriod.Tag = "14";
            this.lbRotationPeriod.Text = "Rotation period (hours)";
            // 
            // tbRotationPeriodValue
            // 
            this.tbRotationPeriodValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRotationPeriodValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbRotationPeriodValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRotationPeriodValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbRotationPeriodValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbRotationPeriodValue.Location = new System.Drawing.Point(197, 135);
            this.tbRotationPeriodValue.Name = "tbRotationPeriodValue";
            this.tbRotationPeriodValue.ReadOnly = true;
            this.tbRotationPeriodValue.Size = new System.Drawing.Size(188, 16);
            this.tbRotationPeriodValue.TabIndex = 10;
            this.tbRotationPeriodValue.Tag = "14";
            this.tbRotationPeriodValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // lbEscapeVelocity
            // 
            this.lbEscapeVelocity.AutoSize = true;
            this.lbEscapeVelocity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbEscapeVelocity.Location = new System.Drawing.Point(3, 117);
            this.lbEscapeVelocity.Name = "lbEscapeVelocity";
            this.lbEscapeVelocity.Size = new System.Drawing.Size(125, 15);
            this.lbEscapeVelocity.TabIndex = 18;
            this.lbEscapeVelocity.Tag = "13";
            this.lbEscapeVelocity.Text = "Escape velocity (km/s)";
            // 
            // tbEscapeVelocityValue
            // 
            this.tbEscapeVelocityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEscapeVelocityValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbEscapeVelocityValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEscapeVelocityValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbEscapeVelocityValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbEscapeVelocityValue.Location = new System.Drawing.Point(3, 135);
            this.tbEscapeVelocityValue.Name = "tbEscapeVelocityValue";
            this.tbEscapeVelocityValue.ReadOnly = true;
            this.tbEscapeVelocityValue.Size = new System.Drawing.Size(188, 16);
            this.tbEscapeVelocityValue.TabIndex = 9;
            this.tbEscapeVelocityValue.Tag = "13";
            this.tbEscapeVelocityValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // tbOrbitalPeriodValue
            // 
            this.tbOrbitalPeriodValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrbitalPeriodValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbOrbitalPeriodValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOrbitalPeriodValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbOrbitalPeriodValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbOrbitalPeriodValue.Location = new System.Drawing.Point(391, 172);
            this.tbOrbitalPeriodValue.Name = "tbOrbitalPeriodValue";
            this.tbOrbitalPeriodValue.ReadOnly = true;
            this.tbOrbitalPeriodValue.Size = new System.Drawing.Size(188, 16);
            this.tbOrbitalPeriodValue.TabIndex = 24;
            this.tbOrbitalPeriodValue.Tag = "19";
            this.tbOrbitalPeriodValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // lbOrbitalEccentricity
            // 
            this.lbOrbitalEccentricity.AutoSize = true;
            this.lbOrbitalEccentricity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbOrbitalEccentricity.Location = new System.Drawing.Point(197, 191);
            this.lbOrbitalEccentricity.Name = "lbOrbitalEccentricity";
            this.lbOrbitalEccentricity.Size = new System.Drawing.Size(107, 15);
            this.lbOrbitalEccentricity.TabIndex = 28;
            this.lbOrbitalEccentricity.Tag = "22";
            this.lbOrbitalEccentricity.Text = "Orbital eccentricity";
            // 
            // lbObliquityToOrbit
            // 
            this.lbObliquityToOrbit.AutoSize = true;
            this.lbObliquityToOrbit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbObliquityToOrbit.Location = new System.Drawing.Point(391, 191);
            this.lbObliquityToOrbit.Name = "lbObliquityToOrbit";
            this.lbObliquityToOrbit.Size = new System.Drawing.Size(150, 15);
            this.lbObliquityToOrbit.TabIndex = 29;
            this.lbObliquityToOrbit.Tag = "23";
            this.lbObliquityToOrbit.Text = "Obliquity to orbit (degrees)";
            // 
            // lbMeanTemperature
            // 
            this.lbMeanTemperature.AutoSize = true;
            this.lbMeanTemperature.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbMeanTemperature.Location = new System.Drawing.Point(585, 191);
            this.lbMeanTemperature.Name = "lbMeanTemperature";
            this.lbMeanTemperature.Size = new System.Drawing.Size(129, 15);
            this.lbMeanTemperature.TabIndex = 30;
            this.lbMeanTemperature.Tag = "24";
            this.lbMeanTemperature.Text = "Mean temperature (°C)";
            // 
            // tbOrbitalInclinationValue
            // 
            this.tbOrbitalInclinationValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrbitalInclinationValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbOrbitalInclinationValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOrbitalInclinationValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbOrbitalInclinationValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbOrbitalInclinationValue.Location = new System.Drawing.Point(3, 209);
            this.tbOrbitalInclinationValue.Name = "tbOrbitalInclinationValue";
            this.tbOrbitalInclinationValue.ReadOnly = true;
            this.tbOrbitalInclinationValue.Size = new System.Drawing.Size(188, 16);
            this.tbOrbitalInclinationValue.TabIndex = 31;
            this.tbOrbitalInclinationValue.Tag = "21";
            this.tbOrbitalInclinationValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // tblbObliquityToOrbitValue
            // 
            this.tblbObliquityToOrbitValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblbObliquityToOrbitValue.BackColor = System.Drawing.SystemColors.Control;
            this.tblbObliquityToOrbitValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblbObliquityToOrbitValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tblbObliquityToOrbitValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tblbObliquityToOrbitValue.Location = new System.Drawing.Point(391, 209);
            this.tblbObliquityToOrbitValue.Name = "tblbObliquityToOrbitValue";
            this.tblbObliquityToOrbitValue.ReadOnly = true;
            this.tblbObliquityToOrbitValue.Size = new System.Drawing.Size(188, 16);
            this.tblbObliquityToOrbitValue.TabIndex = 33;
            this.tblbObliquityToOrbitValue.Tag = "23";
            this.tblbObliquityToOrbitValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // tbMeanTemperatureValue
            // 
            this.tbMeanTemperatureValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMeanTemperatureValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbMeanTemperatureValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMeanTemperatureValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbMeanTemperatureValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbMeanTemperatureValue.Location = new System.Drawing.Point(585, 209);
            this.tbMeanTemperatureValue.Name = "tbMeanTemperatureValue";
            this.tbMeanTemperatureValue.ReadOnly = true;
            this.tbMeanTemperatureValue.Size = new System.Drawing.Size(188, 16);
            this.tbMeanTemperatureValue.TabIndex = 34;
            this.tbMeanTemperatureValue.Tag = "24";
            this.tbMeanTemperatureValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // tbOrbitalEccentricityValue
            // 
            this.tbOrbitalEccentricityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrbitalEccentricityValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbOrbitalEccentricityValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOrbitalEccentricityValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbOrbitalEccentricityValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbOrbitalEccentricityValue.Location = new System.Drawing.Point(197, 209);
            this.tbOrbitalEccentricityValue.Name = "tbOrbitalEccentricityValue";
            this.tbOrbitalEccentricityValue.ReadOnly = true;
            this.tbOrbitalEccentricityValue.Size = new System.Drawing.Size(188, 16);
            this.tbOrbitalEccentricityValue.TabIndex = 32;
            this.tbOrbitalEccentricityValue.Tag = "22";
            this.tbOrbitalEccentricityValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // lbSurfacePressure
            // 
            this.lbSurfacePressure.AutoSize = true;
            this.lbSurfacePressure.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbSurfacePressure.Location = new System.Drawing.Point(3, 228);
            this.lbSurfacePressure.Name = "lbSurfacePressure";
            this.lbSurfacePressure.Size = new System.Drawing.Size(126, 15);
            this.lbSurfacePressure.TabIndex = 35;
            this.lbSurfacePressure.Tag = "25";
            this.lbSurfacePressure.Text = "Surface pressure (bars)";
            // 
            // lbNumberOfMoons
            // 
            this.lbNumberOfMoons.AutoSize = true;
            this.lbNumberOfMoons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbNumberOfMoons.Location = new System.Drawing.Point(197, 228);
            this.lbNumberOfMoons.Name = "lbNumberOfMoons";
            this.lbNumberOfMoons.Size = new System.Drawing.Size(105, 15);
            this.lbNumberOfMoons.TabIndex = 36;
            this.lbNumberOfMoons.Tag = "26";
            this.lbNumberOfMoons.Text = "Number of moons";
            // 
            // lbRingSystem
            // 
            this.lbRingSystem.AutoSize = true;
            this.lbRingSystem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbRingSystem.Location = new System.Drawing.Point(391, 228);
            this.lbRingSystem.Name = "lbRingSystem";
            this.lbRingSystem.Size = new System.Drawing.Size(71, 15);
            this.lbRingSystem.TabIndex = 37;
            this.lbRingSystem.Tag = "27";
            this.lbRingSystem.Text = "Ring system";
            // 
            // lbGlobalMagneticField
            // 
            this.lbGlobalMagneticField.AutoSize = true;
            this.lbGlobalMagneticField.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbGlobalMagneticField.Location = new System.Drawing.Point(585, 228);
            this.lbGlobalMagneticField.Name = "lbGlobalMagneticField";
            this.lbGlobalMagneticField.Size = new System.Drawing.Size(120, 15);
            this.lbGlobalMagneticField.TabIndex = 38;
            this.lbGlobalMagneticField.Tag = "28";
            this.lbGlobalMagneticField.Text = "Global magnetic field";
            // 
            // tbSurfacePressureValue
            // 
            this.tbSurfacePressureValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSurfacePressureValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbSurfacePressureValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSurfacePressureValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbSurfacePressureValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbSurfacePressureValue.Location = new System.Drawing.Point(3, 246);
            this.tbSurfacePressureValue.Name = "tbSurfacePressureValue";
            this.tbSurfacePressureValue.ReadOnly = true;
            this.tbSurfacePressureValue.Size = new System.Drawing.Size(188, 16);
            this.tbSurfacePressureValue.TabIndex = 39;
            this.tbSurfacePressureValue.Tag = "25";
            this.tbSurfacePressureValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // tbNumberOfMoonsValue
            // 
            this.tbNumberOfMoonsValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumberOfMoonsValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbNumberOfMoonsValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumberOfMoonsValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbNumberOfMoonsValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbNumberOfMoonsValue.Location = new System.Drawing.Point(197, 246);
            this.tbNumberOfMoonsValue.Name = "tbNumberOfMoonsValue";
            this.tbNumberOfMoonsValue.ReadOnly = true;
            this.tbNumberOfMoonsValue.Size = new System.Drawing.Size(188, 16);
            this.tbNumberOfMoonsValue.TabIndex = 40;
            this.tbNumberOfMoonsValue.Tag = "26";
            this.tbNumberOfMoonsValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // tbRingSystemValue
            // 
            this.tbRingSystemValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRingSystemValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbRingSystemValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRingSystemValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbRingSystemValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbRingSystemValue.Location = new System.Drawing.Point(391, 246);
            this.tbRingSystemValue.Name = "tbRingSystemValue";
            this.tbRingSystemValue.ReadOnly = true;
            this.tbRingSystemValue.Size = new System.Drawing.Size(188, 16);
            this.tbRingSystemValue.TabIndex = 41;
            this.tbRingSystemValue.Tag = "27";
            this.tbRingSystemValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // tbGlobalMagneticFieldValue
            // 
            this.tbGlobalMagneticFieldValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGlobalMagneticFieldValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbGlobalMagneticFieldValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGlobalMagneticFieldValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbGlobalMagneticFieldValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbGlobalMagneticFieldValue.Location = new System.Drawing.Point(585, 246);
            this.tbGlobalMagneticFieldValue.Name = "tbGlobalMagneticFieldValue";
            this.tbGlobalMagneticFieldValue.ReadOnly = true;
            this.tbGlobalMagneticFieldValue.Size = new System.Drawing.Size(188, 16);
            this.tbGlobalMagneticFieldValue.TabIndex = 42;
            this.tbGlobalMagneticFieldValue.Tag = "28";
            this.tbGlobalMagneticFieldValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            // 
            // lbRightAscension
            // 
            this.lbRightAscension.AutoSize = true;
            this.lbRightAscension.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbRightAscension.Location = new System.Drawing.Point(3, 40);
            this.lbRightAscension.Name = "lbRightAscension";
            this.lbRightAscension.Size = new System.Drawing.Size(131, 15);
            this.lbRightAscension.TabIndex = 43;
            this.lbRightAscension.Tag = "5";
            this.lbRightAscension.Text = "Right ascension (hours)";
            // 
            // lbDeclination
            // 
            this.lbDeclination.AutoSize = true;
            this.lbDeclination.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbDeclination.Location = new System.Drawing.Point(197, 40);
            this.lbDeclination.Name = "lbDeclination";
            this.lbDeclination.Size = new System.Drawing.Size(119, 15);
            this.lbDeclination.TabIndex = 44;
            this.lbDeclination.Tag = "6";
            this.lbDeclination.Text = "Declination (degrees)";
            // 
            // lbHorizontalX
            // 
            this.lbHorizontalX.AutoSize = true;
            this.lbHorizontalX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbHorizontalX.Location = new System.Drawing.Point(391, 40);
            this.lbHorizontalX.Name = "lbHorizontalX";
            this.lbHorizontalX.Size = new System.Drawing.Size(163, 15);
            this.lbHorizontalX.TabIndex = 45;
            this.lbHorizontalX.Tag = "7";
            this.lbHorizontalX.Text = "Horizontal, azimuth (degrees)";
            // 
            // lbHorizontalY
            // 
            this.lbHorizontalY.AutoSize = true;
            this.lbHorizontalY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbHorizontalY.Location = new System.Drawing.Point(585, 40);
            this.lbHorizontalY.Name = "lbHorizontalY";
            this.lbHorizontalY.Size = new System.Drawing.Size(160, 15);
            this.lbHorizontalY.TabIndex = 46;
            this.lbHorizontalY.Tag = "8";
            this.lbHorizontalY.Text = "Horizontal, altitude (degrees)";
            // 
            // tbRightAscensionValue
            // 
            this.tbRightAscensionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRightAscensionValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbRightAscensionValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRightAscensionValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbRightAscensionValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbRightAscensionValue.Location = new System.Drawing.Point(3, 63);
            this.tbRightAscensionValue.Name = "tbRightAscensionValue";
            this.tbRightAscensionValue.ReadOnly = true;
            this.tbRightAscensionValue.Size = new System.Drawing.Size(188, 16);
            this.tbRightAscensionValue.TabIndex = 47;
            this.tbRightAscensionValue.Tag = "5";
            // 
            // tbDeclinationValue
            // 
            this.tbDeclinationValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeclinationValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbDeclinationValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDeclinationValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbDeclinationValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbDeclinationValue.Location = new System.Drawing.Point(197, 63);
            this.tbDeclinationValue.Name = "tbDeclinationValue";
            this.tbDeclinationValue.ReadOnly = true;
            this.tbDeclinationValue.Size = new System.Drawing.Size(188, 16);
            this.tbDeclinationValue.TabIndex = 48;
            this.tbDeclinationValue.Tag = "6";
            // 
            // tbHorizontalXValue
            // 
            this.tbHorizontalXValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHorizontalXValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbHorizontalXValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHorizontalXValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbHorizontalXValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbHorizontalXValue.Location = new System.Drawing.Point(391, 63);
            this.tbHorizontalXValue.Name = "tbHorizontalXValue";
            this.tbHorizontalXValue.ReadOnly = true;
            this.tbHorizontalXValue.Size = new System.Drawing.Size(188, 16);
            this.tbHorizontalXValue.TabIndex = 49;
            this.tbHorizontalXValue.Tag = "7";
            // 
            // tbHorizontalYValue
            // 
            this.tbHorizontalYValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHorizontalYValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbHorizontalYValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHorizontalYValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbHorizontalYValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbHorizontalYValue.Location = new System.Drawing.Point(585, 63);
            this.tbHorizontalYValue.Name = "tbHorizontalYValue";
            this.tbHorizontalYValue.ReadOnly = true;
            this.tbHorizontalYValue.Size = new System.Drawing.Size(188, 16);
            this.tbHorizontalYValue.TabIndex = 50;
            this.tbHorizontalYValue.Tag = "8";
            // 
            // lbAboveHorizon
            // 
            this.lbAboveHorizon.AutoSize = true;
            this.lbAboveHorizon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbAboveHorizon.Location = new System.Drawing.Point(3, 0);
            this.lbAboveHorizon.Name = "lbAboveHorizon";
            this.lbAboveHorizon.Size = new System.Drawing.Size(84, 15);
            this.lbAboveHorizon.TabIndex = 51;
            this.lbAboveHorizon.Tag = "1";
            this.lbAboveHorizon.Text = "Above horizon";
            // 
            // tbAboveHorizonValue
            // 
            this.tbAboveHorizonValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAboveHorizonValue.BackColor = System.Drawing.SystemColors.Control;
            this.tbAboveHorizonValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAboveHorizonValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbAboveHorizonValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbAboveHorizonValue.Location = new System.Drawing.Point(3, 23);
            this.tbAboveHorizonValue.Name = "tbAboveHorizonValue";
            this.tbAboveHorizonValue.ReadOnly = true;
            this.tbAboveHorizonValue.Size = new System.Drawing.Size(188, 16);
            this.tbAboveHorizonValue.TabIndex = 52;
            this.tbAboveHorizonValue.Tag = "1";
            // 
            // lbAdditionalInformation
            // 
            this.lbAdditionalInformation.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.lbAdditionalInformation, 2);
            this.lbAdditionalInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAdditionalInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbAdditionalInformation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbAdditionalInformation.Location = new System.Drawing.Point(391, 0);
            this.lbAdditionalInformation.Name = "lbAdditionalInformation";
            this.lbAdditionalInformation.Size = new System.Drawing.Size(12, 15);
            this.lbAdditionalInformation.TabIndex = 53;
            this.lbAdditionalInformation.Tag = "1";
            this.lbAdditionalInformation.Text = "-";
            this.lbAdditionalInformation.Click += new System.EventHandler(this.lbAdditionalInformation_Click);
            // 
            // lbLongitude
            // 
            this.lbLongitude.AutoSize = true;
            this.lbLongitude.Location = new System.Drawing.Point(435, 41);
            this.lbLongitude.Name = "lbLongitude";
            this.lbLongitude.Size = new System.Drawing.Size(61, 15);
            this.lbLongitude.TabIndex = 16;
            this.lbLongitude.Text = "Longitude";
            // 
            // nudLongitude
            // 
            this.nudLongitude.DecimalPlaces = 10;
            this.nudLongitude.Location = new System.Drawing.Point(567, 41);
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
            this.nudLongitude.TabIndex = 15;
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
            this.lbLatitude.Location = new System.Drawing.Point(435, 15);
            this.lbLatitude.Name = "lbLatitude";
            this.lbLatitude.Size = new System.Drawing.Size(50, 15);
            this.lbLatitude.TabIndex = 14;
            this.lbLatitude.Text = "Latitude";
            // 
            // nudLatitude
            // 
            this.nudLatitude.DecimalPlaces = 10;
            this.nudLatitude.Location = new System.Drawing.Point(567, 12);
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
            this.nudLatitude.TabIndex = 13;
            this.nudLatitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLatitude.ValueChanged += new System.EventHandler(this.nudLatitude_ValueChanged);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Location = new System.Drawing.Point(12, 41);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(81, 15);
            this.lbDateTime.TabIndex = 17;
            this.lbDateTime.Text = "Date and time";
            // 
            // dtpMapDateTime
            // 
            this.dtpMapDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpMapDateTime.CustomFormat = "dd\'.\'MM\'.\'yyyy HH\':\'mm";
            this.dtpMapDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMapDateTime.Location = new System.Drawing.Point(124, 41);
            this.dtpMapDateTime.Name = "dtpMapDateTime";
            this.dtpMapDateTime.ShowUpDown = true;
            this.dtpMapDateTime.Size = new System.Drawing.Size(285, 23);
            this.dtpMapDateTime.TabIndex = 18;
            this.dtpMapDateTime.ValueChanged += new System.EventHandler(this.dtpMapDateTime_ValueChanged);
            // 
            // btCopyAllToClipboard
            // 
            this.btCopyAllToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCopyAllToClipboard.Checked = false;
            this.btCopyAllToClipboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btCopyAllToClipboard.DisabledColor = System.Drawing.Color.LightGray;
            this.btCopyAllToClipboard.ImageCheckedSvg = null;
            this.btCopyAllToClipboard.ImageColor = System.Drawing.Color.SteelBlue;
            this.btCopyAllToClipboard.ImageColorChecked = System.Drawing.Color.SteelBlue;
            this.btCopyAllToClipboard.ImageSvg = "ic_fluent_copy_24_filled";
            this.btCopyAllToClipboard.IsCheckedButton = false;
            this.btCopyAllToClipboard.Location = new System.Drawing.Point(715, 12);
            this.btCopyAllToClipboard.Name = "btCopyAllToClipboard";
            this.btCopyAllToClipboard.Size = new System.Drawing.Size(73, 51);
            this.btCopyAllToClipboard.TabIndex = 19;
            this.btCopyAllToClipboard.Click += new System.EventHandler(this.btCopyAllToClipboard_Click);
            // 
            // FormPlanetDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.btCopyAllToClipboard);
            this.Controls.Add(this.dtpMapDateTime);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.lbLongitude);
            this.Controls.Add(this.nudLongitude);
            this.Controls.Add(this.lbLatitude);
            this.Controls.Add(this.nudLatitude);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.lbPlanetSelection);
            this.Controls.Add(this.cmbPlanetSelection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlanetDetails";
            this.ShowInTaskbar = false;
            this.Text = "Planets, sun & moon";
            this.Shown += new System.EventHandler(this.FormPlanetDetails_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMassKgValue_KeyDown);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbPlanetSelection;
        private Label lbPlanetSelection;
        private Label lbMassKg;
        private Label lbDiameter;
        private TextBox tbMassKgValue;
        private TableLayoutPanel tlpMain;
        private TextBox tbAphelionValue;
        private TextBox tbDiameterValue;
        private TextBox tbDensityValue;
        private TextBox tbGravityValue;
        private TextBox tbEscapeVelocityValue;
        private TextBox tbRotationPeriodValue;
        private TextBox tbLengthOfDayValue;
        private TextBox tbDistanceFromSunValue;
        private TextBox tbPerihelionValue;
        private Label lbRotationPeriod;
        private Label lbDensity;
        private Label lbGravity;
        private Label lbEscapeVelocity;
        private Label lbLengthOfDay;
        private Label lbDistanceFromSun;
        private Label lbPerihelion;
        private Label lbAphelion;
        private Label lbOrbitalPeriod;
        private TextBox tbOrbitalPeriodValue;
        private TextBox tbOrbitalVelocityValue;
        private Label lbOrbitalVelocity;
        private Label lbOrbitalInclination;
        private Label lbOrbitalEccentricity;
        private Label lbObliquityToOrbit;
        private Label lbMeanTemperature;
        private TextBox tbOrbitalInclinationValue;
        private TextBox tbOrbitalEccentricityValue;
        private TextBox tblbObliquityToOrbitValue;
        private TextBox tbMeanTemperatureValue;
        private Label lbSurfacePressure;
        private Label lbNumberOfMoons;
        private Label lbRingSystem;
        private Label lbGlobalMagneticField;
        private TextBox tbSurfacePressureValue;
        private TextBox tbNumberOfMoonsValue;
        private TextBox tbRingSystemValue;
        private TextBox tbGlobalMagneticFieldValue;
        private Label lbRightAscension;
        private Label lbDeclination;
        private Label lbHorizontalX;
        private Label lbHorizontalY;
        private TextBox tbRightAscensionValue;
        private TextBox tbDeclinationValue;
        private TextBox tbHorizontalXValue;
        private TextBox tbHorizontalYValue;
        private Label lbAboveHorizon;
        private TextBox tbAboveHorizonValue;
        private Label lbLongitude;
        private NumericUpDown nudLongitude;
        private Label lbLatitude;
        private NumericUpDown nudLatitude;
        private Label lbDateTime;
        private DateTimePicker dtpMapDateTime;
        private Controls.WinForms.ImageButton btCopyAllToClipboard;
        private Label lbAdditionalInformation;
    }
}