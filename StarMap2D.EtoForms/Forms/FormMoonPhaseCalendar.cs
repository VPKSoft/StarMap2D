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
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Common.Utilities;
using StarMap2D.EtoForms.Controls.MoonCalendar;

namespace StarMap2D.EtoForms.Forms;

public class FormMoonPhaseCalendar : Form
{
    public FormMoonPhaseCalendar()
    {
        MinimumSize = new Size(800, 600);
        Content = CreateCalendarLayout();
    }

    private DateOnly calendarDate = DateOnly.FromDateTime(DateTime.Now);

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
        var result = new TableLayout();

        var startDate = CalendarStartDate.WeekStartDate();

        TableRow row;

        //            var size = new Size(Width / 7, Height / 5);
        //            var size = new Size(800 / 7, 600 / 5);

        for (var i = 0; i < 5; i++)
        {
            row = new TableRow { ScaleHeight = true, };
            result.Rows.Add(row);
            for (var j = 0; j < 7; j++)
            {
                //var moonPhase = new MoonPhase(Globals.Settings.Latitude, Globals.Settings.Longitude, startDate, startDate);

                row.Cells.Add(new TableCell(new MoonCalendarCell(DateOnly.FromDateTime(startDate),
                            Globals.Settings.Latitude, Globals.Settings.Longitude, false)
                        { Padding = Globals.DefaultPadding, })
                    { ScaleWidth = true, });

                //row.Cells.Add(new TableCell
                //{
                //    Control = new MoonPhaseVisualization
                //    {
                //        MoonIlluminatedFraction = moonPhase.MoonIlluminatedFraction,
                //        MoonPhase = moonPhase.Phase,
                //        //MinimumSize = size,

                //    },
                //    ScaleWidth = true,
                //});
                startDate = startDate.AddDays(1);
            }
            //                row.Cells.Add(new TableCell { ScaleWidth = true, });
        }

        //            result.Rows.Add(new TableRow { ScaleHeight = true, });

        return result;
    }
}