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

using StarMap2D.CustomControls;
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

        private void colorPanel_Click(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            suspendColorChange = true;

            var color = panel.BackColor;

            ceColor.Color = color;
            cwColor.Color = color;
            colorControl = panel;
            if (Enum.TryParse<MapGraphicValue>(panel.Tag?.ToString(), false, out var value))
            {
                FormSkyMap2D.ChangeColor(color, value);

            }
            suspendColorChange = false;
        }

        private Control? colorControl;

        private bool suspendColorChange;

        private void cwColor_ColorChanged(object sender, EventArgs e)
        {
            if (suspendColorChange)
            {
                return;
            }

            suspendColorChange = true;

            var color = cwColor.Color;

            if (Enum.TryParse<MapGraphicValue>(colorControl?.Tag?.ToString(), false, out var value))
            {
                FormSkyMap2D.ChangeColor(color, value);

            }

            ceColor.Color = color;
            if (colorControl != null)
            {
                colorControl.BackColor = color;
            }
            suspendColorChange = false;
        }

        private void ceColor_ColorChanged(object sender, EventArgs e)
        {
            if (suspendColorChange)
            {
                return;
            }

            suspendColorChange = true;
            var color = ceColor.Color;

            if (Enum.TryParse<MapGraphicValue>(colorControl?.Tag.ToString(), false, out var value))
            {
                FormSkyMap2D.ChangeColor(color, value);
            }

            cwColor.Color = color;
            if (colorControl != null)
            {
                colorControl.BackColor = color;
            }
            suspendColorChange = false;
        }
    }
}
