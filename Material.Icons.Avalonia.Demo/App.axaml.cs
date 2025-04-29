using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Input.Platform;
using Avalonia.Markup.Xaml;
using Material.Icons.Avalonia.Demo.ViewModels;
using Material.Icons.Avalonia.Demo.Views;

namespace Material.Icons.Avalonia.Demo {
    public class App : Application {
        public override void Initialize() {
            AvaloniaXamlLoader.Load(this);
        }

        public static IClipboard Clipboard { get; private set; } = null!;

        public override void OnFrameworkInitializationCompleted() {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
                desktop.MainWindow = new MainWindow {
                    DataContext = new MainWindowViewModel(),
                };

                Clipboard = desktop.MainWindow.Clipboard!;
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
