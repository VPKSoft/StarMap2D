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
/// Extension methods for the <see cref="Zuby.ADGV.AdvancedDataGridView"/> control.
/// </summary>
public static class DataGridExtensions
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
            if (!gridView.Columns[i].Visible)
            {
                continue;
            }

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
                if (!gridView.Columns[j].Visible)
                {
                    continue;
                }

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

    /// <summary>
    /// Gets the column save data for the grid columns.
    /// </summary>
    /// <param name="gridView">The grid view.</param>
    /// <returns>A data string to save to allow restoring the column layout.</returns>
    public static string GetColumnSaveData(this AdvancedDataGridView gridView)
    {
        var builder = new StringBuilder();
        for (var i = 0; i < gridView.Columns.Count; i++)
        {
            builder.Append(
                $"{gridView.Columns[i].DisplayIndex};{gridView.Columns[i].Index};{gridView.Columns[i].Visible};{gridView.Columns[i].Width}");
            if (i + 1 < gridView.Columns.Count)
            {
                builder.Append('|');
            }
        }

        return builder.ToString();
    }

    /// <summary>
    /// Restores the grid column layout from the saved column data.
    /// </summary>
    /// <param name="gridView">The grid view.</param>
    /// <param name="restoreValue">The restore value.</param>
    public static void RestoreSavedColumnData(this AdvancedDataGridView gridView, string restoreValue)
    {
        if (string.IsNullOrWhiteSpace(restoreValue))
        {
            return;
        }

        try
        {
            var restoreData = restoreValue.Split('|').Select(f => new
            {
                DisplayIndex = int.Parse(f.Split(';')[0]),
                Index = int.Parse(f.Split(';')[1]),
                Visible = bool.Parse(f.Split(';')[2]),
                Width = int.Parse(f.Split(';')[3]),
            }).OrderByDescending(f => f.DisplayIndex).ToList();

            foreach (var data in restoreData)
            {
                if (data.Index < gridView.Columns.Count && data.DisplayIndex < gridView.Columns.Count)
                {
                    gridView.Columns[data.Index].DisplayIndex = data.DisplayIndex;
                    gridView.Columns[data.Index].Width = data.Width;
                    gridView.Columns[data.Index].Visible = data.Visible;
                }
            }
        }
        catch
        {
            // The linq failed.
        }
    }
}