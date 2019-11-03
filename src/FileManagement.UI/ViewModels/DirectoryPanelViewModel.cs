using System.Collections.Generic;
using System.Xml.Serialization;
using ReactiveUI;

namespace FileManagement.UI.ViewModels
{
    public class DirectoryPanelViewModel : ViewModelBase
    {
        public string Path { get; } = "Some path";
        public IEnumerable<string> Entries { get; } = new[] {"file.txt", "dir"};
    }
}
