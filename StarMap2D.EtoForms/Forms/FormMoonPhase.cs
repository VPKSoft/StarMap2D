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
using System.Threading;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Calculations.MoonCalculations;
using StarMap2D.Common.SvgColorization;
using StarMap2D.EtoForms.Controls;
using StarMap2D.EtoForms.Controls.Utilities;
using StarMap2D.Localization;

namespace StarMap2D.EtoForms.Forms
{
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
            MinimumSize = new Size(800, 600);

            btnPreviousDay = EtoHelpers.CreateImageButton(
                SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_previous_24_filled),
                Colors.SteelBlue, 10, ClickHandler, UI.PreviousDay);

            btnNextDay = EtoHelpers.CreateImageButton(
                SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_next_24_filled),
                Colors.SteelBlue, 10, ClickHandler, UI.NextDay);

            btnReset = EtoHelpers.CreateImageButton(
                SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_calendar_today_28_filled),
                Colors.SteelBlue, 10, ClickHandler, UI.CurrentDay);

            btnTestMoon = EtoHelpers.CreateImageButton(
                SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_weather_moon_48_filled),
                Colors.SteelBlue, 10, ClickHandler, UI.TestStuff);

            dtpTimeMain = new DateTimePicker { Mode = DateTimePickerMode.DateTime, Value = DateTime.Now, };
            dtpTimeMain.ValueChanged += DtpTimeMain_ValueChanged;

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
                        EtoHelpers.PaddingWrap(btnTestMoon, Globals.DefaultPadding)),
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

        private void DtpTimeMain_ValueChanged(object? sender, EventArgs e)
        {
            CurrentDateTime = dtpTimeMain!.Value!.Value.ToLocalTime();
        }

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

            if (sender?.Equals(btnTestMoon) == true)
            {
                for (var i = 0.0; i <= 1.0; i += 0.01)
                {
                    moonPhase.MoonPhase = i;
                    Application.Instance.RunIteration();
                    Thread.Sleep(250);
                }
            }
        }

        private DateTime CurrentDateTime
        {
            get => currentDateTime;

            set
            {
                if (value != currentDateTime)
                {
                    currentDateTime = value;

                    var calculation = new MoonPhase(Globals.Settings.Latitude, Globals.Settings.Longitude)
                    { StartTimeLocal = currentDateTime.ToLocalTime(), };

                    moonPhase.MoonPhase = calculation.Phase;
                    moonPhase.MoonIlluminatedFraction = calculation.MoonIlluminatedFraction;
                }
            }
        }

        private Button? btnPreviousDay;
        private Button? btnNextDay;
        private Button? btnReset;
        private Button? btnTestMoon;
        private DateTimePicker? dtpTimeMain;
        private DateTime currentDateTime = DateTime.UtcNow;
        private MoonPhaseVisualization moonPhase;
    }
}