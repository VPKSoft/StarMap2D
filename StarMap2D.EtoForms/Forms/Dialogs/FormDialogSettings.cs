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
using POCs.Sanjay.SharpSnippets.Drawing;
using StarMap2D.EtoForms.ApplicationSettings.SettingClasses;
using StarMap2D.EtoForms.Controls.Utilities;
using StarMap2D.Localization;
using VPKSoft.StarCatalogs.StaticData;

namespace StarMap2D.EtoForms.Forms.Dialogs;

/// <summary>
/// A dialog to specify settings for the StarMap2D software.
/// Implements the <see cref="Dialog{T}" />
/// </summary>
/// <seealso cref="Dialog{T}" />
public partial class FormDialogSettings : Dialog<bool>
{
    #region Fonts
    private TabPage? tabFonts;
    private TableLayout? tlFonts;
    private FontPicker? fpNormal;
    private FontPicker? fpMonospaced;
    private ColorPicker? cpkDataFontColor;
    private ColorPicker? cpkIconColor;
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
        EtoHelpers.SetIcon(this, EtoForms.Properties.Resources.StarMap2D);

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

        // The fifth tab page.
        LayoutKnownObjectColorSettings();

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

    private List<StarCatalogData> starCatalogs = new();
    private bool suspendObjectChangeEvents;
    private SolarSystemObjectGraphics[]? objectGraphics;

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

        cpkDataFontColor!.Value = Globals.Settings.DateTextDefaultColor!.Value;
        cpkIconColor!.Value = Globals.Settings.UiIconsDefaultColor!.Value;

        try
        {
            objectGraphics = SolarSystemObjectGraphics
                .MergeWithDefaults(Globals.Settings.KnownObjects, Globals.LocaleName)
                .ToArray();
        }
        catch
        {
            objectGraphics = SolarSystemObjectGraphics.CreateDefaultList(Globals.LocaleName).ToArray();
        }

        lbxKnownObjects!.DataStore = objectGraphics;
        lbxKnownObjects.BackgroundColor = Color.Parse(Globals.Settings.MapCircleColor);
        lbxKnownObjects.TextColor = lbxKnownObjects.BackgroundColor.GetContrast(true);
        iwObjectImage!.BackgroundColor = Color.Parse(Globals.Settings.MapCircleColor);

        rblDrawMode!.SelectedIndex = Globals.Settings.MainChartDrawMode!.Value;
    }

    /// <summary>
    /// Displays the object data.
    /// </summary>
    /// <param name="objectGraphic">The object graphic.</param>
    private void DisplayObjectData(SolarSystemObjectGraphics? objectGraphic)
    {
        if (objectGraphic != null)
        {
            suspendObjectChangeEvents = true;
            lbSelectedSymbolValue!.Text = objectGraphic.Name;
            tbSelectedSymbolName!.Text = objectGraphic.Name;
            iwObjectImage!.Image = objectGraphic.Image;
            cpkSymbolColor!.Value = objectGraphic.ObjectSymbolColor;
            cpkSymbolCircleColor!.Value = objectGraphic.ObjectCircleColor;
            nsObjectDiameter!.Value = objectGraphic.Diameter;
            cbNotUseObject!.Checked = !objectGraphic.Enabled;
            suspendObjectChangeEvents = false;
        }
        else
        {
            lbSelectedSymbolValue!.Text = string.Empty;
            tbSelectedSymbolName!.Text = string.Empty;
            iwObjectImage!.Image = null;
        }
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
        Globals.Settings.DateTextDefaultColor = cpkDataFontColor!.Value;
        Globals.Settings.UiIconsDefaultColor = cpkIconColor!.Value;

        Globals.Settings.KnownObjects = string.Join(";", objectGraphics!.Select(f => f.SaveToString()));

        Globals.Settings.MainChartDrawMode = rblDrawMode!.SelectedIndex;

        Globals.SaveSettings();
    }

    #region InternalEvents
    private void BtnResetObjectGraphics_Click(object? sender, EventArgs e)
    {
        objectGraphics = SolarSystemObjectGraphics.CreateDefaultList(Globals.LocaleName).ToArray();
        lbxKnownObjects!.DataStore = objectGraphics;
    }

    private void CbNotUseObject_CheckedChanged(object? sender, EventArgs e)
    {
        if (suspendObjectChangeEvents)
        {
            return;
        }

        if (lbxKnownObjects?.SelectedValue != null)
        {
            var item = (SolarSystemObjectGraphics)lbxKnownObjects.SelectedValue;
            item.Enabled = cbNotUseObject?.Checked == false;
        }
    }

    private void TbSelectedSymbolName_TextChanged(object? sender, EventArgs e)
    {
        if (suspendObjectChangeEvents)
        {
            return;
        }

        if (lbxKnownObjects?.SelectedValue != null)
        {
            var item = (SolarSystemObjectGraphics)lbxKnownObjects.SelectedValue;
            if (!string.IsNullOrWhiteSpace(tbSelectedSymbolName!.Text))
            {
                item.Name = tbSelectedSymbolName!.Text;
            }
        }

        DisplayObjectData((SolarSystemObjectGraphics?)lbxKnownObjects?.SelectedValue);
    }

    private void FormDialogSettings_ValueChanged(object? sender, EventArgs e)
    {
        if (suspendObjectChangeEvents)
        {
            return;
        }

        if (lbxKnownObjects?.SelectedValue != null)
        {
            var item = (SolarSystemObjectGraphics)lbxKnownObjects.SelectedValue;
            item.ObjectSymbolColor = cpkSymbolColor!.Value;
        }

        DisplayObjectData((SolarSystemObjectGraphics?)lbxKnownObjects?.SelectedValue);
    }

    private void CpkSymbolCircleColor_ValueChanged(object? sender, EventArgs e)
    {
        if (suspendObjectChangeEvents)
        {
            return;
        }

        if (lbxKnownObjects?.SelectedValue != null)
        {
            var item = (SolarSystemObjectGraphics)lbxKnownObjects.SelectedValue;
            item.ObjectCircleColor = cpkSymbolCircleColor!.Value;
        }

        DisplayObjectData((SolarSystemObjectGraphics?)lbxKnownObjects?.SelectedValue);
    }

    private void NsObjectDiameterOnValueChanged(object? sender, EventArgs e)
    {
        if (suspendObjectChangeEvents)
        {
            return;
        }

        if (lbxKnownObjects?.SelectedValue != null)
        {
            var item = (SolarSystemObjectGraphics)lbxKnownObjects.SelectedValue;
            item.Diameter = (int)nsObjectDiameter!.Value;
        }

        DisplayObjectData((SolarSystemObjectGraphics?)lbxKnownObjects?.SelectedValue);
    }

    private void LbxKnownObjects_SelectedValueChanged(object? sender, EventArgs e)
    {
        if (suspendObjectChangeEvents)
        {
            return;
        }

        DisplayObjectData((SolarSystemObjectGraphics?)lbxKnownObjects?.SelectedValue);
    }
    #endregion
}