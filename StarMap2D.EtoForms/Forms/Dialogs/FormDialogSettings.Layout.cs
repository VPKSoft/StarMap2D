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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Common.SvgColorization;
using StarMap2D.Common.Utilities;
using StarMap2D.EtoForms.ApplicationSettings.SettingClasses;
using StarMap2D.EtoForms.Controls.Utilities;
using StarMap2D.Localization;
using VPKSoft.StarCatalogs.StaticData;

namespace StarMap2D.EtoForms.Forms.Dialogs;

public partial class FormDialogSettings
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
    private RadioButtonList? rblDrawMode;
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

    #region SymbolColorSettings
    private TabPage? tabKnownObjectColorSettings;
    private TableLayout? tlKnownObjectColors;
    private TableLayout? tlKnownObjectsRight;
    private ListBox? lbxKnownObjects;
    private Label? lbSelectedSymbolValue;
    private TextBox? tbSelectedSymbolName;
    private NumericStepper? nsObjectDiameter;
    private CheckBox? cbNotUseObject;
    private ImageView? iwObjectImage;
    private ColorPicker? cpkSymbolCircleColor;
    private ColorPicker? cpkSymbolColor;
    private Button? btnResetObjectGraphics;
    #endregion

    /// <summary>
    /// Creates the controls for the common settings tab page.
    /// </summary>
    private void LayoutTabPageCommon()
    {
        tabCommon = new TabPage { Text = UI.Common, };
        tabControlSettings!.Pages.Add(tabCommon);

        tableLayout!.Rows.Add(new TableRow(
            new TableCell(tabControlSettings, true)));

        tabCommonLayout = new TableLayout();
        tabCommon.Padding = new Padding(5);

        tabCommon.Content = tabCommonLayout;

        textBoxLocation = new TextBox();

        tabCommonLayout.Rows.Add(new TableRow(new TableCell(EtoHelpers.LabelWrap(UI.LocationName, textBoxLocation), true)));

        latitudeStepper = new NumericStepper { DecimalPlaces = 10, MinValue = -90, MaxValue = 90, };
        longitudeStepper = new NumericStepper { DecimalPlaces = 10, MinValue = -180, MaxValue = 180, };
        crossHairStepper = new NumericStepper { DecimalPlaces = 0, MinValue = 2, MaxValue = 70, };

        tabCommonLayout.Rows.Add(new TableLayout(new TableRow(
            new TableCell(
                EtoHelpers.LabelWrap(UI.Latitude, latitudeStepper),
                true),
            new TableCell(
                EtoHelpers.LabelWrap(UI.Longitude, longitudeStepper),
                true))));

        comboBoxLocations = new ComboBox { AutoComplete = true, };
        comboBoxLocations.Items.AddRange(Cities.CitiesList.Select(f => new ListItem
        { Key = f.CityName, Text = f.CityName, Tag = f, }));

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

        cbInvertAxis = new CheckBox { Text = UI.InvertEastWestAxis, };
        cbDrawConstellations = new CheckBox { Text = UI.DrawConstellations, };
        cbDrawConstellationLabels = new CheckBox { Text = UI.DrawConstellationNames, };
        cbDrawConstellationBoundaries = new CheckBox { Text = UI.DrawConstellationBoundaries, };
        cbDrawCrossHair = new CheckBox { Text = UI.DrawCrossHair, };

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

        cmbStarCatalog = new ComboBox { AutoComplete = true, };

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
        tabCommonLayout.Rows.Add(new TableRow { ScaleHeight = true, });
    }

    private void LayoutFontSettings()
    {
        tabFonts = new TabPage { Text = UI.FontsAndAppearance, Padding = new Padding(Globals.DefaultPadding), };
        tabControlSettings!.Pages.Add(tabFonts);

        tlFonts = new TableLayout();
        tabFonts.Content = tlFonts;

        fpNormal = new FontPicker(Globals.Settings.Font ?? SettingsFontData.Empty);

        tlFonts.Rows.Add(EtoHelpers.LabelWrap(UI.Font, fpNormal));
        fpMonospaced = new FontPicker(Globals.Settings.Font ?? SettingsFontData.Empty);
        tlFonts.Rows.Add(EtoHelpers.LabelWrap(UI.FontMonospaced, fpMonospaced));

        rblDrawMode = new RadioButtonList
        {
            Items =
            {
                UI.AlwaysReScale,
                UI.Adapt,
                UI.MaximumAxes,
            },
            Spacing = new Size(Globals.DefaultPadding, Globals.DefaultPadding),
        };

        tlFonts.Rows.Add(EtoHelpers.LabelWrap(UI.RiseAndSetGraphDrawMode, rblDrawMode));

        cpkDataFontColor = new ColorPicker();
        cpkIconColor = new ColorPicker();

        tlFonts.Rows.Add(EtoHelpers.LabelWrap(UI.DataFontColor, cpkDataFontColor));
        tlFonts.Rows.Add(EtoHelpers.LabelWrap(UI.UIIconsColor, cpkIconColor));

        // Scale the last row to the maximum.
        tlFonts.Rows.Add(new TableRow { ScaleHeight = true, });
    }

    /// <summary>
    /// Creates the controls for the date and number formatting settings tab page.
    /// </summary>
    private void LayoutTabPageFormatting()
    {
        // The base layout.
        tabNumberFormatting = new TabPage { Text = UI.DateAndNumberFormattingSettings, };
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
        tabNumberFormattingLayout.Rows.Add(new TableRow { ScaleHeight = true, });
    }

    /// <summary>
    /// Layouts the tab of the map color settings.
    /// </summary>
    private void LayoutTabMapColorSettings()
    {
        tabMapColorSettings = new TabPage { Text = UI.MapColorSettings, };
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
        tlMapColorSettings.Rows.Add(new TableRow { ScaleHeight = true, });
    }

    /// <summary>
    /// Layouts the tab of the map color settings.
    /// </summary>
    private void LayoutKnownObjectColorSettings()
    {
        tabKnownObjectColorSettings = new TabPage { Text = UI.KnownObjectSymbols, };
        tlKnownObjectColors = new TableLayout();
        tabKnownObjectColorSettings.Content = tlKnownObjectColors;
        lbxKnownObjects = new ListBox { Height = 400, };

        tlKnownObjectsRight = new TableLayout();

        tlKnownObjectColors.Rows.Add(new TableRow(lbxKnownObjects, tlKnownObjectsRight));

        lbSelectedSymbolValue = new Label();
        tbSelectedSymbolName = new TextBox();
        tlKnownObjectsRight.Rows.Add(new TableRow(
            EtoHelpers.LabelWrap(UI.SelectedObject, lbSelectedSymbolValue),
        EtoHelpers.LabelWrap(UI.SelectedObjectName, tbSelectedSymbolName)
            ));

        nsObjectDiameter = new NumericStepper { MinValue = 10, MaxValue = 100, };
        cbNotUseObject = new CheckBox { Text = UI.DoNotUseTheObject, };
        tlKnownObjectsRight.Rows.Add(new TableRow(EtoHelpers.LabelWrap(UI.ObjectDiameter, nsObjectDiameter),
             new Panel()));

        tlKnownObjectsRight.Rows.Add(EtoHelpers.PaddingWrap(cbNotUseObject, Globals.DefaultPadding));

        iwObjectImage = new ImageView { Size = new Size(110, 110), };
        iwObjectImage.BackgroundColor = Colors.Black;

        tlKnownObjectsRight.Rows.Add(EtoHelpers.LabelWrap(UI.SymbolImage, iwObjectImage));

        cpkSymbolCircleColor = new ColorPicker();
        cpkSymbolColor = new ColorPicker();
        tlKnownObjectsRight.Rows.Add(new TableRow(
            EtoHelpers.LabelWrap(UI.SymbolCircleColor, cpkSymbolCircleColor),
            EtoHelpers.LabelWrap(UI.SymbolColor, cpkSymbolColor)));

        lbxKnownObjects.ItemImageBinding = new PropertyBinding<Image>(nameof(SolarSystemObjectGraphics.Image));
        lbxKnownObjects.ItemTextBinding = new PropertyBinding<string>(nameof(SolarSystemObjectGraphics.Name));
        lbxKnownObjects.SelectedValueChanged += LbxKnownObjects_SelectedValueChanged;

        // Scale the last row to the maximum.
        tlKnownObjectsRight.Rows.Add(new TableRow { ScaleHeight = true, });

        btnResetObjectGraphics = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_undo_48_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 6, (_, _) =>
            {
            }, UI.ResetObjectGraphics);

        tlKnownObjectsRight.Rows.Add(new TableRow(new Panel(), EtoHelpers.WidthLimitWrap(EtoHelpers.PaddingWrap(btnResetObjectGraphics, Globals.DefaultPadding), false)));

        tabControlSettings!.Pages.Add(tabKnownObjectColorSettings);
        // Scale the last row to the maximum.
        tlKnownObjectColors.Rows.Add(new TableRow { ScaleHeight = true, });

        nsObjectDiameter!.ValueChanged += NsObjectDiameterOnValueChanged;
        cpkSymbolCircleColor!.ValueChanged += CpkSymbolCircleColor_ValueChanged;
        cpkSymbolColor!.ValueChanged += FormDialogSettings_ValueChanged;
        tbSelectedSymbolName!.TextChanged += TbSelectedSymbolName_TextChanged;
        cbNotUseObject!.CheckedChanged += CbNotUseObject_CheckedChanged;
        btnResetObjectGraphics!.Click += BtnResetObjectGraphics_Click;
    }
}