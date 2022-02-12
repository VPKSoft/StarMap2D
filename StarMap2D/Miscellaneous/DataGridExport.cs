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

using System.Text;
using Zuby.ADGV;

namespace StarMap2D.Miscellaneous;

/// <summary>
/// A helper class for exporting the <see cref="Zuby.ADGV.AdvancedDataGridView"/> data into text format.
/// </summary>
public static class DataGridExport
{
    /// <summary>
    /// Gets the delimited data from the specified <see cref="AdvancedDataGridView"/> delimited with the specified delimiter.
    /// </summary>
    /// <param name="gridView">The grid view which data to export.</param>
    /// <param name="delimiter">The delimiter to use.</param>
    /// <returns>A string containing the delimited data of the <see cref="AdvancedDataGridView"/> instance.</returns>
    public static string GetDelimitedData(this AdvancedDataGridView gridView, char delimiter)
    {
        var builder = new StringBuilder();

        // First the header line.
        for (var i = 0; i < gridView.Columns.Count; i++)
        {
            builder.Append(gridView.Columns[i].HeaderText);
            if (i + 1 < gridView.Columns.Count)
            {
                builder.Append(delimiter);
            }
            else
            {
                builder.AppendLine();
            }
        }

        // Now the data cells.
        for (var i = 0; i < gridView.Rows.Count; i++)
        {
            for (var j = 0; j < gridView.Columns.Count; j++)
            {
                builder.Append(gridView.Rows[i].Cells[j].FormattedValue);

                if (j + 1 < gridView.Columns.Count)
                {
                    builder.Append(delimiter);
                }
                else
                {
                    builder.AppendLine();
                }
            }
        }

        return builder.ToString();
    }
}