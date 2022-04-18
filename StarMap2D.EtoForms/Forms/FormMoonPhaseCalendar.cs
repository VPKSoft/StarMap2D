﻿#region License
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
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Common.Utilities;
using StarMap2D.EtoForms.Controls.MoonCalendar;
using StarMap2D.Localization;

namespace StarMap2D.EtoForms.Forms;

/// <summary>
/// A form to display a moon phase calendar.
/// Implements the <see cref="Eto.Forms.Form" />
/// </summary>
/// <seealso cref="Eto.Forms.Form" />
public class FormMoonPhaseCalendar : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FormMoonPhaseCalendar"/> class.
    /// </summary>
    public FormMoonPhaseCalendar()
    {
        MinimumSize = new Size(800, 600);

        // Localize the MoonCalendarCell component.
        MoonCalendarCell.SetText = UI.Set;
        MoonCalendarCell.RiseText = UI.Rise;
        MoonCalendarCell.DateText = UI.Date;
        MoonCalendarCell.NaText = UI.NAChar;

        Content = CreateCalendarLayout();
    }

    private DateOnly calendarDate = DateOnly.FromDateTime(DateTime.Now);

    /// <summary>
    /// Gets or sets the calendar date.
    /// </summary>
    /// <value>The calendar date.</value>
    public DateOnly CalendarDate
    {
        get => calendarDate;

        set
        {
            if (value != calendarDate)
            {
                var monthChanged = value.Month != calendarDate.Month || value.Year != calendarDate.Year;

                calendarDate = value;
                if (monthChanged)
                {
                    Content = CreateCalendarLayout();
                }
            }
        }
    }

    private DateTime CalendarStartDate => new(calendarDate.Year, calendarDate.Month, 1);

    private TableLayout CreateCalendarLayout()
    {
        Title = string.Format(UI.MoonCalendar0, CalendarDate.ToString("MM/yyyy", Globals.Locale));

        var result = new TableLayout();

        var startDate = CalendarStartDate.WeekStartDate();

        for (var i = 0; i < 5; i++)
        {
            TableRow row = new TableRow { ScaleHeight = true, };
            result.Rows.Add(row);
            for (var j = 0; j < 7; j++)
            {
                //var moonPhase = new MoonPhase(Globals.Settings.Latitude, Globals.Settings.Longitude, startDate, startDate);

                row.Cells.Add(new TableCell(new MoonCalendarCell(DateOnly.FromDateTime(startDate),
                            Globals.Settings.Latitude, Globals.Settings.Longitude, false, time => new FormMoonPhase(time).Show())
                { Padding = Globals.DefaultPadding, })
                { ScaleWidth = true, });
                startDate = startDate.AddDays(1);
            }
        }

        return result;
    }
}