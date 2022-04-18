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

namespace StarMap2D.EtoForms.Controls.Interfaces;

/// <summary>
/// An interface representing a single day cell in a calendar control.
/// </summary>
public interface ICalendarCell
{
    /// <summary>
    /// Gets or sets the calendar cell date.
    /// </summary>
    /// <value>The date.</value>
    DateOnly Date { get; set; }

    /// <summary>
    /// Gets or sets the calendar cell week number.
    /// </summary>
    /// <value>The week number.</value>
    int WeekNumber { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the calendar cell is the same month as the calendar control.
    /// </summary>
    /// <value><c>true</c> if the cell is the same month as the calendar control; otherwise, <c>false</c>.</value>
    bool CurrentMonth { get; set; }
}