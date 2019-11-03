using Avalonia;
using Avalonia.Logging.Serilog;
using FileManagement.Domain;
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
                .UseReactiveUI()
                .UseDataGrid();

        private static void AppMain(Application app, string[] args)
        {
            app.Run(new MainWindow { DataContext = InitializeModel() });
        }

        private static MainWindowViewModel InitializeModel()
        {
            var fileManager = new FileManager();
            var navigator = new DirectoryNavigator(fileManager);
            navigator.Cd(fileManager.GetCurrentDirectory());

            return new MainWindowViewModel(navigator);
        }
    }
}
