using System;
using System.ComponentModel;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StarMap2D.Avalonia.Winfows
{
    public partial class WindowSkyMap2D : Window
    {
        public WindowSkyMap2D()
        {
            InitializeComponent();

#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
