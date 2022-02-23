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

using Eto.Drawing;
using Eto.Forms;

namespace StarMap2D.Eto.Controls.Utilities
{
    /// <summary>
    /// Some helper methods for Eto.Forms.
    /// </summary>
    public class EtoHelpers
    {
        /// <summary>
        /// Creates a new <see cref="TableLayout"/> containing the specified control and a label with specified text.
        /// </summary>
        /// <param name="text">The text for the label.</param>
        /// <param name="control">The control.</param>
        /// <returns>A new instance to the <see cref="TableLayout"/> control.</returns>
        public static TableLayout LabelWrap(string text, Control control)
        {
            return new TableLayout(new TableRow(new TableCell(PaddingBottomWrap(new Label { Text = text }), true)),
                    new TableRow(new TableCell(control, true)))
            { Padding = new Padding(5) };
        }

        /// <summary>
        /// Creates a new <see cref="Panel"/> control and contains the specified control within
        /// the panel using the specified padding value as the bottom padding.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="padding">The padding to use.</param>
        /// <returns>A new instance to the <see cref="Panel"/> control.</returns>
        public static Panel PaddingBottomWrap(Control control, int padding = 5)
        {
            return new Panel { Content = control, Padding = new Padding(0, 0, 0, padding) };
        }

        /// <summary>
        /// Creates a new <see cref="Panel"/> control and contains the specified control within
        /// the panel using the specified padding.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="padding">The padding to use.</param>
        /// <returns>A new instance to the <see cref="Panel"/> control.</returns>
        public static Panel PaddingWrap(Control control, int padding = 5)
        {
            return new Panel { Content = control, Padding = new Padding(padding) };
        }
    }
}