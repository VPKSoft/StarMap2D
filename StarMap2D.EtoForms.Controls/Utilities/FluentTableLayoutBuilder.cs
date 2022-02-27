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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eto.Forms;

namespace StarMap2D.EtoForms.Controls.Utilities
{
    public class FluentTableLayoutBuilder
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="FluentTableLayoutBuilder"/> class from being created.
        /// </summary>
        private FluentTableLayoutBuilder()
        {

        }

        public TableLayout? RootTableLayout { get; set; }

        public static FluentTableLayoutBuilder New()
        {
            var result = new FluentTableLayoutBuilder();

            result.RootTableLayout = new TableLayout();

            return result;
        }

        public FluentTableLayoutBuilder WithRow(int spacing, params Control[] controls)
        {

            var tableRow = new TableRow();

            for (int i = 0; i < controls.Length; i++)
            {
                if (i + 1 < controls.Length)
                {
                    tableRow.Cells.Add(new TableCell(controls[i]));
                    tableRow.Cells.Add(new Panel { Width = spacing });
                }
                else
                {
                    tableRow.Cells.Add(new TableCell(controls[i]));
                }
            }

            RootTableLayout!.Rows.Add(new TableRow(new TableCell(new TableLayout(tableRow))));

            return this;
        }

        public FluentTableLayoutBuilder WithEmptyRow()
        {
            RootTableLayout!.Rows.Add(new TableRow { ScaleHeight = true });
            return this;
        }

        public TableLayout GetTable()
        {
            return RootTableLayout!;
        }
    }
}