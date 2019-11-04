using System.Collections.Generic;
using FileManagement.Domain;
using FileManagement.Domain.FileSystem;

namespace FileManagement.UI.ViewModels
{
    public class DirectoryPanelViewModel : ViewModelBase
    {
        private readonly IDirectoryNavigator _navigator;

        public DirectoryPanelViewModel(IDirectoryNavigator directoryNavigator)
        {
            _navigator = directoryNavigator;
        }

        public string Path  => _navigator.Path;
        public IEnumerable<DirectoryEntry> Entries => _navigator.Entries;

        public void OnEnter(DirectoryEntry entry)
        {

        }
    }
}
