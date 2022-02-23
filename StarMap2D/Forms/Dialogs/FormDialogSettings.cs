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

using System.Globalization;
using StarMap2D.Common.Utilities;
using StarMap2D.Controls.WinForms.Utilities;
using StarMap2D.Properties;
using VPKSoft.LangLib;
using VPKSoft.StarCatalogs.Providers;
using VPKSoft.StarCatalogs.StaticData;

namespace StarMap2D.Forms.Dialogs;

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

        solarSystemObjectConfigurator1.Locale = Settings.Default.Locale;

        cmbSelectLocation.Items.AddRange(Cities.CitiesList.ToArray<object>());

        // list the translated cultures..
        List<CultureInfo> cultures = DBLangEngine.GetLocalizedCultures();

        if (cultures.Count == 0)
        {
            cultures.Add(new CultureInfo("en-US"));
        }

        // A the translated cultures to the selection combo box.
        cmbSelectLanguageValue.Items.AddRange(cultures.Cast<object>().ToArray());

        cmbFormattingCultureValue.Items.AddRange(CultureInfo.GetCultures(CultureTypes.AllCultures).Cast<object>()
            .ToArray());

        cmbDateTimeFormattingCulture.Items.AddRange(CultureInfo.GetCultures(CultureTypes.AllCultures).Cast<object>()
            .ToArray());

        starCatalogs = new List<StarCatalogData>
        {
            new()
            {
                IsBuildIn = true, Name = DBLangEngine.GetMessage("msgEmbeddedValue",
                    "Embedded ({0})|A text describing something embedded with value or data name.", CatalogNames.BuiltInName)
            },
        };

        starCatalogs.AddRange(CatalogNames.TypeNames);

        cmbStarCatalogValue.Items.AddRange(starCatalogs.Cast<object>().ToArray());

        LoadSettings();
    }

    private List<StarCatalogData> starCatalogs = new();

    #region PrivateFields
    private Control? colorControl;
    private bool suspendColorChange;
    #endregion

    #region PrivateMethodsAndProperties
    /// <summary>
    /// Displays the form as modal dialog.
    /// </summary>
    /// <param name="owner">The owner of the form.</param>
    public static void Display(IWin32Window? owner)
    {
        var settingsForm = new FormDialogSettings();
        if (settingsForm.ShowDialog(owner) == DialogResult.OK)
        {
            settingsForm.SaveSettings();
        }
    }

    private void LoadSettings()
    {
        var defaultCatalog = new StarCatalogData
        {
            IsBuildIn = true,
            Name = DBLangEngine.GetMessage("msgEmbeddedValue",
                "Embedded ({0})|A text describing something embedded with value or data name.",
                CatalogNames.BuiltInName),
            Type = typeof(YaleBrightProvider)
        };

        var defaultFileCatalog =
            CatalogNames.TypeNames.FirstOrDefault(f => f.Type == typeof(YaleBrightProvider) && !f.IsBuildIn);

        cmbStarCatalogValue.SelectedItem = string.IsNullOrWhiteSpace(Settings.Default.StarCatalog)
            ? defaultCatalog
            : defaultFileCatalog;

        cmbDateTimeFormattingCulture.SelectedItem = string.IsNullOrWhiteSpace(Settings.Default.DateFormattingCulture)
            ? CultureInfo.CurrentCulture
            : new CultureInfo(Settings.Default.DateFormattingCulture);

        tbLocationName.Text = Settings.Default.DefaultLocationName;
        nudLongitude.Value = (decimal)Settings.Default.Longitude;
        nudLatitude.Value = (decimal)Settings.Default.Latitude;

        starMagnitudeEditor1.StarMagnitudeColors = Settings.Default.StarMagnitudeColors;
        starMagnitudeEditor1.StarMagnitudes = Settings.Default.StarMagnitudeSizes;
        nudMagnitudeMaximum.Value = (decimal)Settings.Default.MagnitudeMaximum;
        nudMagnitudeMinimum.Value = (decimal)Settings.Default.MagnitudeMinimum;
        solarSystemObjectConfigurator1.MapBackgroundColor = Settings.Default.MapCircleColor;

        // Constellations
        cbDrawConstellationBorders.Checked = Settings.Default.DrawConstellationBorders;
        cbDrawConstellationLabels.Checked = Settings.Default.DrawConstellationLabels;
        cbDrawConstellations.Checked = Settings.Default.DrawConstellationLines;

        // Colors.
        pnConstellationBorderLineColor.BackColor = Settings.Default.ConstellationBorderLineColor;
        pnMapCircleColor.BackColor = Settings.Default.MapCircleColor;
        pnConstellationBorderLineColor.BackColor = Settings.Default.ConstellationBorderLineColor;
        pnConstellationLineColor.BackColor = Settings.Default.ConstellationLineColor;
        pnMapSurroundingsColor.BackColor = Settings.Default.MapSurroundingsColor;
        pnMapTextColor.BackColor = Settings.Default.MapTextColor;

        solarSystemObjectConfigurator1.ObjectGraphics = SolarSystemObjectGraphics
            .MergeWithDefaults(Settings.Default.KnownObjects, Settings.Default.Locale)
            .ToArray();
        cbInvertEastWest.Checked = Settings.Default.InvertEastWest;

        cmbFormattingCultureValue.SelectedItem = string.IsNullOrWhiteSpace(Settings.Default.FormattingLocale)
            ? CultureInfo.CurrentUICulture
            : new CultureInfo(Settings.Default.FormattingLocale);

        cmbSelectLanguageValue.SelectedItem = new CultureInfo(Settings.Default.Locale);

        cbDrawCrossHair.Checked = Settings.Default.DrawCrossHair;
        pnCrossHairColor.BackColor = Settings.Default.CrossHairColor;
    }

    private void SaveSettings()
    {
        var selectedItem = ((KeyValuePair<Type?, string>)cmbStarCatalogValue.SelectedItem);
        Settings.Default.StarCatalog = selectedItem.Key == null
            ? string.Empty // The embedded catalog.
            : ((KeyValuePair<Type, string>)cmbStarCatalogValue.SelectedItem).Key.Name;

        Settings.Default.DefaultLocationName = tbLocationName.Text;
        Settings.Default.Longitude = (double)nudLongitude.Value;
        Settings.Default.Latitude = (double)nudLatitude.Value;
        Settings.Default.StarMagnitudeColors = starMagnitudeEditor1.StarMagnitudeColors;
        Settings.Default.StarMagnitudeSizes = starMagnitudeEditor1.StarMagnitudes;

        // Colors.
        Settings.Default.ConstellationBorderLineColor = pnConstellationBorderLineColor.BackColor;
        Settings.Default.MapCircleColor = pnMapCircleColor.BackColor;
        Settings.Default.ConstellationBorderLineColor = pnConstellationBorderLineColor.BackColor;
        Settings.Default.ConstellationLineColor = pnConstellationLineColor.BackColor;
        Settings.Default.MapSurroundingsColor = pnMapSurroundingsColor.BackColor;
        Settings.Default.MapTextColor = pnMapTextColor.BackColor;

        // Constellations
        Settings.Default.DrawConstellationBorders = cbDrawConstellationBorders.Checked;
        Settings.Default.DrawConstellationLabels = cbDrawConstellationLabels.Checked;
        Settings.Default.DrawConstellationLines = cbDrawConstellations.Checked;

        Settings.Default.MagnitudeMaximum = (double)nudMagnitudeMaximum.Value;
        Settings.Default.MagnitudeMinimum = (double)nudMagnitudeMinimum.Value;
        Settings.Default.KnownObjects = string.Join(";", solarSystemObjectConfigurator1.ObjectGraphics.Select(f => f.SaveToString()));
        Settings.Default.InvertEastWest = cbInvertEastWest.Checked;
        Settings.Default.DrawCrossHair = cbDrawCrossHair.Checked;
        Settings.Default.CrossHairColor = pnCrossHairColor.BackColor;

        Settings.Default.DateFormattingCulture = cmbDateTimeFormattingCulture.SelectedItem.ToString();
        Settings.Default.Locale = cmbSelectLanguageValue.SelectedItem.ToString();
        Settings.Default.FormattingLocale = cmbFormattingCultureValue.SelectedItem.ToString();
        Settings.Default.Save();
    }
    #endregion

    #region InternalEvents
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

    private void btResetSymbols_Click(object sender, EventArgs e)
    {
        solarSystemObjectConfigurator1.Reset();
    }
    #endregion

    private void cbDrawConstellations_CheckedChanged(object sender, EventArgs e)
    {
        var checkBox = (CheckBox)sender;
        if (!checkBox.Checked)
        {
            cbDrawConstellationLabels.Checked = false;
            cbDrawConstellationLabels.Enabled = false;
        }
        else
        {
            cbDrawConstellationLabels.Enabled = true;
        }
    }

    private void combobox_ValidateSelection(object sender, EventArgs e)
    {
        var comboBox = (ComboBox)sender;
        // Don't cancel, just indicate an error.
        if (comboBox.SelectedIndex < 0 || comboBox.SelectedItem == null)
        {
            ttMain.SetToolTip(comboBox,
                DBLangEngine.GetMessage("msgPleaseSelectAValue",
                    "Select a value|A message indicating to the user to select a value from a control with selection."));
            comboBox.BackColor = Color.PaleVioletRed;
            btOk.Enabled = false;
            return;
        }
        btOk.Enabled = true;
        ttMain.SetToolTip(comboBox, null);
        comboBox.BackColor = SystemColors.Window;
    }
}