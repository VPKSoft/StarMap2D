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

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Common.Utilities;
using StarMap2D.EtoForms.ApplicationSettings.SettingClasses;
using StarMap2D.EtoForms.Controls.Utilities;
using VPKSoft.StarCatalogs.StaticData;
using Button = Eto.Forms.Button;
using TabControl = Eto.Forms.TabControl;
using TextBox = Eto.Forms.TextBox;

using UI = StarMap2D.Localization.UI;

namespace StarMap2D.EtoForms.Forms.Dialogs;

/// <summary>
/// A dialog to specify settings for the StarMap2D software.
/// Implements the <see cref="Dialog{T}" />
/// </summary>
/// <seealso cref="Dialog{T}" />
public class FormDialogSettings : Dialog<bool>
{
    #region GeneralControls
    private TabControl? tabControlSettings;
    private Button? btOk;
    private Button? btCancel;
    private TableLayout? tableLayout;
    #endregion

    #region CommonSettingsControls
    private TabPage? tabCommon;
    private TableLayout? tabCommonLayout;
    private TextBox? textBoxLocation;
    private NumericStepper? latitudeStepper;
    private NumericStepper? longitudeStepper;
    private NumericStepper? crossHairStepper;
    private ComboBox? comboBoxLocations;
    private CheckBox? cbInvertAxis;
    private CheckBox? cbDrawConstellations;
    private CheckBox? cbDrawConstellationLabels;
    private CheckBox? cbDrawConstellationBoundaries;
    private CheckBox? cbDrawCrossHair;
    private ComboBox? cmbUiLocale;
    private ComboBox? cmbStarCatalog;
    #endregion

    #region DateAndNumberFormattingSettingsControls
    private TabPage? tabNumberFormatting;
    private TableLayout? tabNumberFormattingLayout;
    private ComboBox? cmbDataFormattingCulture;
    private ComboBox? cmbDateAndTimeFormattingCulture;
    #endregion

    #region MapColorSettings
    private TabPage? tabMapColorSettings;
    private TableLayout? tlMapColorSettings;
    private ColorPicker? cpkConstellationLineColor;
    private ColorPicker? cpkConstellationBorderLineColor;
    private ColorPicker? cpkMapCircleColor;
    private ColorPicker? cpkMapSurroundingsColor;
    private ColorPicker? cpkMapTextColor;
    private ColorPicker? cpkMapCrossHairColor;
    #endregion

    #region Fonts
    private TabPage? tabFonts;
    private TableLayout? tlFonts;
    private FontPicker? fpNormal;
    private FontPicker? fpMonospaced;
    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="FormDialogSettings"/> class.
    /// </summary>
    public FormDialogSettings()
    {
        MinimumSize = new Size(300, 200);

        // Set the software localization.
        UI.Culture = Globals.Locale;

        // Set the icon for the form.
        EtoHelpers.SetIcon(this, StarMap2D.EtoForms.Properties.Resources.StarMap2D);

        // Create the UI controls.
        InitializeView();
    }

    /// <summary>
    /// Initializes the view.
    /// </summary>
    private void InitializeView()
    {
        Title = UI.Settings;

        tableLayout = new TableLayout();

        Content = tableLayout;
        tabControlSettings = new TabControl();

        // The first tab page.
        LayoutTabPageCommon();

        // The second tab page.
        LayoutFontSettings();

        // The third tab page.
        LayoutTabPageFormatting();

        // The fourth tab page.
        LayoutTabMapColorSettings();

        btOk = new Button { Text = UI.OK };
        btOk.Click += delegate { SaveSettings(); Close(true); };

        btCancel = new Button { Text = UI.Cancel };
        btCancel.Click += delegate { Close(false); };

        DefaultButton = btOk;
        AbortButton = btCancel;

        PositiveButtons.Add(btOk);

        NegativeButtons.Add(btCancel);

        LoadSettings();
    }

    /// <summary>
    /// Layouts the tab of the map color settings.
    /// </summary>
    private void LayoutTabMapColorSettings()
    {
        tabMapColorSettings = new TabPage { Text = UI.MapColorSettings };
        tlMapColorSettings = new TableLayout();
        tabMapColorSettings.Content = tlMapColorSettings;

        cpkConstellationLineColor = new ColorPicker();
        cpkConstellationBorderLineColor = new ColorPicker();
        cpkMapCircleColor = new ColorPicker();
        cpkMapSurroundingsColor = new ColorPicker();
        cpkMapTextColor = new ColorPicker();
        cpkMapCrossHairColor = new ColorPicker();

        tlMapColorSettings.Rows.Add(EtoHelpers.LabelWrap(UI.ConstellationLineColor, cpkConstellationLineColor));
        tlMapColorSettings.Rows.Add(EtoHelpers.LabelWrap(UI.ConstellationBorderLineColor, cpkConstellationBorderLineColor));
        tlMapColorSettings.Rows.Add(EtoHelpers.LabelWrap(UI.MapCircleColor, cpkMapCircleColor));
        tlMapColorSettings.Rows.Add(EtoHelpers.LabelWrap(UI.MapSurroundingsColor, cpkMapSurroundingsColor));
        tlMapColorSettings.Rows.Add(EtoHelpers.LabelWrap(UI.MapTextColor, cpkMapTextColor));
        tlMapColorSettings.Rows.Add(EtoHelpers.LabelWrap(UI.MapCrossHairColor, cpkMapCrossHairColor));

        tabControlSettings!.Pages.Add(tabMapColorSettings);
        // Scale the last row to the maximum.
        tlMapColorSettings.Rows.Add(new TableRow { ScaleHeight = true });
    }

    /// <summary>
    /// Creates the controls for the date and number formatting settings tab page.
    /// </summary>
    private void LayoutTabPageFormatting()
    {
        // The base layout.
        tabNumberFormatting = new TabPage { Text = UI.DateAndNumberFormattingSettings };
        tabControlSettings!.Pages.Add(tabNumberFormatting);
        tabNumberFormattingLayout = new TableLayout();
        tabNumberFormattingLayout.Padding = new Padding(5);
        tabNumberFormatting.Content = tabNumberFormattingLayout;

        // The actual controls.
        cmbDataFormattingCulture = new ComboBox
        {
            ItemTextBinding = new PropertyBinding<string>(nameof(CultureExtended.DisplayName)),
            AutoComplete = true,
        };

        tabNumberFormattingLayout.Rows.Add(
            new TableRow(new TableCell(EtoHelpers.LabelWrap(UI.DataFormattingCulture, cmbDataFormattingCulture))));

        var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures)
            .Select(f => new CultureExtended(f.Name, true)).ToList();

        cmbDataFormattingCulture.DataStore = cultures;

        cmbDateAndTimeFormattingCulture = new ComboBox
        {
            ItemTextBinding = new PropertyBinding<string>(nameof(CultureExtended.DisplayName)),
            AutoComplete = true,
        };

        tabNumberFormattingLayout.Rows.Add(
            new TableRow(new TableCell(EtoHelpers.LabelWrap(UI.DateAndTimeFormattingCulture, cmbDateAndTimeFormattingCulture))));

        cmbDateAndTimeFormattingCulture.DataStore = cultures;

        // Scale the last row to the maximum.
        tabNumberFormattingLayout.Rows.Add(new TableRow { ScaleHeight = true });
    }

    private void LayoutFontSettings()
    {
        tabFonts = new TabPage { Text = UI.FontsAndAppearance, Padding = new Padding(Globals.DefaultPadding) };
        tabControlSettings!.Pages.Add(tabFonts);

        tlFonts = new TableLayout();
        tabFonts.Content = tlFonts;

        fpNormal = new FontPicker(Globals.Settings.Font ?? SettingsFontData.Empty);

        tlFonts.Rows.Add(EtoHelpers.LabelWrap(UI.Font, fpNormal));
        fpMonospaced = new FontPicker(Globals.Settings.Font ?? SettingsFontData.Empty);
        tlFonts.Rows.Add(EtoHelpers.LabelWrap(UI.FontMonospaced, fpMonospaced));

        // Scale the last row to the maximum.
        tlFonts.Rows.Add(new TableRow { ScaleHeight = true });
    }

    /// <summary>
    /// Creates the controls for the common settings tab page.
    /// </summary>
    private void LayoutTabPageCommon()
    {
        tabCommon = new TabPage { Text = UI.Common };
        tabControlSettings!.Pages.Add(tabCommon);

        tableLayout!.Rows.Add(new TableRow(
            new TableCell(tabControlSettings, true)));

        tabCommonLayout = new TableLayout();
        tabCommon.Padding = new Padding(5);

        tabCommon.Content = tabCommonLayout;

        textBoxLocation = new TextBox();

        tabCommonLayout.Rows.Add(new TableRow(new TableCell(EtoHelpers.LabelWrap(UI.LocationName, textBoxLocation), true)));

        latitudeStepper = new NumericStepper { DecimalPlaces = 10, MinValue = -90, MaxValue = 90 };
        longitudeStepper = new NumericStepper { DecimalPlaces = 10, MinValue = -180, MaxValue = 180 };
        crossHairStepper = new NumericStepper { DecimalPlaces = 0, MinValue = 2, MaxValue = 70 };

        tabCommonLayout.Rows.Add(new TableLayout(new TableRow(
            new TableCell(
                EtoHelpers.LabelWrap(UI.Latitude, latitudeStepper),
                true),
            new TableCell(
                EtoHelpers.LabelWrap(UI.Longitude, longitudeStepper),
                true))));

        comboBoxLocations = new ComboBox { AutoComplete = true };
        comboBoxLocations.Items.AddRange(Cities.CitiesList.Select(f => new ListItem
        { Key = f.CityName, Text = f.CityName, Tag = f }));

        comboBoxLocations.SelectedValueChanged += delegate
        {
            if (comboBoxLocations.SelectedValue == null)
            {
                return;
            }

            var value = (CityLatLonCoordinate)((ListItem)comboBoxLocations.SelectedValue).Tag;
            latitudeStepper.Value = value.Latitude;
            longitudeStepper.Value = value.Longitude;
            textBoxLocation.Text = value.CityName;
        };

        tabCommonLayout.Rows.Add(new TableRow(new TableCell(
            EtoHelpers.LabelWrap(UI.SelectLocation,
                comboBoxLocations), true)));

        cbInvertAxis = new CheckBox { Text = UI.InvertEastWestAxis };
        cbDrawConstellations = new CheckBox { Text = UI.DrawConstellations };
        cbDrawConstellationLabels = new CheckBox { Text = UI.DrawConstellationNames };
        cbDrawConstellationBoundaries = new CheckBox { Text = UI.DrawConstellationBoundaries };
        cbDrawCrossHair = new CheckBox { Text = UI.DrawCrossHair };

        tabCommonLayout.Rows.Add(new TableRow(new TableCell(
            EtoHelpers.PaddingWrap(cbInvertAxis), true)));

        tabCommonLayout.Rows.Add(new TableRow(new TableCell(
            EtoHelpers.PaddingWrap(cbDrawConstellations), true)));

        tabCommonLayout.Rows.Add(new TableRow(new TableCell(
            EtoHelpers.PaddingWrap(cbDrawConstellationLabels), true)));

        tabCommonLayout.Rows.Add(new TableRow(new TableCell(
            EtoHelpers.PaddingWrap(cbDrawConstellationBoundaries), true)));

        tabCommonLayout.Rows.Add(new TableLayout(new TableRow(
            new TableCell(
                EtoHelpers.PaddingWrap(cbDrawCrossHair),
                true),
            new TableCell(
                EtoHelpers.LabelWrap(UI.CrossHairSize, crossHairStepper),
                true))));

        cmbUiLocale = new ComboBox
        {
            AutoComplete = true,
            ItemTextBinding = new PropertyBinding<string>(nameof(CultureInfo.DisplayName)),
        };

        cmbUiLocale.DataStore = Localization.Properties.Languages.Select(f => new CultureExtended(f, true));

        cmbStarCatalog = new ComboBox { AutoComplete = true };

        starCatalogs = new List<StarCatalogData>
        {
            new()
            {
                IsBuildIn = true, Name = string.Format(UI.EmbeddedParameter, CatalogNames.BuiltInName),
            },
        };

        starCatalogs.AddRange(CatalogNames.TypeNames);

        cmbStarCatalog.DataStore = starCatalogs;

        tabCommonLayout.Rows.Add(new TableRow(new TableCell(
            EtoHelpers.LabelWrap(UI.StarCatalogSelection,
                cmbStarCatalog), true)));

        tabCommonLayout.Rows.Add(new TableRow(new TableCell(
            EtoHelpers.LabelWrap(UI.UiLanguageRequireRestart, cmbUiLocale))));

        // Scale the last row to the maximum.
        tabCommonLayout.Rows.Add(new TableRow { ScaleHeight = true });
    }

    private List<StarCatalogData> starCatalogs = new();

    /// <summary>
    /// Due to a bug in Eto.Forms (WPF) the ComboBox selected item text must be overridden (See: https://github.com/picoe/Eto/issues/414)
    /// Implements the <see cref="System.Globalization.CultureInfo" />
    /// </summary>
    /// <seealso cref="System.Globalization.CultureInfo" />
    internal class CultureExtended : CultureInfo
    {
        private readonly bool local;

        public CultureExtended(string name, bool local) : base(name)
        {
            this.local = local;
        }

        public override string ToString()
        {
            return local ? base.DisplayName : base.EnglishName;
        }
    }

    /// <summary>
    /// Loads the program settings.
    /// </summary>
    private void LoadSettings()
    {
        var cultureDefault = new CultureExtended("en", true);
        var cultureSelected = string.IsNullOrWhiteSpace(Globals.Settings.Locale)
            ? cultureDefault
            : new CultureExtended(Globals.Settings.Locale.Split('-')[0], true);

        cmbUiLocale!.SelectedValue = cultureSelected;

        var selectedCatalog = string.IsNullOrWhiteSpace(Globals.Settings.StarCatalog)
            ? starCatalogs.First(f => f.Identifier == 0)
            : starCatalogs.First(f => !f.IsBuildIn && f.Type.Name == Globals.Settings.StarCatalog);

        cmbStarCatalog!.SelectedValue = selectedCatalog;

        cultureSelected = string.IsNullOrWhiteSpace(Globals.Settings.FormattingLocale)
            ? cultureDefault
            : new CultureExtended(Globals.Settings.FormattingLocale, true);
        cmbDataFormattingCulture!.SelectedValue = cultureSelected;

        cultureSelected = string.IsNullOrWhiteSpace(Globals.Settings.DateFormattingCulture)
            ? cultureDefault
            : new CultureExtended(Globals.Settings.DateFormattingCulture, true);
        cmbDateAndTimeFormattingCulture!.SelectedValue = cultureSelected;

        longitudeStepper!.Value = Globals.Settings.Longitude;
        latitudeStepper!.Value = Globals.Settings.Latitude;
        crossHairStepper!.Value = Globals.Settings.CrossHairSize;
        textBoxLocation!.Text = Globals.Settings.DefaultLocationName;
        cbInvertAxis!.Checked = Globals.Settings.InvertEastWest;
        cbDrawConstellations!.Checked = Globals.Settings.DrawConstellationLines;
        cbDrawConstellationLabels!.Checked = Globals.Settings.DrawConstellationLabels;
        cbDrawConstellationBoundaries!.Checked = Globals.Settings.DrawConstellationBorders;
        cbDrawCrossHair!.Checked = Globals.Settings.DrawCrossHair;
        fpNormal!.Value = Globals.Settings.Font ?? SettingsFontData.Empty;
        fpMonospaced!.Value = Globals.Settings.DataFont ?? SettingsFontData.Empty;

        cpkConstellationLineColor!.Value = Color.Parse(Globals.Settings.ConstellationLineColor);
        cpkConstellationBorderLineColor!.Value = Color.Parse(Globals.Settings.ConstellationBorderLineColor);
        cpkMapCircleColor!.Value = Color.Parse(Globals.Settings.MapCircleColor);
        cpkMapSurroundingsColor!.Value = Color.Parse(Globals.Settings.MapSurroundingsColor);
        cpkMapTextColor!.Value = Color.Parse(Globals.Settings.MapTextColor);
        cpkMapCrossHairColor!.Value = Color.Parse(Globals.Settings.CrossHairColor);
    }

    /// <summary>
    /// Saves the program settings.
    /// </summary>
    private void SaveSettings()
    {
        Globals.Settings.Longitude = longitudeStepper!.Value;
        Globals.Settings.Latitude = latitudeStepper!.Value;
        Globals.Settings.CrossHairSize = (int)crossHairStepper!.Value;
        Globals.Settings.DefaultLocationName = textBoxLocation!.Text;
        Globals.Settings.InvertEastWest = cbInvertAxis!.Checked ?? false;
        Globals.Settings.DrawConstellationLines = cbDrawConstellations!.Checked ?? false;
        Globals.Settings.DrawConstellationLabels = cbDrawConstellationLabels!.Checked ?? false;
        Globals.Settings.DrawConstellationBorders = cbDrawConstellationBoundaries!.Checked ?? false;
        Globals.Settings.DrawCrossHair = cbDrawCrossHair!.Checked ?? false;

        if (cmbUiLocale!.SelectedValue != null)
        {
            var culture = (CultureInfo)cmbUiLocale.SelectedValue;
            Globals.Settings.Locale = culture.Name;
        }

        if (cmbStarCatalog!.SelectedValue != null)
        {
            var catalog = (StarCatalogData)cmbStarCatalog.SelectedValue;
            Globals.Settings.StarCatalog = catalog.Identifier == 0 ? null : catalog.Type.Name;
        }

        if (cmbDataFormattingCulture!.SelectedValue != null)
        {
            var culture = (CultureInfo)cmbDataFormattingCulture.SelectedValue;
            Globals.Settings.FormattingLocale = culture.Name;
        }

        if (cmbDateAndTimeFormattingCulture!.SelectedValue != null)
        {
            var culture = (CultureInfo)cmbDateAndTimeFormattingCulture.SelectedValue;
            Globals.Settings.DateFormattingCulture = culture.Name;
        }

        Globals.Settings.Font = fpNormal!.Value;
        Globals.Settings.DataFont = fpMonospaced!.Value;

        Globals.Settings.ConstellationLineColor = cpkConstellationLineColor!.Value.ToString();
        Globals.Settings.ConstellationBorderLineColor = cpkConstellationBorderLineColor!.Value.ToString();
        Globals.Settings.MapCircleColor = cpkMapCircleColor!.Value.ToString();
        Globals.Settings.MapSurroundingsColor = cpkMapSurroundingsColor!.Value.ToString();
        Globals.Settings.MapTextColor = cpkMapTextColor!.Value.ToString();
        Globals.Settings.CrossHairColor = cpkMapCrossHairColor!.Value.ToString();

        Globals.SaveSettings();
    }
}