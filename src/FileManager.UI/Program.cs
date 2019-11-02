using System;
using Avalonia;
using Avalonia.Logging.Serilog;

namespace FileManager.UI
{
    class Program
    {
        public static void Main(string[] args) => BuildAvaloniaApp().Start(AppMain, args);

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToDebug();

        private static void AppMain(Application app, string[] args)
        {
            app.Run(new MainWindow());
        }
    }
}
