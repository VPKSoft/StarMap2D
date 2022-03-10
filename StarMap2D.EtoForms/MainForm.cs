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
using StarMap2D.Calculations.Extensions;
using StarMap2D.Calculations.Helpers.Math;
using StarMap2D.EtoForms.ApplicationSettings.SettingClasses;
using StarMap2D.EtoForms.Controls;
using StarMap2D.EtoForms.Controls.Plotting;
using StarMap2D.EtoForms.Controls.Utilities;
using StarMap2D.EtoForms.Forms;
using StarMap2D.EtoForms.Forms.Dialogs;
using StarMap2D.Localization;

namespace StarMap2D.EtoForms;

/// <summary>
/// The main window of the application.
/// Implements the <see cref="Eto.Forms.Form" />
/// </summary>
/// <seealso cref="Eto.Forms.Form" />
public class MainForm : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class.
    /// </summary>
    public MainForm()
    {
        EtoForms.Controls.Globals.Font = Globals.Settings.Font ?? SettingsFontData.Empty;

        // Set the software localization.
        UI.Culture = Globals.Locale;

        EtoHelpers.IconLoadErrorMessage = Messages.FailedToLoadIconWithMessage0;
        EtoHelpers.ErrorDialogTitle = Messages.Error;

        // Set the icon for the form.
        EtoHelpers.SetIcon(this, StarMap2D.EtoForms.Properties.Resources.StarMap2D);

        Title = UI.StarMap2D;
        MinimumSize = new Size(400, 300);

        var plot = new TimeValuePlot { BackgroundColor = Colors.Black, DrawCrossHairs = true };

        Content = new TableLayout
        {
            Padding = 10,
            Rows =
            {
                new TableRow
                {
                    Cells =
                    {
                        plot,
                    }
                },
            },
        };

        // create a few commands that can be used for the menu and toolbar
        var starMapCommand = new Command { MenuText = UI.StarMap, ToolBarText = UI.StarMap };
        starMapCommand.Executed += (_, _) => new FormSkyMap2D().Show();

        var settingsMenu = new Command { MenuText = UI.Settings, ToolBarText = UI.Settings };
        settingsMenu.Executed += (_, _) => new FormDialogSettings().ShowModal();

        var testStuff = new Command { MenuText = UI.TestStuff, };
        testStuff.Executed += delegate { new FormCelestialObjectData().Show(); };

        var quitCommand = new Command { MenuText = UI.Quit, Shortcut = Application.Instance.CommonModifier | Keys.Q };
        quitCommand.Executed += (_, _) => Application.Instance.Quit();

        var aboutCommand = new Command { MenuText = UI.About };
        aboutCommand.Executed += (_, _) => new AboutDialog().ShowDialog(this);

        // create menu
        base.Menu = new MenuBar
        {
            Items =
            {
                // File submenu
                new SubMenuItem { Text = UI.TestStuff, Items = { testStuff }},
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
        ToolBar = new ToolBar { Items = { starMapCommand, new SeparatorToolItem(), settingsMenu } };


        var ySunDoubles = new double[60 * 24];

        var yMoonDoubles = new double[60 * 24];

        var dateTime = DateTime.UtcNow;

        var offset = DateTimeOffset.Now.Offset.TotalHours;

        dateTime =
            new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0, DateTimeKind.Utc).AddHours(-offset);

        var date = dateTime.ToAASDate();

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

        plot.AxisData.Add(new AxisData { Values = ySunDoubles, XAxisWidth = 100, PlotColor = Colors.Orange });
        plot.AxisData.Add(new AxisData { Values = yMoonDoubles, XAxisWidth = 100, PlotColor = Colors.SteelBlue });
    }
}