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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Calculations.Attributes;
using StarMap2D.Calculations.StaticData;
using StarMap2D.Common.SvgColorization;
using StarMap2D.Common.Utilities;
using StarMap2D.EtoForms.Controls.Utilities;
using StarMap2D.Localization;

namespace StarMap2D.EtoForms.Forms;

/// <summary>
/// A form to display detailed information of known celestial objects.
/// Implements the <see cref="Eto.Forms.Form" />
/// </summary>
/// <seealso cref="Eto.Forms.Form" />
public partial class FormCelestialObjectData : Form
{
    private GridView? gridView;
    private TableLayout? tlMain;
    private TableLayout? tlTopControls;
    private NumericStepper? nsLatitude;
    private NumericStepper? nsLongitude;
    private DateTimePicker? dateTimePickerJump;
    private ComboBox? cmbJumpLocation;
    private Button? btnCopyToClipboard;
    private Button? btnExportCsv;
    private SelectableFilterCollection<PlanetDataExtended>? dataSource;

    /// <summary>
    /// Initializes a new instance of the <see cref="FormCelestialObjectData"/> class.
    /// </summary>
    public FormCelestialObjectData()
    {
        InitializeView();

        Title = UI.CelestialObjectDetails;

        nsLatitude!.Value = Globals.Settings.Latitude;
        nsLongitude!.Value = Globals.Settings.Longitude;
    }

    /// <summary>
    /// Initializes the view.
    /// </summary>
    private void InitializeView()
    {
        MinimumSize = new Size(800, 450);
        var latitude = Globals.Settings.Latitude;
        var longitude = Globals.Settings.Longitude;
        var dateTime = DateTime.UtcNow;

        tlMain = new TableLayout();
        tlTopControls = new TableLayout();

        nsLatitude = new NumericStepper { DecimalPlaces = 10, MinValue = -90, MaxValue = 90, Width = 150, };
        nsLongitude = new NumericStepper { DecimalPlaces = 10, MinValue = -180, MaxValue = 180, Width = 150, };
        nsLatitude.ValueChanged += LatLonDateOnValueChanged;
        nsLongitude.ValueChanged += LatLonDateOnValueChanged;

        dateTimePickerJump = new DateTimePicker { Mode = DateTimePickerMode.DateTime, Value = DateTime.Now, };
        dateTimePickerJump.ValueChanged += LatLonDateOnValueChanged;

        cmbJumpLocation = new ComboBox { AutoComplete = true };
        cmbJumpLocation.DataStore = Cities.CitiesList;
        cmbJumpLocation.ItemTextBinding = new PropertyBinding<string>(nameof(CityLatLonCoordinate.CityName));
        cmbJumpLocation.SelectedValueChanged += CmbJumpLocation_SelectedValueChanged;

        btnCopyToClipboard = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_copy_24_filled),
            Colors.SteelBlue, 6, (_, _) => { }, UI.CopyToClipboard);

        btnCopyToClipboard.Click += BtnCopyToClipboard_Click;

        btnExportCsv = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_document_arrow_down_20_filled),
            Colors.SteelBlue, 6, (_, _) => { }, UI.ExportCSV);

        btnExportCsv.Click += BtnExportCsv_Click; ;

        tlTopControls.Rows.Add(new TableRow(
            EtoHelpers.LabelWrap(UI.Latitude, nsLatitude),
            EtoHelpers.LabelWrap(UI.Longitude, nsLongitude),
            EtoHelpers.LabelWrap(UI.SpecifyDateTimeTitle, dateTimePickerJump),
            EtoHelpers.LabelWrapperWithControls(UI.JumpToLcation, Globals.DefaultPadding,
                Globals.DefaultPadding,
                cmbJumpLocation,
                EtoHelpers.CreateImageButton(
                    SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_undo_48_filled),
                    Colors.SteelBlue, 6, RevertLocation_Click)),
            EtoHelpers.HeightLimitWrap(EtoHelpers.PaddingWrap(btnCopyToClipboard, Globals.DefaultPadding), false),
            EtoHelpers.HeightLimitWrap(EtoHelpers.PaddingWrap(btnExportCsv, Globals.DefaultPadding), false),
            new TableCell { ScaleWidth = true }
        ));

        tlMain.Rows.Add(tlTopControls);

        gridView = new GridView { Width = 700, };

        CreateColumns();

        CreateCelestialObjectDataSource(latitude, longitude, dateTime);

        tlMain.Rows.Add(gridView);

        Content = tlMain;
    }

    private void CmbJumpLocation_SelectedValueChanged(object? sender, EventArgs e)
    {
        if (cmbJumpLocation!.SelectedValue == null)
        {
            return;
        }

        var value = (CityLatLonCoordinate)cmbJumpLocation.SelectedValue;
        nsLatitude!.Value = value.Latitude;
        nsLongitude!.Value = value.Longitude;
    }

    private void BtnExportCsv_Click(object? sender, EventArgs e)
    {
        SaveFileDialog dialog = new SaveFileDialog
        {
            Filters = { new FileFilter(UI.CSVFiles, "*.csv") },
            Title = UI.SaveToCSVFile,
        };

        if (dialog.ShowDialog(this) == DialogResult.Ok)
        {
            File.WriteAllText(dialog.FileName, CreateDelimitedData(';'));
        }
    }

    private void BtnCopyToClipboard_Click(object? sender, EventArgs e)
    {
        Clipboard.Instance.Text = CreateDelimitedData('\t');
    }

    private void RevertLocation_Click(object? sender, EventArgs e)
    {
        dateTimePickerJump!.Value = DateTime.Now;
        nsLatitude!.Value = Globals.Settings.Latitude;
        nsLongitude!.Value = Globals.Settings.Longitude;
    }

    private void CreateCelestialObjectDataSource(double latitude, double longitude, DateTime dateTime)
    {
        dataSource = new SelectableFilterCollection<PlanetDataExtended>(gridView);

        dataSource.AddRange(PlanetData.Data.Select(f => PlanetData.GetExtendedData(f.ObjectType,
            latitude, longitude, dateTime)));
        dataSource.Sort = (extended, dataExtended) =>
            string.Compare(extended.Name, dataExtended.Name, StringComparison.OrdinalIgnoreCase);

        gridView!.DataStore = dataSource;
    }

    private void LatLonDateOnValueChanged(object? sender, EventArgs e)
    {
        var dateTime = dateTimePickerJump!.Value!.Value.ToUniversalTime();
        CreateCelestialObjectDataSource(nsLatitude!.Value, nsLongitude!.Value, dateTime);
    }

    /// <summary>
    /// Creates a delimited data from the grid columns to be used for clipboard or saving to a file.
    /// </summary>
    /// <param name="delimiter">The delimiter to use to delimit the data.</param>
    /// <returns>A string with delimited data of the grid data.</returns>
    private string CreateDelimitedData(char delimiter)
    {
        var cells = typeof(PlanetDataExtended).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        cells = cells
            .Where(f => f.CustomAttributes.Any(a => a.AttributeType == typeof(DataTableConfigAttribute)))
            .OrderBy(f =>
                ((DataTableConfigAttribute)f.GetCustomAttributes()
                    .First(a => a.GetType() == typeof(DataTableConfigAttribute))).ColumnOrder)
            .ToArray();

        var builder = new StringBuilder();

        for (int i = 0; i < cells.Length; i++)
        {
            var cell = cells[i];

            builder.Append(GetHeaderText(cell.Name));

            if (i + 1 < cells.Length)
            {
                builder.Append(delimiter);
            }
        }

        builder.AppendLine();

        foreach (var dataExtended in dataSource!)
        {
            for (int i = 0; i < cells.Length; i++)
            {
                var cell = cells[i];

                var configAttribute =
                    (DataTableConfigAttribute)cell.GetCustomAttributes()
                        .First(f => f.GetType() == typeof(DataTableConfigAttribute));
                if (cell.PropertyType == typeof(double) || cell.PropertyType == typeof(double?))
                {
                    var value = (double?)cell.GetValue(dataExtended);
                    builder.Append(value == null
                        ? Units.ValueUnknown
                        : string.Format($"{{0:{configAttribute.NumberFormat!}}}", value, CultureInfo.InvariantCulture));
                }

                if (cell.PropertyType == typeof(bool) || cell.PropertyType == typeof(bool?))
                {
                    var value = (bool?)cell.GetValue(dataExtended);
                    builder.Append(value == null
                        ? Units.ValueUnknown
                        : value);
                }

                if (cell.PropertyType == typeof(string))
                {
                    var value = (string)cell.GetValue(dataExtended)!;
                    builder.Append(value);
                }

                if (cell.PropertyType == typeof(int) || cell.PropertyType == typeof(int?))
                {
                    var value = (int?)cell.GetValue(dataExtended);
                    builder.Append(value == null
                        ? Units.ValueUnknown
                        : string.Format(configAttribute.NumberFormat!, value));
                }

                if (cell.PropertyType == typeof(DateTime) || cell.PropertyType == typeof(DateTime?))
                {
                    var value = (DateTime?)cell.GetValue(dataExtended);
                    builder.Append(value == null
                        ? Units.ValueUnknown
                        : value);
                }

                if (i + 1 < cells.Length)
                {
                    builder.Append(delimiter);
                }
            }

            builder.AppendLine();
        }

        return builder.ToString();
    }

    /// <summary>
    /// Get the localized header text for the specified column name.
    /// </summary>
    /// <param name="valueName">The value name.</param>
    /// <returns>The localized column header text.</returns>
    private string GetHeaderText(string valueName)
    {
        return valueName switch
        {
            "Name" => UI.ObjectName,
            "RightAscension" => UI.RightAscensionHours,
            "Declination" => UI.DeclinationDegrees,
            "HorizontalDegreesY" => UI.HorizontalAltitudeDegrees,
            "HorizontalDegreesX" => Units.HorizontalAzimuthDegrees,
            "AboveHorizon" => UI.AboveHorizon,
            "Mass" => Units.MassKg_10_24,
            "Diameter" => Units.DiameterKm,
            "Density" => Units.DensityKgPerM3,
            "Gravity" => Units.GravityMPerS2,
            "EscapeVelocity" => Units.EscapeVelocityKmPerS,
            "RotationPeriod" => Units.RotationPeriodHours,
            "LengthOfDay" => Units.LengthOfDayHours,
            "DistanceFromSun" => Units.DistanceFromSun_10_6_Km,
            "Perihelion" => Units.Perihelion_10_6_Km,
            "Aphelion" => Units.Aphelion_10_6_Km,
            "OrbitalPeriod" => Units.OrbitalPeriodDays,
            "OrbitalVelocity" => Units.OrbitalVelocityKmPerS,
            "OrbitalInclination" => Units.OrbitalInclinationDegrees,
            "OrbitalEccentricity" => Units.OrbitalEccentricity,
            "ObliquityToOrbit" => Units.ObliquityToOrbitDegrees,
            "MeanTemperature" => Units.MeanTemperatureDegreesC,
            "SurfacePressure" => Units.SurfacePressureBars,
            "NumberOfMoons" => Units.NumberOfMoons,
            "RingSystem" => Units.RingSystem,
            "GlobalMagneticField" => Units.GlobalMagneticField,
            "Latitude" => UI.Latitude,
            "Longitude" => UI.Longitude,
            "DetailDateTime" => UI.DateAndTime,
            "DataUrl" => UI.DataURL,
            _ => string.Empty
        };
    }
}