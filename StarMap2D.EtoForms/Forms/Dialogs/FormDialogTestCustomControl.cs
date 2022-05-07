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
using StarMap2D.Calculations.Enumerations;
using StarMap2D.Calculations.RiseSet;
using StarMap2D.Common.SvgColorization;
using StarMap2D.EtoForms.Controls;
using StarMap2D.EtoForms.Controls.Utilities;
using StarMap2D.Localization;
using System;

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
        lat = 69.9;
        lon = 27.016667;

        //lat = Globals.Settings.Latitude;
        //lon = Globals.Settings.Longitude;

        var riseSetSun = new RiseSetPlanetsSunMoon(ObjectsWithPositions.Sun, lat,
            lon, CurrentDate, CurrentDate.AddDays(1));

        //var riseSetSun = new RiseSetPlanetsSunMoon(ObjectsWithPositions.Sun, Globals.Settings.Latitude,
        //    Globals.Settings.Longitude, CurrentDate, CurrentDate.AddDays(1));

        btnPreviousDay = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_previous_24_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 10, ClickHandler, UI.PreviousDay);

        btnNextDay = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_next_24_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 10, ClickHandler, UI.NextDay);

        btnCurrentDay = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_calendar_today_28_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 10, ClickHandler, UI.CurrentDay);

        lbCurrentDate = new Label { Text = CurrentDate.ToShortDateString() };

        MinimumSize = new Size(800, 600);
        Title = UI.TestStuff;
        twilightVisualization = new TwilightVisualization();
        Content = new TableLayout
        {
            Rows =
            {
                EtoHelpers.TableWrap(true,
                    EtoHelpers.PaddingWrap(btnPreviousDay, Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(btnCurrentDay, Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(btnNextDay, Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(lbCurrentDate, Globals.DefaultPadding)),
                twilightVisualization,
            },
        };

        twilightVisualization.SetValuesFromRiseSetData(riseSetSun);
    }

    private DateTime CurrentDate
    {
        get => currentDate;

        set
        {
            if (value != currentDate)
            {
                currentDate = value;
                var riseSetSun = new RiseSetPlanetsSunMoon(ObjectsWithPositions.Sun, lat,
                    lon, currentDate, currentDate.AddDays(1));

                lbCurrentDate.Text = currentDate.ToShortDateString();

                twilightVisualization.SetValuesFromRiseSetData(riseSetSun);
            }
        }
    }

    private void ClickHandler(object? sender, EventArgs e)
    {
        if (Equals(sender, btnCurrentDay))
        {
            CurrentDate = DateTime.Now;
        }
        else if (Equals(sender, btnNextDay))
        {
            CurrentDate = CurrentDate.AddDays(1);
        }
        else if (Equals(sender, btnPreviousDay))
        {
            CurrentDate = CurrentDate.AddDays(-1);
        }
    }

    private double lat, lon;

    private readonly Button btnPreviousDay;
    private readonly Button btnNextDay;
    private readonly Button btnCurrentDay;
    private readonly TwilightVisualization twilightVisualization;
    private DateTime currentDate = DateTime.Now;
    private Label lbCurrentDate;
}