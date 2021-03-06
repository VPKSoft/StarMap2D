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
using AASharp;
using Eto.Drawing;
using Eto.Forms;
using StarMap2D.Calculations.Enumerations;
using StarMap2D.Calculations.Extensions;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.Calculations.RiseSet;
using StarMap2D.Common.SvgColorization;
using StarMap2D.EtoForms.ApplicationSettings.SettingClasses;
using StarMap2D.EtoForms.Classes;
using StarMap2D.EtoForms.Controls;
using StarMap2D.EtoForms.Controls.Plotting;
using StarMap2D.EtoForms.Controls.Utilities;
using StarMap2D.EtoForms.Forms;
using StarMap2D.EtoForms.Forms.Dialogs;
using StarMap2D.Localization;
using System.Linq;

namespace StarMap2D.EtoForms;

/// <summary>
/// The main window of the application.
/// Implements the <see cref="Eto.Forms.Form" />
/// </summary>
/// <seealso cref="Eto.Forms.Form" />
public class FormMain : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FormMain"/> class.
    /// </summary>
    public FormMain()
    {
        EtoForms.Controls.Globals.Font = Globals.Settings.Font ?? SettingsFontData.Empty;

        // Set the software localization.
        Localization.Globals.Culture = Globals.Locale;

        // Localize the constellation names.
        ConstellationClassEnumNameMap.GenerateData();

        EtoHelpers.IconLoadErrorMessage = Messages.FailedToLoadIconWithMessage0;
        EtoHelpers.ErrorDialogTitle = Messages.Error;

        // Set the icon for the form.
        EtoHelpers.SetIcon(this, EtoForms.Properties.Resources.StarMap2D);

        Title = UI.StarMap2D;
        MinimumSize = new Size(800, 600);

        plot = new TimeValuePlot { BackgroundColor = Colors.Black, DrawCrossHairs = true, };

        switch (Globals.Settings.MainChartDrawMode)
        {
            case 0:
                plot.RememberAxesMaximum = false;
                plot.UseStaticMinimumMaximum = false;
                break;
            case 1:
                plot.RememberAxesMaximum = true;
                plot.UseStaticMinimumMaximum = false;
                break;
            case 2:
                plot.UseStaticMinimumMaximum = true;
                plot.RememberAxesMaximum = false;
                break;
        }

        btnPreviousDay = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_previous_24_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 10, ClickHandler, UI.PreviousDay);

        btnNextDay = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_arrow_next_24_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 10, ClickHandler, UI.NextDay);

        btnReset = EtoHelpers.CreateImageButton(
            SvgColorize.FromBytes(EtoForms.Controls.Properties.Resources.ic_fluent_calendar_today_28_filled),
            Globals.Settings.UiIconsDefaultColor!.Value, 10, ClickHandler, UI.CurrentDay);

        dtpTimeMain = new DateTimePicker { Mode = DateTimePickerMode.Date, Value = DateTime.Now, };
        dtpTimeMain.ValueChanged += DtpTimeMain_ValueChanged;

        lbSunRiseValue = new Label();
        lbSunSetValue = new Label();
        lbDayLengthValue = new Label();
        lbMoonRiseValue = new Label();
        lbMoonSetValue = new Label();

        var color = Globals.Settings.DateTextDefaultColor!.Value;

        lbSunRise = new Label { Text = UI.SunRise, TextColor = color, Font = Globals.Settings.Font!, };
        lbSunSet = new Label { Text = UI.SunSet, TextColor = color, Font = Globals.Settings.Font!, };
        lbDayLength = new Label { Text = UI.DayLength, TextColor = color, Font = Globals.Settings.Font!, };
        lbMoonRise = new Label { Text = UI.MoonRise, TextColor = color, Font = Globals.Settings.Font!, };
        lbMoonSet = new Label { Text = UI.MoonSet, TextColor = color, Font = Globals.Settings.Font!, };

        Content = new TableLayout
        {
            Padding = 10,
            Rows =
            {
                EtoHelpers.TableWrap(true,
                    EtoHelpers.PaddingWrap(btnPreviousDay, Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(btnReset, Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(btnNextDay, Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(dtpTimeMain, Globals.DefaultPadding)),
                EtoHelpers.TableWrap(true,
                    EtoHelpers.PaddingWrap(EtoHelpers.TableWrapVertical(true, lbSunRise, lbSunRiseValue),
                        Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(EtoHelpers.TableWrapVertical(true, lbSunSet, lbSunSetValue),
                        Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(EtoHelpers.TableWrapVertical(true, lbDayLength, lbDayLengthValue),
                        Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(EtoHelpers.TableWrapVertical(true, lbMoonRise, lbMoonRiseValue),
                        Globals.DefaultPadding),
                    EtoHelpers.PaddingWrap(EtoHelpers.TableWrapVertical(true, lbMoonSet, lbMoonSetValue),
                        Globals.DefaultPadding)),
                new TableRow
                {
                    Cells =
                    {
                        plot,
                    },
                },
            },
        };

        // create a few commands that can be used for the menu and toolbar
        var starMapCommand = new Command
        {
            MenuText = UI.StarMap,
            ToolBarText = UI.StarMap,
            Image = EtoHelpers.ImageFromSvg(Globals.Settings.UiIconsDefaultColor!.Value,
            EtoForms.Controls.Properties.Resources.ic_fluent_star_48_filled, new Size(16, 16)),
        };
        starMapCommand.Executed += (_, _) => new FormSkyMap2D().Show();

        var settingsMenu = new Command
        {
            MenuText = UI.Settings,
            ToolBarText = UI.Settings,
            Image = EtoHelpers.ImageFromSvg(Globals.Settings.UiIconsDefaultColor!.Value,
            EtoForms.Controls.Properties.Resources.ic_fluent_settings_48_filled, new Size(16, 16)),
        };
        settingsMenu.Executed += (_, _) => new FormDialogSettings().ShowModal();

        var testStuff = new Command { MenuText = UI.TestStuff, };
        testStuff.Executed += delegate
        {
            new FormDialogTestCustomControl().ShowModal();
        };

        var quitCommand = new Command { MenuText = UI.Quit, Shortcut = Application.Instance.CommonModifier | Keys.Q, };
        quitCommand.Executed += (_, _) => Application.Instance.Quit();

        var aboutCommand = new Command { MenuText = UI.About, };
        aboutCommand.Executed += (_, _) => new AboutDialog().ShowDialog(this);

        var objectDetailsCommend = new Command
        {
            MenuText = UI.ObjectDetails,
            ToolBarText = UI.ObjectDetails,
            Image = EtoHelpers.ImageFromSvg(Globals.Settings.UiIconsDefaultColor!.Value,
            EtoForms.Controls.Properties.Resources.ic_fluent_document_bullet_list_24_filled, new Size(16, 16)),
        };
        objectDetailsCommend.Executed += (_, _) => new FormCelestialObjectData().Show();

        var moonPhaseCommand = new Command
        {
            MenuText = UI.MoonPhase,
            ToolBarText = UI.MoonPhase,
            Image = EtoHelpers.ImageFromSvg(Globals.Settings.UiIconsDefaultColor!.Value,
            EtoForms.Controls.Properties.Resources.ic_fluent_weather_moon_48_filled, new Size(16, 16)),
        };

        moonPhaseCommand.Executed += (_, _) => FormMoonPhase.ShowSingleton();

        var moonCalendarCommand = new Command
        {
            MenuText = UI.MoonCalendar,
            ToolBarText = UI.MoonCalendar,
            Image = EtoHelpers.ImageFromSvg(Globals.Settings.UiIconsDefaultColor!.Value,
                EtoForms.Controls.Properties.Resources.ic_fluent_calendar_month_28_filled, new Size(16, 16)),
        };

        moonCalendarCommand.Executed += (_, _) => new FormMoonPhaseCalendar().Show();

        windowMenu = new ButtonMenuItem { Text = UI.Window, };

        // create menu
        base.Menu = new MenuBar
        {
            Items =
            {
                // File submenu
                new SubMenuItem { Text = UI.TestStuff, Items = { testStuff, }, },
                windowMenu,
            },
            ApplicationItems =
            {
                starMapCommand,
                // application (OS X) or file menu (others)
            },
            QuitItem = quitCommand,
            AboutItem = aboutCommand,
        };

        base.Menu.HelpMenu.Text = UI.Help;
        base.Menu.ApplicationMenu.Text = UI.File;

        // create toolbar			
        ToolBar = new ToolBar
        {
            Items =
            {
                starMapCommand,
                new SeparatorToolItem(),
                settingsMenu,
                new SeparatorToolItem(),
                objectDetailsCommend,
                new SeparatorToolItem(),
                moonPhaseCommand,
                new SeparatorToolItem(),
                moonCalendarCommand,
            },
        };

        CurrentDateTime = DateTime.UtcNow;

        GotFocus += MainForm_GotFocus;
    }

    private void MainForm_GotFocus(object? sender, EventArgs e)
    {
        UpdateWindowMenu();
    }

    private void UpdateWindowMenu(Window? closingWindow = null)
    {
        windowMenu!.Items.Clear();
        foreach (var window in Application.Instance.Windows)
        {
            if (window.Equals(closingWindow) || !window.Visible || window.Equals(this))
            {
                continue;
            }

            windowMenu!.Items.Add(new Command((_, _) =>
            {
                window.BringToFront();
            })
            { MenuText = window.Title, });
        }

        windowMenu.Enabled = Application.Instance.Windows.Any();
    }

    private bool suspendDateTimeChange;

    private void DtpTimeMain_ValueChanged(object? sender, EventArgs e)
    {
        if (suspendDateTimeChange)
        {
            return;
        }

        CurrentDateTime = dtpTimeMain!.Value!.Value.ToUniversalTime();
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
    }

    private DateTime currentDateTime = DateTime.Now.Date;

    private DateTime CurrentDateTime
    {
        get => currentDateTime;

        set
        {
            var offset = DateTimeOffset.Now.Offset.TotalHours;
            var adjustedDate = new DateTime(value.Year, value.Month, value.Day, 0, 0, 0, DateTimeKind.Utc).AddHours(-offset);

            if (value != adjustedDate)
            {
                suspendDateTimeChange = true;
                dtpTimeMain!.Value = value.ToLocalTime();
                suspendDateTimeChange = false;

                var riseSetSun = new RiseSetPlanetsSunMoon(ObjectsWithPositions.Sun, Globals.Settings.Latitude,
                    Globals.Settings.Longitude, value, value.AddDays(1));

                lbSunRiseValue!.Text = riseSetSun.Rise?.ToLongTimeString() ?? UI.NAChar;
                lbSunSetValue!.Text = riseSetSun.Set?.ToLongTimeString() ?? UI.NAChar;
                lbDayLengthValue!.Text = riseSetSun.RiseSetSpan?.ToString(@"hh\:mm\:ss") ?? UI.NAChar;

                var riseSetMoon = new RiseSetPlanetsSunMoon(ObjectsWithPositions.Moon, Globals.Settings.Latitude,
                    Globals.Settings.Longitude, value, value.AddDays(1));

                lbMoonRiseValue!.Text = riseSetMoon.Rise?.ToLongTimeString() ?? UI.NAChar;
                lbMoonSetValue!.Text = riseSetMoon.Set?.ToLongTimeString() ?? UI.NAChar;

                currentDateTime = adjustedDate;
                PlotDateTime();
            }
        }
    }

    private void PlotDateTime()
    {
        plot!.AxisData.Clear();
        var ySunDoubles = new double[60 * 24];

        var yMoonDoubles = new double[60 * 24];

        var date = CurrentDateTime.ToAASDate();

        var longitude = Globals.Settings.Longitude;
        var latitude = Globals.Settings.Latitude;

        for (int i = 0; i < 60 * 24; i++)
        {
            date = date.AddSecondsFast(60);

            var position = SolarSystemObjectPositions.GetObjectPosition(AASEllipticalObject.SUN, date, false, longitude, latitude);
            ySunDoubles[i] = position.Y;

            position = SolarSystemObjectPositions.GetMoonPosition(date, true, longitude, latitude);
            yMoonDoubles[i] = position.Y;
        }

        plot.AxisData.Add(new AxisData
        {
            Values = ySunDoubles,
            XAxisWidth = 100,
            PlotColor = Colors.Orange,
            XAxisLabel = string.Format(Units.ObjectHeightDegreesAtHours, CelestialObjects.Sun),
        });

        plot.AxisData.Add(new AxisData
        {
            Values = yMoonDoubles,
            XAxisWidth = 100,
            PlotColor = Colors.SteelBlue,
            XAxisLabel = string.Format(Units.ObjectHeightDegreesAtHours, CelestialObjects.Moon),
        });
    }

    private Button? btnPreviousDay;
    private Button? btnNextDay;
    private Button? btnReset;
    private TimeValuePlot? plot;
    private DateTimePicker? dtpTimeMain;
    private Label? lbSunRiseValue;
    private Label? lbSunSetValue;
    private Label? lbDayLengthValue;
    private Label? lbMoonRiseValue;
    private Label? lbMoonSetValue;
    private ButtonMenuItem? windowMenu;

    private Label? lbSunRise;
    private Label? lbSunSet;
    private Label? lbDayLength;
    private Label? lbMoonRise;
    private Label? lbMoonSet;
}