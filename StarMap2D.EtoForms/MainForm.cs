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
using StarMap2D.EtoForms.ApplicationSettings.SettingClasses;
using StarMap2D.EtoForms.Forms;
using StarMap2D.EtoForms.Forms.Dialogs;
using StarMap2D.Localization;

namespace StarMap2D.EtoForms
{
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

            Title = UI.StarMap2D;
            MinimumSize = new Size(400, 300);

            Content = new StackLayout
            {
                Padding = 10,
                Items =
                {
                    // add more controls here
                }
            };

            // create a few commands that can be used for the menu and toolbar
            var starMapCommand = new Command { MenuText = UI.StarMap, ToolBarText = UI.StarMap };
            starMapCommand.Executed += (_, _) => new FormSkyMap2D().Show();

            var settingsMenu = new Command { MenuText = UI.Settings, ToolBarText = UI.Settings };
            settingsMenu.Executed += (_, _) => new FormDialogSettings().ShowModal();

            var testStuff = new Command { MenuText = "Test something", };
            testStuff.Executed += delegate { new FormDialogCelestialObject().ShowModal(); };

            var quitCommand = new Command { MenuText = "Quit", Shortcut = Application.Instance.CommonModifier | Keys.Q };
            quitCommand.Executed += (_, _) => Application.Instance.Quit();

            var aboutCommand = new Command { MenuText = "About..." };
            aboutCommand.Executed += (sender, e) => new AboutDialog().ShowDialog(this);

            // create menu
            base.Menu = new MenuBar
            {
                Items =
                {
					// File submenu
					new SubMenuItem { Text = "&File", Items = { starMapCommand } },
                    new SubMenuItem { Text = "Test stuff", Items = { testStuff }},
					// new SubMenuItem { Text = "&Edit", Items = { /* commands/items */ } },
					// new SubMenuItem { Text = "&View", Items = { /* commands/items */ } },
				},
                ApplicationItems =
                {
					// application (OS X) or file menu (others)
					new ButtonMenuItem { Text = "&Preferences...", Items = { settingsMenu }},
                },
                QuitItem = quitCommand,
                AboutItem = aboutCommand,
            };

            // create toolbar			
            ToolBar = new ToolBar { Items = { starMapCommand, new SeparatorToolItem(), settingsMenu } };
        }
    }
}
