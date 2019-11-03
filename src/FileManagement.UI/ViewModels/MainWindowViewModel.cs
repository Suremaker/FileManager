namespace FileManagement.UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public DirectoryPanelViewModel Panel { get; }

        public MainWindowViewModel()
        {
            Panel = new DirectoryPanelViewModel();
        }
    }
}
