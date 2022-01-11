using StarMap2D.Properties;
using StarMap2D.Utilities;
using VPKSoft.LangLib;

namespace StarMap2D.Forms.Dialogs
{
    /// <summary>
    /// The settings dialog for the StarMap2D.
    /// Implements the <see cref="VPKSoft.LangLib.DBLangEngineWinforms" />
    /// </summary>
    /// <seealso cref="VPKSoft.LangLib.DBLangEngineWinforms" />
    public partial class FormDialogSettings : DBLangEngineWinforms
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormDialogSettings"/> class.
        /// </summary>
        public FormDialogSettings()
        {
            InitializeComponent();

            if (Utils.ShouldLocalize() != null)
            {
                DBLangEngine.InitializeLanguage("StarMap2D.Localization.Messages", Utils.ShouldLocalize(), false);
                return; // After localization don't do anything more..
            }

            // initialize the language/localization database..
            DBLangEngine.InitializeLanguage("StarMap2D.Localization.Messages");

            cmbSelectLocation.Items.AddRange(cities.CityList.ToArray<object>());

            tbLocationName.Text = Settings.Default.DefaultLocationName;
            nudLongitude.Value = (decimal)Settings.Default.Longitude;
            nudLatitude.Value = (decimal)Settings.Default.Latitude;
        }

        public static void Display(IWin32Window? owner)
        {
            var settingsForm = new FormDialogSettings();
            if (settingsForm.ShowDialog(owner) == DialogResult.OK)
            {
                settingsForm.SaveSettings();
            }
        }

        private void SaveSettings()
        {
            Settings.Default.DefaultLocationName = tbLocationName.Text;
            Settings.Default.Longitude = (double)nudLongitude.Value;
            Settings.Default.Latitude = (double)nudLatitude.Value;
            Settings.Default.Save();
        }

        private readonly Cities cities = new();

        private void cmbSelectLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var city = (CityLatLonCoordinate)cmbSelectLocation.SelectedItem;
            tbLocationName.Text = city.CityName;
            nudLatitude.Value = (decimal)city.Latitude;
            nudLongitude.Value = (decimal)city.Longitude;
        }
    }
}
