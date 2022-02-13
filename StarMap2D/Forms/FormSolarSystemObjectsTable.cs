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

using System.Data;
using System.Diagnostics;
using System.Reflection;
using ChoETL;
using StarMap2D.Calculations.Attributes;
using StarMap2D.Calculations.StaticData;
using StarMap2D.Miscellaneous;
using StarMap2D.Utilities;
using VPKSoft.LangLib;

namespace StarMap2D.Forms;

/// <summary>
/// A form to display details of known objects (mostly planets).
/// Implements the <see cref="VPKSoft.LangLib.DBLangEngineWinforms" />
/// </summary>
/// <seealso cref="VPKSoft.LangLib.DBLangEngineWinforms" />
public partial class FormSolarSystemObjectsTable : DBLangEngineWinforms
{
    private List<PlanetDataExtended> data = new();

    private DataTable? table;
    private bool suspendEvents;

    /// <summary>
    /// Initializes a new instance of the <see cref="FormSolarSystemObjectsTable"/> class.
    /// </summary>
    public FormSolarSystemObjectsTable()
    {
        InitializeComponent();

        if (Utils.ShouldLocalize() != null)
        {
            DBLangEngine.InitializeLanguage("StarMap2D.Localization.Messages", Utils.ShouldLocalize(), false);
            return; // After localization don't do anything more..
        }

        // initialize the language/localization database..
        DBLangEngine.InitializeLanguage("StarMap2D.Localization.Messages");

        cmbJumpToLocation.Items.AddRange(Cities.CitiesList.ToArray<object>());

        suspendEvents = true;
        nudLatitude.Value = (decimal)Properties.Settings.Default.Latitude;
        nudLongitude.Value = (decimal)Properties.Settings.Default.Longitude;
        dtpMapDateTime.Value = DateTime.Now;
        suspendEvents = false;

        FillDataGrid(Properties.Settings.Default.Latitude, Properties.Settings.Default.Longitude, DateTime.UtcNow);
    }

    private string GetHeaderText(string valueName)
    {
        return valueName switch
        {
            "Name" => DBLangEngine.GetMessage("msgName", "Name|A message describing a name value of something."),
            "RightAscension" => DBLangEngine.GetMessage("msgRightAscension",
                "Right ascension (hours)|A message describing an elliptical object physical property: Right ascension (hours)."),
            "Declination" => DBLangEngine.GetMessage("msgDeclination",
                "Declination (degrees)|A message describing an elliptical object physical property: Declination (degrees)."),
            "HorizontalDegreesY" => DBLangEngine.GetMessage("msgHorizontalDegreesY",
                "Horizontal, altitude (degrees)|A message describing an elliptical object physical property: Horizontal, altitude (degrees)."),
            "HorizontalDegreesX" => DBLangEngine.GetMessage("msgHorizontalDegreesX",
                "Horizontal, azimuth (degrees)|A message describing an elliptical object physical property: Horizontal, azimuth (degrees)."),
            "AboveHorizon" => DBLangEngine.GetMessage("msgAboveHorizon",
                "Above horizon|A message describing an elliptical object physical property: Above horizon."),
            "Mass" => DBLangEngine.GetMessage("msgMassKg10_24",
                "Mass (10²⁴ kg)|A message describing an elliptical object physical property: Mass (10²⁴ kg)."),
            "Diameter" => DBLangEngine.GetMessage("msgDiameterKm",
                "Diameter (km)|A message describing an elliptical object physical property: Diameter (km)."),
            "Density" => DBLangEngine.GetMessage("msgDensityKgM3",
                "Density (kg/m³)|A message describing an elliptical object physical property:  density (kg/m³)."),
            "Gravity" => DBLangEngine.GetMessage("msgGravityMS2",
                "Gravity (m/s²)|A message describing an elliptical object physical property: Gravity (m/s²)."),
            "EscapeVelocity" => DBLangEngine.GetMessage("msgEscapeVelocityKmS",
                "Escape velocity (km/s)|A message describing an elliptical object physical property: Escape velocity (km/s)."),
            "RotationPeriod" => DBLangEngine.GetMessage("msgRotationPeriodHrs",
                "Rotation period (hours)|A message describing an elliptical object physical property: Rotation period (hours)."),
            "LengthOfDay" => DBLangEngine.GetMessage("msgLengthOfDayHrs",
                "Length of day (hours)|A message describing an elliptical object physical property: Length of day (hours)."),
            "DistanceFromSun" => DBLangEngine.GetMessage("msgDistanceFromSunKm10_6",
                "Distance from sun (10⁶ km)|A message describing an elliptical object physical property: Distance from sun (10⁶ km)."),
            "Perihelion" => DBLangEngine.GetMessage("msgPerihelionKm10_6",
                "Perihelion (10⁶ km)|A message describing an elliptical object physical property: Perihelion (10⁶ km)."),
            "Aphelion" => DBLangEngine.GetMessage("msgAphelionKm10_6",
                "Aphelion (10⁶ km)|A message describing an elliptical object physical property: Aphelion (10⁶ km)."),
            "OrbitalPeriod" => DBLangEngine.GetMessage("msgOrbitalPeriodDays",
                "Orbital period (days)|A message describing an elliptical object physical property: Orbital period (days)."),
            "OrbitalVelocity" => DBLangEngine.GetMessage("msgOrbitalVelocityKmS",
                "Orbital velocity (km/s)|A message describing an elliptical object physical property: Orbital velocity (km/s)."),
            "OrbitalInclination" => DBLangEngine.GetMessage("msgOrbitalInclinationDeg",
                "Orbital inclination (degrees)|A message describing an elliptical object physical property: Orbital inclination (degrees)."),
            "OrbitalEccentricity" => DBLangEngine.GetMessage("msgOrbitalEccentricity",
                "Orbital eccentricity|A message describing an elliptical object physical property: Orbital eccentricity."),
            "ObliquityToOrbit" => DBLangEngine.GetMessage("msgObliquityToOrbitDeg",
                "Obliquity to orbit (degrees)|A message describing an elliptical object physical property: Obliquity to orbit (degrees)."),
            "MeanTemperature" => DBLangEngine.GetMessage("msgMeanTemperatureDC",
                "Mean temperature (°C)|A message describing an elliptical object physical property: Mean temperature (°C)."),
            "SurfacePressure" => DBLangEngine.GetMessage("msgSurfacePressureBars",
                "Surface pressure (bars)|A message describing an elliptical object physical property: Surface pressure (bars)."),
            "NumberOfMoons" => DBLangEngine.GetMessage("msgNumberOfMoons",
                "Number of moons|A message describing an elliptical object physical property: Number of moons."),
            "RingSystem" => DBLangEngine.GetMessage("msgRingSystem",
                "Ring system|A message describing an elliptical object physical property: Ring system."),
            "GlobalMagneticField" => DBLangEngine.GetMessage("msgGlobalMagneticField",
                "Global magnetic field|A message describing an elliptical object physical property: Global magnetic field."),
            "Latitude" => DBLangEngine.GetMessage("msgLatitude", "Latitude|A message describing latitude."),
            "Longitude" => DBLangEngine.GetMessage("msgLongitude", "Longitude|A message describing longitude."),
            "DetailDateTime" => DBLangEngine.GetMessage("msgDetailDateTime",
                "Date and time|A message describing a date and time of value calculation."),
            "DataUrl" => DBLangEngine.GetMessage("msgDataUrl",
                "Data URL|A message describing an external URL value for additional data."),
            _ => string.Empty
        };
    }

    private void FillDataGrid(double latitude, double longitude, DateTime dateTime)
    {
        dateTime = dateTime.ToUniversalTime();
        adgSolarObjects.Columns.Clear();

        table = PlanetData.Data.Select(f => PlanetData.GetExtendedData(f.ObjectType,
            latitude, longitude, dateTime)).AsDataTable(null,
            Globals.FormattingCulture, null,
            null, new[]
            {
                nameof(PlanetDataExtended.ObjectName),
            });

        adgSolarObjects.AutoGenerateColumns = false;
        adgSolarObjects.DataSource = table;

        var cells = typeof(PlanetDataExtended).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        cells = cells
            .Where(f => f.CustomAttributes.Any(a => a.AttributeType == typeof(DataTableConfigAttribute)))
            .OrderBy(f =>
                ((DataTableConfigAttribute)f.GetCustomAttributes()
                    .First(a => a.GetType() == typeof(DataTableConfigAttribute))).ColumnOrder)
            .ToArray();

        foreach (var cell in cells)
        {
            var configAttribute =
                (DataTableConfigAttribute)cell.GetCustomAttributes().First(f => f.GetType() == typeof(DataTableConfigAttribute));

            if (cell.PropertyType == typeof(double) || cell.PropertyType == typeof(double?))
            {
                adgSolarObjects.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = GetHeaderText(cell.Name),
                    Name = cell.Name,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        Format = configAttribute.NumberFormat,
                        FormatProvider = Globals.FormattingCulture,
                        NullValue = DBLangEngine.GetMessage("msgUnknownVariableValue", "unknown|A value describing an unknown value of a physical variable.")
                    },
                    DataPropertyName = cell.Name,
                    ValueType = typeof(double),
                });
            }

            if (cell.PropertyType == typeof(bool) || cell.PropertyType == typeof(bool?))
            {
                adgSolarObjects.Columns.Add(new DataGridViewCheckBoxColumn
                {
                    HeaderText = GetHeaderText(cell.Name),
                    Name = cell.Name,
                    ThreeState = cell.PropertyType.IsNullableType(),
                    DataPropertyName = cell.Name,
                    ValueType = typeof(double),
                });
            }

            if (cell.PropertyType == typeof(string))
            {
                adgSolarObjects.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = cell.Name,
                    ValueType = typeof(string),
                    DataPropertyName = cell.Name,
                    HeaderText = GetHeaderText(cell.Name),
                    ContextMenuStrip = contextMenuStrip1,
                });
            }

            if (cell.PropertyType == typeof(int) || cell.PropertyType == typeof(int?))
            {
                adgSolarObjects.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = GetHeaderText(cell.Name),
                    Name = cell.Name,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        FormatProvider = Globals.FormattingCulture,
                        NullValue = DBLangEngine.GetMessage("msgUnknownVariableValue", "unknown|A value describing an unknown value of a physical variable.")
                    },
                    DataPropertyName = cell.Name,
                    ValueType = typeof(int),
                });
            }

            if (cell.PropertyType == typeof(DateTime) || cell.PropertyType == typeof(DateTime?))
            {
                adgSolarObjects.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = GetHeaderText(cell.Name),
                    Name = cell.Name,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        FormatProvider = Globals.FormattingCulture,
                        NullValue = DBLangEngine.GetMessage("msgUnknownVariableValue", "unknown|A value describing an unknown value of a physical variable.")
                    },
                    DataPropertyName = cell.Name,
                    ValueType = typeof(DateTime),
                });
            }
        }

        foreach (DataGridViewColumn dataGridViewColumn in adgSolarObjects.Columns)
        {
            dataGridViewColumn.ReadOnly = true;
        }
    }

    private void advancedDataGridView1_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
    {
        if (table != null)
        {
            table.DefaultView.Sort = e.SortString;
        }
    }

    private void cmbJumpToLocation_SelectedValueChanged(object sender, EventArgs e)
    {
        if (suspendEvents)
        {
            return;
        }

        suspendEvents = true;
        var comboBox = (ComboBox)sender;

        var value = (CityLatLonCoordinate)comboBox.SelectedItem;

        if (value != null)
        {
            nudLatitude.Value = (decimal)value.Latitude;
            nudLongitude.Value = (decimal)value.Longitude;
        }
        suspendEvents = false;

        FillDataGrid((double)nudLatitude.Value, (double)nudLongitude.Value, dtpMapDateTime.Value);
    }

    private void nudLongitude_ValueChanged(object sender, EventArgs e)
    {
        if (suspendEvents)
        {
            return;
        }

        FillDataGrid((double)nudLatitude.Value, (double)nudLongitude.Value, dtpMapDateTime.Value);
    }

    private void btGo_Click(object sender, EventArgs e)
    {
        FillDataGrid((double)nudLatitude.Value, (double)nudLongitude.Value, dtpMapDateTime.Value);
    }

    private void dtpMapDateTime_ValueChanged(object sender, EventArgs e)
    {
        if (suspendEvents)
        {
            return;
        }

        FillDataGrid((double)nudLatitude.Value, (double)nudLongitude.Value, dtpMapDateTime.Value);
    }

    private void imageButton2_Click(object sender, EventArgs e)
    {
        var dataText = adgSolarObjects.GetDelimitedData('\t');
        ClipboardAdder.SetClipboardText(dataText);
    }

    private void imageButton1_Click(object sender, EventArgs e)
    {
        if (sdCSV.ShowDialog() == DialogResult.OK)
        {
            try
            {
                File.WriteAllText(sdCSV.FileName, adgSolarObjects.GetDelimitedData('\t'));
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowError(DBLangEngine.GetMessage("msgFileSaveFailedError",
                    "Failed to save the data to the file '{0}' with error message of: '{1}'.|A file saving error occurred with the file name and exception message.", sdCSV.FileName,
                    ex.Message));
                return;
            }

            try
            {
                Process.Start("explorer.exe", sdCSV.FileName);
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowError(DBLangEngine.GetMessage("msgProcessStartFailed",
                    "Failed to start a process for the file '{0}' with error message of: '{1}'.|A process start error occurred with the file name and exception message.", sdCSV.FileName,
                    ex.Message));
            }
        }
    }
}