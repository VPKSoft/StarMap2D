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
using System.Globalization;
using ChoETL;
using StarMap2D.Calculations.StaticData;

namespace StarMap2D.Forms;

/// <summary>
/// A form to display details of known objects (mostly planets).
/// Implements the <see cref="System.Windows.Forms.Form" />
/// </summary>
/// <seealso cref="System.Windows.Forms.Form" />
public partial class FormSolarSystemObjectsTable : Form
{
    private List<PlanetDataExtended> data = new();

    private DataTable table;

    /// <summary>
    /// Initializes a new instance of the <see cref="FormSolarSystemObjectsTable"/> class.
    /// </summary>
    public FormSolarSystemObjectsTable()
    {
        InitializeComponent();

        table = PlanetData.Data.Select(f => PlanetData.GetExtendedData(f.ObjectType,
            Properties.Settings.Default.Latitude, Properties.Settings.Default.Longitude, DateTime.UtcNow)).AsDataTable(null,
            CultureInfo.InvariantCulture, null,
            null, new[]
            {
                nameof(PlanetDataExtended.ObjectName),
                nameof(PlanetDataExtended.Longitude),
                nameof(PlanetDataExtended.Latitude),
            });


        var col = table.Columns[nameof(PlanetDataExtended.RightAscension)];

        advancedDataGridView1.DataSource = table;

        advancedDataGridView1.Columns[nameof(PlanetDataExtended.RightAscension)].DefaultCellStyle = new DataGridViewCellStyle
        {
            Alignment = DataGridViewContentAlignment.MiddleRight,
            Format = "N6",
            FormatProvider = CultureInfo.InvariantCulture,
        };

        foreach (DataGridViewColumn dataGridViewColumn in advancedDataGridView1.Columns)
        {
            dataGridViewColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewColumn.ReadOnly = true;
        }

        advancedDataGridView1.Columns[nameof(PlanetDataExtended.RightAscension)].SortMode =
            DataGridViewColumnSortMode.Automatic;
    }

    private void advancedDataGridView1_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
    {
        table.DefaultView.Sort = e.SortString;
    }
}