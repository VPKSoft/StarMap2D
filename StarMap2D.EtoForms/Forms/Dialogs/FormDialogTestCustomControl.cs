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
using StarMap2D.EtoForms.Controls;
using StarMap2D.Localization;

namespace StarMap2D.EtoForms.Forms.Dialogs;

/// <summary>
/// A dialog to test custom controls, etc.
/// Implements the <see cref="Eto.Forms.Dialog" />
/// </summary>
/// <seealso cref="Eto.Forms.Dialog" />
public class FormDialogTestCustomControl : Dialog
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FormDialogTestCustomControl"/> class.
    /// </summary>
    public FormDialogTestCustomControl()
    {
        MinimumSize = new Size(800, 600);
        Title = UI.TestStuff;
        Content = new TwilightVisualization();
    }
}