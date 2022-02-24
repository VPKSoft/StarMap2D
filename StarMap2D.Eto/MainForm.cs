using Eto.Drawing;
using Eto.Forms;
using System;
using StarMap2D.Common.SvgColorization;
using StarMap2D.Eto.Controls;
using StarMap2D.Eto.Controls.Utilities;
using StarMap2D.Eto.Forms;
using StarMap2D.Localization;
using Xceed.Wpf.AvalonDock.Properties;

namespace StarMap2D.Eto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
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


            var quitCommand = new Command { MenuText = "Quit", Shortcut = Application.Instance.CommonModifier | Keys.Q };
            quitCommand.Executed += (sender, e) => Application.Instance.Quit();

            var aboutCommand = new Command { MenuText = "About..." };
            aboutCommand.Executed += (sender, e) => new AboutDialog().ShowDialog(this);

            // create menu
            base.Menu = new MenuBar
            {
                Items =
                {
					// File submenu
					new SubMenuItem { Text = "&File", Items = { starMapCommand } },
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
