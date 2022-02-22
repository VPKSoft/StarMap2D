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
using System.Text;
using System.Threading.Tasks;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Common.Utilities;
using StarMap2D.Eto.Controls;
using VPKSoft.StarCatalogs.Providers;
using VPKSoft.StarCatalogs.StaticData;
using Button = Eto.Forms.Button;
using Control = Eto.Forms.Control;
using Label = Eto.Forms.Label;
using TabControl = Eto.Forms.TabControl;
using TextBox = Eto.Forms.TextBox;

using UI = StarMap2D.Localization.UI;

namespace StarMap2D.Eto.Forms
{
    public class FormDialogSettings : Dialog<bool>
    {
        private TableLayout tableLayout;
        private TabControl tabControl;
        private TabPage tabCommon;
        private TableLayout tabCommonLayout;
        private TextBox textBoxLocation;
        private NumericStepper latitudeStepper;
        private NumericStepper longitudeStepper;
        private NumericStepper crossHairStepper;
        private ComboBox comboBoxLocations;
        private CheckBox cbInvertAxis;
        private CheckBox cbDrawConstellations;
        private CheckBox cbDrawConstellationLabels;
        private CheckBox cbDrawConstellationBoundaries;
        private CheckBox cbDrawCrossHair;
        private ComboBox cmbUiLocale;
        private ComboBox cmbStarCatalog;
        private Button btOK;
        private Button btCancel;

        public FormDialogSettings()
        {
            base.MinimumSize = new Size(300, 200);
            InitializeView();
        }

        private TableLayout LabelWrap(string text, Control control)
        {
            return new TableLayout(new TableRow(new TableCell(PaddingBottomWrap(new Label { Text = text }), true)),
                new TableRow(new TableCell(control, true)))
            { Padding = new Padding(5) };
        }

        private Panel PaddingBottomWrap(Control control, int padding = 5)
        {
            return new Panel { Content = control, Padding = new Padding(0, 0, 0, padding) };
        }


        private Panel PaddingWrap(Control control, int padding = 5)
        {
            return new Panel { Content = control, Padding = new Padding(padding) };
        }

        private void InitializeView()
        {
            UI.Culture = new CultureInfo("fi");

            tableLayout = new TableLayout();

            Content = tableLayout;

            tabControl = new TabControl();
            tabCommon = new TabPage { Text = UI.Common };
            tabControl.Pages.Add(tabCommon);

            tableLayout.Rows.Add(new TableRow(
                new TableCell(tabControl, true)));

            tabCommonLayout = new TableLayout();
            tabCommon.Padding = new Padding(5);

            tabCommon.Content = tabCommonLayout;

            textBoxLocation = new TextBox { Text = Globals.Settings.DefaultLocationName };

            tabCommonLayout.Rows.Add(new TableRow(new TableCell(LabelWrap(UI.LocationName, textBoxLocation), true)));

            latitudeStepper = new NumericStepper { DecimalPlaces = 10, MinValue = -90, MaxValue = 90, Value = Globals.Settings.Latitude };
            longitudeStepper = new NumericStepper { DecimalPlaces = 10, MinValue = -180, MaxValue = 180, Value = Globals.Settings.Longitude };
            crossHairStepper = new NumericStepper { DecimalPlaces = 0, MinValue = 2, MaxValue = 70, Value = Globals.Settings.CrossHairSize };

            tabCommonLayout.Rows.Add(new TableLayout(new TableRow(
                new TableCell(
                    LabelWrap(UI.Latitude, latitudeStepper),
                    true),
                new TableCell(
                    LabelWrap(UI.Longitude, longitudeStepper),
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
                LabelWrap(UI.SelectLocation,
                    comboBoxLocations), true)));

            cbInvertAxis = new CheckBox { Text = UI.InvertEastWestAxis, Checked = Globals.Settings.InvertEastWest };
            cbDrawConstellations = new CheckBox { Text = UI.DrawConstellations, Checked = Globals.Settings.DrawConstellationLines };
            cbDrawConstellationLabels = new CheckBox { Text = UI.DrawConstellationNames, Checked = Globals.Settings.DrawConstellationLabels };
            cbDrawConstellationBoundaries = new CheckBox { Text = UI.DrawConstellationBoundaries, Checked = Globals.Settings.DrawConstellationBorders };
            cbDrawCrossHair = new CheckBox { Text = UI.DrawCrossHair, Checked = Globals.Settings.DrawCrossHair };

            tabCommonLayout.Rows.Add(new TableRow(new TableCell(
                PaddingWrap(cbInvertAxis), true)));

            tabCommonLayout.Rows.Add(new TableRow(new TableCell(
                PaddingWrap(cbDrawConstellations), true)));

            tabCommonLayout.Rows.Add(new TableRow(new TableCell(
                PaddingWrap(cbDrawConstellationLabels), true)));

            tabCommonLayout.Rows.Add(new TableRow(new TableCell(
                PaddingWrap(cbDrawConstellationBoundaries), true)));

            tabCommonLayout.Rows.Add(new TableLayout(new TableRow(
                new TableCell(
                    PaddingWrap(cbDrawCrossHair),
                    true),
                new TableCell(
                    LabelWrap(UI.CrossHairSize, crossHairStepper),
                    true))));

            tabCommonLayout.Rows.Add(new TableRow { ScaleHeight = true });

            cmbUiLocale = new ComboBox { AutoComplete = true };
            cmbUiLocale.Items.AddRange(Localization.Properties.Languages.Select(f => new CultureInfo(f))
                .Select(l => new ListItem { Key = l.Name, Tag = l, Text = l.DisplayName }));

            var cultureDefault = new CultureInfo("en");
            var cultureSelected = string.IsNullOrWhiteSpace(Globals.Settings.Locale)
                ? cultureDefault
                : new CultureInfo(Globals.Settings.Locale);

            cmbUiLocale.SelectedValue =
                new ListItem { Key = cultureSelected.Name, Tag = cultureSelected, Text = cultureSelected.DisplayName };

            cmbStarCatalog = new ComboBox { AutoComplete = true };
            cmbStarCatalog.Items.Add(new ListItem
            {
                Key = string.Format(UI.EmbeddedParameter, CatalogNames.TypeNames[typeof(YaleBrightProvider)]),
                Text = string.Format(UI.EmbeddedParameter, CatalogNames.TypeNames[typeof(YaleBrightProvider)]),
                Tag = new KeyValuePair<Type?, string>(),
            });

            cmbStarCatalog.Items.AddRange(CatalogNames.TypeNames
                .Select(f => new ListItem { Key = f.Key.ToString(), Text = f.Value, Tag = f }));

            tabCommonLayout.Rows.Add(new TableRow(new TableCell(
                LabelWrap(UI.StarCatalogSelection,
                    cmbStarCatalog), true)));

            tabCommonLayout.Rows.Add(new TableRow(new TableCell(
                LabelWrap(UI.UiLanguageRequireRestart, cmbUiLocale))));

            btOK = new Button { Text = UI.OK };
            btOK.Click += delegate { SaveSettings(); Close(true); };

            btCancel = new Button { Text = UI.Cancel };
            btCancel.Click += delegate { Close(false); };

            DefaultButton = btOK;
            AbortButton = btCancel;

            PositiveButtons.Add(btOK);

            NegativeButtons.Add(btCancel);
        }

        private void SaveSettings()
        {
            Globals.Settings.Longitude = longitudeStepper.Value;
            Globals.Settings.Latitude = longitudeStepper.Value;
            Globals.Settings.CrossHairSize = (int)crossHairStepper.Value;
            Globals.Settings.DefaultLocationName = textBoxLocation.Text;
            Globals.Settings.InvertEastWest = cbInvertAxis.Checked!.Value;
            Globals.Settings.DrawConstellationLines = cbDrawConstellations.Checked!.Value;
            Globals.Settings.DrawConstellationLabels = cbDrawConstellationLabels.Checked!.Value;
            Globals.Settings.DrawConstellationBorders = cbDrawConstellationBoundaries.Checked!.Value;
            Globals.Settings.DrawCrossHair = cbDrawCrossHair.Checked!.Value;

            var selectedCatalog = ((KeyValuePair<Type?, string>)((ListItem)cmbStarCatalog.SelectedValue).Tag).Key?.Name;

            string locale = ((ListItem)cmbUiLocale.SelectedValue).Tag.ToString();

            Globals.Settings.StarCatalog = selectedCatalog;

            Globals.SaveSettings();
        }
    }
}