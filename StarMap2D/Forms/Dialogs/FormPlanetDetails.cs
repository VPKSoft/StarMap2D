using System.Globalization;
using System.Text;
using StarMap2D.Calculations.Enumerations;
using StarMap2D.Calculations.Extensions;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.Calculations.StaticData;
using VPKSoft.LangLib;

namespace StarMap2D.Forms.Dialogs
{
    /// <summary>
    /// A form to display planet detail data.
    /// Implements the <see cref="VPKSoft.LangLib.DBLangEngineWinforms" />
    /// </summary>
    /// <seealso cref="VPKSoft.LangLib.DBLangEngineWinforms" />
    public partial class FormPlanetDetails : DBLangEngineWinforms
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormPlanetDetails"/> class.
        /// </summary>
        public FormPlanetDetails()
        {
            InitializeComponent();

            if (Utils.ShouldLocalize() != null)
            {
                DBLangEngine.InitializeLanguage("StarMap2D.Localization.Messages", Utils.ShouldLocalize(), false);
                return; // After localization don't do anything more..
            }

            // initialize the language/localization database..
            DBLangEngine.InitializeLanguage("StarMap2D.Localization.Messages");

            ValueControls = new Dictionary<Label, Control>
            {
                { lbDateTime, dtpMapDateTime },
                { lbLatitude, nudLatitude },
                { lbLongitude, nudLatitude },
                { lbAboveHorizon, tbAboveHorizonValue },
                { lbRightAscension, tbRightAscensionValue },
                { lbDeclination, tbDeclinationValue },
                { lbHorizontalX, tbHorizontalXValue },
                { lbHorizontalY, tbHorizontalYValue },
                { lbMassKg, tbMassKgValue },
                { lbDiameter, tbDiameterValue },
                { lbDensity, tbDensityValue },
                { lbGravity, tbGravityValue },
                { lbEscapeVelocity, tbEscapeVelocityValue },
                { lbRotationPeriod, tbRotationPeriodValue },
                { lbLengthOfDay, tbLengthOfDayValue },
                { lbDistanceFromSun, tbDistanceFromSunValue },
                { lbPerihelion, tbPerihelionValue },
                { lbAphelion, tbAphelionValue },
                { lbOrbitalPeriod, tbOrbitalPeriodValue },
                { lbOrbitalVelocity, tbOrbitalVelocityValue },
                { lbOrbitalInclination, tbOrbitalInclinationValue },
                { lbOrbitalEccentricity, tbOrbitalEccentricityValue },
                { lbObliquityToOrbit, tblbObliquityToOrbitValue },
                { lbMeanTemperature, tbMeanTemperatureValue },
                { lbSurfacePressure, tbSurfacePressureValue },
                { lbNumberOfMoons, tbNumberOfMoonsValue },
                { lbRingSystem, tbRingSystemValue },
                { lbGlobalMagneticField, tbGlobalMagneticFieldValue }
            };

            ListPlanets();
        }

        private DateTime detailDateTime = DateTime.UtcNow;
        private ObjectsWithPositions planet = ObjectsWithPositions.Mercury;

        private void ListPlanets()
        {
            cmbPlanetSelection.Items.Clear();
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Mercury);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Venus);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Earth);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Mars);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Jupiter);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Saturn);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Uranus);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Neptune);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Pluto);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Moon);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Sun);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Ceres);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Eris);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Makemake);
            cmbPlanetSelection.Items.Add(ObjectsWithPositions.Haumea);
        }

        /// <summary>
        /// Displays the form as a dialog.
        /// </summary>
        /// <param name="owner">The owner of the form.</param>
        /// <param name="value">The planet which data to display.</param>
        /// <param name="dateTime">The date and time in UTC of the details.</param>
        /// <param name="latitude">The optional latitude for the data</param>
        /// <param name="longitude">The optional longitude for the data</param>
        public static void Dialog(IWin32Window owner, ObjectsWithPositions value, DateTime dateTime, double? latitude, double? longitude)
        {
            var detail = PlanetData.Data.FirstOrDefault(f => f.ObjectType == value);
            if (detail == null)
            {
                return;
            }
            
            var form = new FormPlanetDetails();
            form.planet = value;
            form.detailDateTime = dateTime;
            form.currentDate = dateTime;
            form.latitude = latitude ?? form.latitude;
            form.longitude = longitude ?? form.longitude;

            form.ShowDialog(owner);
        }

        private DateTime currentDate = DateTime.UtcNow;

        private DateTime CurrentDate
        {
            get => currentDate;

            set
            {
                if (currentDate != value)
                {
                    currentDate = value;
                    DisplayCalculatedData();
                }
            }
        }

        private double longitude = Properties.Settings.Default.Longitude;

        private double Longitude
        {
            get => longitude;

            set
            {
                if (value != longitude)
                {
                    longitude = value;
                    DisplayCalculatedData();
                }
            }
        }

        private double latitude = Properties.Settings.Default.Latitude;

        private double Latitude
        {
            get => latitude;

            set
            {
                if (value != latitude)
                {
                    latitude = value;
                    DisplayCalculatedData();
                }
            }
        }


        private void DisplayCalculatedData()
        {
            var details = SolarSystemObjectPositions.GetDetails(planet, currentDate.ToAASDate(), Globals.HighPrecisionCalculations,
                Latitude, Longitude);

            tbRightAscensionValue.Text = DisplayFloating(details.RightAscension, 8);
            tbDeclinationValue.Text = DisplayFloating(details.Declination, 8);
            tbHorizontalXValue.Text = DisplayFloating(details.HorizontalDegreesX, 8);
            tbHorizontalYValue.Text = DisplayFloating(details.HorizontalDegreesY, 8);
            tbAboveHorizonValue.Text = DisplayBoolean(details.AboveHorizon);
        }

        private void FormPlanetDetails_Shown(object sender, EventArgs e)
        {
            cmbPlanetSelection.SelectedItem = planet;
            DisplayCalculatedData();
            nudLatitude.Value = (decimal)Latitude;
            nudLongitude.Value = (decimal)Longitude;
            dtpMapDateTime.Value = CurrentDate;
        }

        private string DisplayFloating(double? value, int decimals)
        {
            if (value == null)
            {
                return DBLangEngine.GetMessage("msgUnknownVariableValue", "unknown|A value describing an unknown value of a physical variable.");
            }
            return value.Value.ToString($"F{decimals}", CultureInfo.InvariantCulture);
        }

        private string DisplayInteger(int? value)
        {
            if (value == null)
            {
                return DBLangEngine.GetMessage("msgUnknownVariableValue", "unknown|A value describing an unknown value of a physical variable.");
            }
            return value.Value.ToString(CultureInfo.InvariantCulture);
        }

        private string DisplayBoolean(bool? value)
        {
            if (value == null)
            {
                return DBLangEngine.GetMessage("msgUnknownVariableValue", "unknown|A value describing an unknown value of a physical variable.");
            }

            return value.Value
                ? DBLangEngine.GetMessage("msgYes", "yes|A message saying true in form of yes.")
                : DBLangEngine.GetMessage("msgNo", "no|A message saying false in form of no.");
        }

        private Dictionary<Label, Control> ValueControls { get; }

        private void cmbPlanetSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlanetSelection.SelectedItem != null)
            {
                var detail = PlanetData.Data.First(f => f.ObjectType == (ObjectsWithPositions)cmbPlanetSelection.SelectedItem);
                tbMassKgValue.Text = DisplayFloating(detail.Mass, 2);
                tbDiameterValue.Text = DisplayFloating(detail.Diameter, 2);
                tbDensityValue.Text = DisplayFloating(detail.Density, 2);
                tbGravityValue.Text = DisplayFloating(detail.Gravity, 3);

                tbEscapeVelocityValue.Text = DisplayFloating(detail.EscapeVelocity, 3);
                tbRotationPeriodValue.Text = DisplayFloating(detail.RotationPeriod, 3);
                tbLengthOfDayValue.Text = DisplayFloating(detail.LengthOfDay, 4);

                tbDistanceFromSunValue.Text = DisplayFloating(detail.DistanceFromSun, 2);
                tbPerihelionValue.Text = DisplayFloating(detail.Perihelion, 4);
                tbAphelionValue.Text = DisplayFloating(detail.Aphelion, 4);
                tbOrbitalPeriodValue.Text = DisplayFloating(detail.OrbitalPeriod, 4);
                tbOrbitalVelocityValue.Text = DisplayFloating(detail.OrbitalVelocity, 4);

                tbOrbitalInclinationValue.Text = DisplayFloating(detail.OrbitalInclination, 4);
                tbOrbitalEccentricityValue.Text = DisplayFloating(detail.OrbitalEccentricity, 4);
                tblbObliquityToOrbitValue.Text = DisplayFloating(detail.ObliquityToOrbit, 4);
                tbMeanTemperatureValue.Text = DisplayFloating(detail.MeanTemperature, 4);

                tbSurfacePressureValue.Text = DisplayFloating(detail.SurfacePressure, 4);
                tbNumberOfMoonsValue.Text = DisplayInteger(detail.NumberOfMoons);
                tbRingSystemValue.Text = DisplayBoolean(detail.RingSystem);
                tbGlobalMagneticFieldValue.Text = DisplayBoolean(detail.GlobalMagneticField);
                planet = (ObjectsWithPositions)cmbPlanetSelection.SelectedItem;

                lbAdditionalInformation.Text = detail.DataUrl;
                DisplayCalculatedData();
            }
        }

        private void tbMassKgValue_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void nudLatitude_ValueChanged(object sender, EventArgs e)
        {
            var upDown = (NumericUpDown)sender;
            Latitude = (double)upDown.Value;
        }

        private void nudLongitude_ValueChanged(object sender, EventArgs e)
        {
            var upDown = (NumericUpDown)sender;
            Longitude = (double)upDown.Value;
        }

        private void dtpMapDateTime_ValueChanged(object sender, EventArgs e)
        {
            var picker = (DateTimePicker)sender;
            CurrentDate = picker.Value;
        }

        private void btCopyAllToClipboard_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();
            foreach (var control in ValueControls)
            {
                if (control.Value is NumericUpDown upDown)
                {
                    builder.AppendLine($"{control.Key.Text} = {upDown.Value.ToString(CultureInfo.InvariantCulture)}");
                }

                if (control.Value is DateTimePicker picker)
                {
                    builder.AppendLine($"{control.Key.Text} = {picker.Value.ToString(CultureInfo.InvariantCulture)}");
                }

                if (control.Value is TextBox textBox)
                {
                    builder.AppendLine($"{control.Key.Text} = {textBox.Text}");
                }
            }

            for (var i = 0; i < 10; i++)
            {
                try
                {
                    Clipboard.SetText(builder.ToString());
                    break;
                }
                catch
                {
                    Thread.Sleep(50);
                    // Let the loop continue
                }
            }
        }

        private void lbAdditionalInformation_Click(object sender, EventArgs e)
        {
            var label = (Label)sender;

            if (Uri.IsWellFormedUriString(label.Text, UriKind.Absolute))
            {
                System.Diagnostics.Process.Start("explorer.exe", label.Text);
            }
        }
    }
}
