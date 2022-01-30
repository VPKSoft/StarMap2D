using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using StarMap2D.Avalonia.Winfows;

namespace StarMap2D.Avalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
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

        private void Click(object? sender, RoutedEventArgs e)
        {
            new WindowSkyMap2D().Show();
        }
    }
}
