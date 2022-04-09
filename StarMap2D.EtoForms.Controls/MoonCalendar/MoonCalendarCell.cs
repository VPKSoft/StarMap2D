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
using StarMap2D.Calculations.MoonCalculations;
using StarMap2D.Common.Utilities;
using StarMap2D.EtoForms.Controls.Interfaces;
using StarMap2D.EtoForms.Controls.Utilities;

namespace StarMap2D.EtoForms.Controls.MoonCalendar
{
    /// <summary>
    /// A control to represent a single cell in a moon calendar.
    /// Implements the <see cref="Eto.Forms.Panel" />
    /// Implements the <see cref="StarMap2D.EtoForms.Controls.Interfaces.ICalendarCell" />
    /// </summary>
    /// <seealso cref="Eto.Forms.Panel" />
    /// <seealso cref="StarMap2D.EtoForms.Controls.Interfaces.ICalendarCell" />
    public class MoonCalendarCell : Panel, ICalendarCell
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoonCalendarCell"/> class.
        /// </summary>
        /// <param name="date">The date for the moon phase calculation.</param>
        /// <param name="latitude">The latitude of the observer for the moon phase calculation.</param>
        /// <param name="longitude">The longitude of the observer for the moon phase calculation.</param>
        /// <param name="useMoonTilt">if set to <c>true</c> draw the moon phase disc tilt angle.</param>
        public MoonCalendarCell(DateOnly date, double latitude, double longitude, bool useMoonTilt)
        {
            var lbDate = new Label();
            var lbRise = new Label();
            var lbSet = new Label();

            Date = date;

            var moonPhase = new MoonPhase(latitude, longitude, Date.Value.ToDateTime(), Date.Value.ToDateTime());

            lbDate.Text = date.ToString("d.M");
            lbRise.Text = moonPhase.RiseDateTime?.ToString("HH:mm") ?? NaText;
            lbSet.Text = moonPhase.SetDateTime?.ToString("HH:mm") ?? NaText;

            Content = new TableLayout
            {
                Rows =
                {
                    EtoHelpers.TableWrap(true,
                        lbDate,
                        new SvgImageView(
                            StarMap2D.EtoForms.Controls.Properties.Resources.ic_fluent_arrow_sort_up_24_filled,
                            Colors.SteelBlue) { Size = new Size(16, 16) },
                        lbRise,
                        new SvgImageView(
                            StarMap2D.EtoForms.Controls.Properties.Resources.ic_fluent_arrow_sort_down_24_filled,
                            Colors.SteelBlue) { Size = new Size(16, 16) },
                        lbSet),
                    new TableRow(
                        new MoonPhaseVisualization
                        {
                            MoonPhase = moonPhase.Phase,
                            MoonIlluminatedFraction = moonPhase.MoonIlluminatedFraction,
                            MoonDiscTiltAngle = useMoonTilt ? moonPhase.MoonDiscTiltAngle : 0,
                        }) { ScaleHeight = true, },
                },
            };

            base.ToolTip = date.ToString("d.M") + "\n" +
                      $"{RiseText}: {moonPhase.RiseDateTime?.ToString("HH:mm") ?? NaText}, {SetText}: {moonPhase.SetDateTime?.ToString("HH:mm") ?? NaText}" +
                      "\n" +
                      $"{MoonDiscIlluminationPercentageText}: {moonPhase.MoonIlluminatedFraction * 100:F1}";
        }

        /// <summary>
        /// Gets or sets the N/A (Not Available) text.
        /// </summary>
        /// <value>The N/A text.</value>
        public static string NaText { get; set; } = "-";

        /// <summary>
        /// Gets or sets the rise text.
        /// </summary>
        /// <value>The rise text.</value>
        public static string RiseText { get; set; } = "Rise";

        /// <summary>
        /// Gets or sets the set text.
        /// </summary>
        /// <value>The set text.</value>
        public static string SetText { get; set; } = "Set";

        /// <summary>
        /// Gets or sets the moon disc illumination percentage text.
        /// </summary>
        /// <value>The moon disc illumination percentage text.</value>
        public static string MoonDiscIlluminationPercentageText { get; set; } = "Illumination-%";

        /// <inheritdoc cref="ICalendarCell.Date"/>
        public DateOnly? Date { get; set; }

        /// <inheritdoc cref="ICalendarCell.WeekNumber"/>
        public int WeekNumber { get; set; }

        /// <inheritdoc cref="ICalendarCell.CurrentMonth"/>
        public bool CurrentMonth { get; set; }
    }
}