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
using StarMap2D.Common.SvgColorization;
using StarMap2D.Common.Utilities;
using StarMap2D.EtoForms.Controls.MoonCalendar;
using StarMap2D.EtoForms.Controls.Utilities;
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

        calendarLayout = CreateCalendarLayout();

        btnPreviousMonth = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_previous_24_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 10, ClickHandler, UI.PreviousMonth);

        btnNextMonth = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_next_24_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 10, ClickHandler, UI.NextMonth);

        btnResetMonth = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_calendar_today_28_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 10, ClickHandler, UI.CurrentMonth);


        Content = new TableLayout
        {
            Rows =
            {
                EtoHelpers.TableWrap(true,
                    EtoHelpers.PaddingWrap(btnPreviousMonth, Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(btnNextMonth, Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(btnResetMonth, Globals.DefaultPadding)),
                calendarLayout,
            },
        };
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
                    calendarLayout = CreateCalendarLayout();

                    Content = new TableLayout
                    {
                        Rows =
                        {
                            EtoHelpers.TableWrap(true,
                                EtoHelpers.PaddingWrap(btnPreviousMonth!, Globals.DefaultPadding),
                                EtoHelpers.PaddingWrap(btnNextMonth!, Globals.DefaultPadding),
                                EtoHelpers.PaddingWrap(btnResetMonth!, Globals.DefaultPadding)),
                            calendarLayout,
                        },
                    };
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
        var month = calendarDate.Month;

        for (var i = 0; i < 5; i++)
        {
            var row = new TableRow { ScaleHeight = true, };
            result.Rows.Add(row);
            for (var j = 0; j < 7; j++)
            {
                //var moonPhase = new MoonPhase(Globals.Settings.Latitude, Globals.Settings.Longitude, startDate, startDate);

                row.Cells.Add(new TableCell(new MoonCalendarCell(
                            DateOnly.FromDateTime(startDate),
                    Globals.Settings.Latitude, Globals.Settings.Longitude,
                    false, month, FormMoonPhase.ShowSingleton)
                {
                    Padding = Globals.DefaultPadding,
                    IndicatorImageColor = Globals.Settings.UiIconsDefaultColor!.Value,
                    IndicatorImageColorActive = Globals.Settings.UiIconsDefaultColor!.Value,
                })
                { ScaleWidth = true, });
                startDate = startDate.AddDays(1);
            }
        }

        return result;
    }

    private void ClickHandler(object? sender, EventArgs e)
    {
        if (sender?.Equals(btnNextMonth) == true)
        {

            CalendarDate = CalendarDate.AddMonths(1);
        }

        if (sender?.Equals(btnPreviousMonth) == true)
        {
            CalendarDate = CalendarDate.AddMonths(-1);
        }

        if (sender?.Equals(btnResetMonth) == true)
        {
            CalendarDate = DateOnly.FromDateTime(DateTime.Now);
        }
    }


    private TableLayout? calendarLayout;
    private readonly Button? btnPreviousMonth;
    private readonly Button? btnNextMonth;
    private readonly Button? btnResetMonth;
}