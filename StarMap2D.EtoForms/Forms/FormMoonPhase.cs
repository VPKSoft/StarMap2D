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

using AASharp;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Calculations.Constellations;
using StarMap2D.Calculations.Extensions;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.Calculations.MoonCalculations;
using StarMap2D.Common.SvgColorization;
using StarMap2D.EtoForms.ApplicationSettings.SettingClasses;
using StarMap2D.EtoForms.Classes;
using StarMap2D.EtoForms.Controls;
using StarMap2D.EtoForms.Controls.MoonCalendar;
using StarMap2D.EtoForms.Controls.Utilities;
using StarMap2D.EtoForms.Utility;
using StarMap2D.Localization;
using System;
using System.Linq;

namespace StarMap2D.EtoForms.Forms;

/// <summary>
/// A form to display the current moon phase.
/// Implements the <see cref="Eto.Forms.Form" />
/// </summary>
/// <seealso cref="Eto.Forms.Form" />
public class FormMoonPhase : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FormMoonPhase"/> class.
    /// </summary>
    public FormMoonPhase()
    {
        Title = UI.MoonPhase;

        MinimumSize = new Size(800, 600);

        btnPreviousDay = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_previous_24_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 10, ClickHandler, UI.PreviousDay);

        btnNextDay = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_next_24_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 10, ClickHandler, UI.NextDay);

        btnReset = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_calendar_today_28_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 10, ClickHandler, UI.CurrentDay);

        cbDiscTilt = new CheckBox { ThreeState = false, Text = UI.MoonDiscTilting, };
        cbDiscTilt.CheckedChanged += CbDiscTilt_CheckedChanged;

        dtpTimeMain = new DateTimePicker { Mode = DateTimePickerMode.DateTime, Value = DateTime.Now, };
        dtpTimeMain.ValueChanged += DtpTimeMain_ValueChanged;

        lbMoonPhaseName = new Label { TextColor = Globals.Settings.DateTextDefaultColor!.Value, Font = Globals.Settings.DataFont ?? SettingsFontData.Empty, };
        lbMoonIlluminatedPercentage = new Label { TextColor = Globals.Settings.DateTextDefaultColor!.Value, Font = Globals.Settings.DataFont ?? SettingsFontData.Empty, };
        lbMoonPhaseNumber = new Label { TextColor = Globals.Settings.DateTextDefaultColor!.Value, Font = Globals.Settings.DataFont ?? SettingsFontData.Empty, };
        lbMoonConstellation = new Label { TextColor = Globals.Settings.DateTextDefaultColor!.Value, Font = Globals.Settings.DataFont ?? SettingsFontData.Empty, };

        moonPhase = new MoonPhaseVisualization();

        Content = new TableLayout
        {
            Padding = 10,
            Rows =
            {
                EtoHelpers.TableWrap(true,
                    EtoHelpers.PaddingWrap(btnPreviousDay, Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(btnReset, Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(btnNextDay, Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(dtpTimeMain, Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(cbDiscTilt, Globals.DefaultPadding)),
                EtoHelpers.TableWrap(true,
                    EtoHelpers.LabelWrap(UI.MoonPhase, lbMoonPhaseName, Globals.DefaultPadding),
                    EtoHelpers.LabelWrap(MoonData.MoonIlluminated, lbMoonIlluminatedPercentage, Globals.DefaultPadding),
                    EtoHelpers.LabelWrap(MoonData.MoonPhaseNumber, lbMoonPhaseNumber, Globals.DefaultPadding),
                    EtoHelpers.LabelWrap("Moon constellation", lbMoonConstellation, Globals.DefaultPadding)),
                new TableRow
                {
                    Cells =
                    {
                        moonPhase,
                    },
                },
            },
        };

        CurrentDateTime = DateTime.UtcNow;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FormMoonPhase"/> class.
    /// </summary>
    /// <param name="dateTime">The date and time for the moon phase.</param>
    public FormMoonPhase(DateTime dateTime) : this()
    {
        CurrentDateTime = dateTime.ToUniversalTime();
    }

    private void CbDiscTilt_CheckedChanged(object? sender, EventArgs e)
    {
        if (cbDiscTilt.Checked == false)
        {
            moonPhase.MoonDiscTiltAngle = 0;
        }
    }

    private void DtpTimeMain_ValueChanged(object? sender, EventArgs e)
    {
        if (suspendEvents)
        {
            return;
        }
        CurrentDateTime = dtpTimeMain!.Value!.Value.ToLocalTime();
    }

    private bool suspendEvents;

    private void ClickHandler(object? sender, EventArgs e)
    {
        if (sender?.Equals(btnNextDay) == true)
        {
            var offset = DateTimeOffset.Now.Offset.TotalHours;
            CurrentDateTime = CurrentDateTime.AddDays(1).AddHours(offset);
        }

        if (sender?.Equals(btnPreviousDay) == true)
        {
            CurrentDateTime = CurrentDateTime.AddDays(-1);
        }

        if (sender?.Equals(btnReset) == true)
        {
            CurrentDateTime = DateTime.UtcNow;
        }
    }

    private DateTime CurrentDateTime
    {
        get => currentDateTime;

        set
        {
            if (value != currentDateTime)
            {
                suspendEvents = true;
                dtpTimeMain!.Value = value.ToLocalTime();
                suspendEvents = false;

                currentDateTime = value;

                var calculation = new MoonPhase(Globals.Settings.Latitude, Globals.Settings.Longitude)
                { StartTimeLocal = currentDateTime.ToLocalTime(), };

                moonPhase.MoonPhase = calculation.Phase;
                moonPhase.MoonIlluminatedFraction = calculation.MoonIlluminatedFraction;
                moonPhase.MoonDiscTiltAngle = cbDiscTilt.Checked == true ? calculation.MoonDiscTiltAngle : 0;
                lbMoonPhaseName!.Text = MoonPhaseLocalization.MoonPhaseName(calculation.PhaseValue);
                lbMoonIlluminatedPercentage!.Text = string.Format(Globals.FormattingCulture, "{0:F1}", moonPhase.MoonIlluminatedFraction * 100);
                lbMoonPhaseNumber!.Text = string.Format(Globals.FormattingCulture, "{0:F1}", moonPhase.MoonPhase);

                var aaDate = currentDateTime.ToAASDate();
                var jd = aaDate.Julian + AASDynamicalTime.DeltaT(aaDate.Julian) / 86400.0;
                var moonLong = AASMoon.EclipticLongitude(jd);
                var moonLat = AASMoon.EclipticLatitude(jd);

                var raDec = AASCoordinateTransformation.Ecliptic2Equatorial(moonLong, moonLat, AASNutation.TrueObliquityOfEcliptic(jd)); // RA/DEC

                //                var constellation = PointInConstellation.GetConstellationForPoint(raDec.X, raDec.Y);
                var constellation = PointInConstellation.GetConstellationForPoint(raDec.X, raDec.Y);

                lbMoonConstellation!.Text = constellation != null
                    ? ConstellationClassEnumNameMap.ConstellationClassesEnumsNames
                        .FirstOrDefault(f => f.Constellation == constellation)
                        ?.Name ?? UI.NAChar
                    : UI.NAChar;
            }
        }
    }

    private Button? btnPreviousDay;
    private Button? btnNextDay;
    private Button? btnReset;
    private DateTimePicker? dtpTimeMain;
    private DateTime currentDateTime = DateTime.UtcNow;
    private MoonPhaseVisualization moonPhase;
    private CheckBox cbDiscTilt;
    private Label? lbMoonPhaseName;
    private Label? lbMoonConstellation;
    private readonly Label? lbMoonIlluminatedPercentage;
    private readonly Label? lbMoonPhaseNumber;
}