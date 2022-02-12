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

using System.ComponentModel;

namespace StarMap2D.Controls.WinForms;

/// <summary>
/// A control to select bot date and time at the same time.
/// Implements the <see cref="System.Windows.Forms.UserControl" />
/// </summary>
/// <seealso cref="System.Windows.Forms.UserControl" />
[DefaultEvent(nameof(DateAndTimePicker.ValueChanged))]
public partial class DateAndTimePicker : UserControl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DateAndTimePicker"/> class.
    /// </summary>
    public DateAndTimePicker()
    {
        InitializeComponent();
    }

    private bool showUpButton;

    /// <summary>
    /// Gets or sets a value indicating whether a spin button control (also known as an up-down control) is
    /// used to adjust the date/time value.
    /// </summary>
    /// <value><c>true</c> if a spin button control is used to adjust the date/time value; otherwise, <c>false</c>. The default is false.</value>
    [Category("Appearance")]
    [Description("Indicates whether a spin box rather than a drop-down calendar is displayed form modifying the control value.")]
    [Browsable(true)]
    public bool ShowUpButton
    {
        get => showUpButton;

        set
        {
            if (showUpButton != value)
            {
                dtpDate.ShowUpDown = value;
                dtpTime.ShowUpDown = value;
                showUpButton = value;
            }
        }
    }

    /// <summary>
    /// Gets or sets the date/time value assigned to the control.
    /// </summary>
    /// <value>The <see cref="DateTime"/> value assign to the control.</value>
    [Category("Behavior")]
    [Description("The current date/time value for this control.")]
    public DateTime Value
    {
        get => DateOnly.FromDateTime(dtpDate.Value).ToDateTime(TimeOnly.FromDateTime(dtpTime.Value));

        set
        {
            dtpDate.Value = new DateTime(value.Year, value.Month, value.Day);
            dtpTime.Value = new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute,
                value.Second);
        }
    }

    private void dtpDate_ValueChanged(object sender, EventArgs e)
    {
        ValueChanged?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>
    /// Occurs when the <see cref="Value"/> property changes.
    /// </summary>
    [Browsable(true)]
    [Category("Behavior")]
    [Description("Occurs when the value of the control changes.")]
    public event EventHandler? ValueChanged;
}