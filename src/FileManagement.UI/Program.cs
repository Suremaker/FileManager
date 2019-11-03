using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using FileManagement.UI.ViewModels;
using FileManagement.UI.Views;

namespace FileManagement.UI
{
    class Program
    {
        public static void Main(string[] args) => BuildAvaloniaApp().Start(AppMain, args);

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToDebug()
                .UseReactiveUI();

        private static void AppMain(Application app, string[] args)
        {
            app.Run(new MainWindow { DataContext = new MainWindowViewModel() });
        }
    }
}
