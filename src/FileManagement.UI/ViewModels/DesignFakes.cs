using FileManagement.UI.ViewModels.Fakes;

namespace FileManagement.UI.ViewModels
{
    internal static class DesignFakes
    {
        public static MainWindowViewModel MainWindow { get; }
        public static DirectoryPanelViewModel DirectoryPanel { get; }
        static DesignFakes()
        {
            DirectoryPanel = new DirectoryPanelViewModel(FakeDirectoryNavigator.Instance);
            MainWindow = new MainWindowViewModel(FakeDirectoryNavigator.Instance);
        }
    }
}
