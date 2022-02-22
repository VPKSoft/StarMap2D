using Eto.Drawing;
using Eto.Forms;
using System;
using StarMap2D.Eto.Controls;
using StarMap2D.Eto.Forms;
using Xceed.Wpf.AvalonDock.Properties;

namespace StarMap2D.Eto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Title = Localization.UI.StarMap2D;
            MinimumSize = new Size(400, 300);

            Content = new StackLayout
            {
                Padding = 10,
                Items =
                {
                    "Hello World!",
                    // add more controls here
                }
            };

            // create a few commands that can be used for the menu and toolbar
            var clickMe = new Command { MenuText = "Star map", ToolBarText = "Star map" };
            clickMe.Executed += (sender, e) => new FormSkyMap2D().Show();
            //            clickMe.Executed += (sender, e) => MessageBox.Show(this, "I was clicked!");

            var settingsMenu = new Command { MenuText = "Settings", ToolBarText = "Settings" };
            settingsMenu.Executed += (sender, e) => new FormDialogSettings().ShowModal();


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
					new SubMenuItem { Text = "&File", Items = { clickMe } },
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
            ToolBar = new ToolBar { Items = { clickMe } };
        }
    }
}
