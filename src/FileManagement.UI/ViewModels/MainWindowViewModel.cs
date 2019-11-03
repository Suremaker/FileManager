using FileManagement.Domain;

namespace FileManagement.UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public DirectoryPanelViewModel Panel { get; }

        public MainWindowViewModel(IDirectoryNavigator directoryNavigator)
        {
            Panel = new DirectoryPanelViewModel(directoryNavigator);
        }
    }
}
