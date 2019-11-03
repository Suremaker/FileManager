using System.Collections.Generic;
using FileManagement.Domain;
using FileManagement.Domain.FileSystem;

namespace FileManagement.UI.ViewModels.Fakes
{
    internal class FakeDirectoryNavigator : IDirectoryNavigator
    {
        public static FakeDirectoryNavigator Instance { get; } = new FakeDirectoryNavigator();
        public string Path { get; } = "c:\\some\\path";
        public IReadOnlyList<DirectoryEntry> Entries { get; } = new[]
        {
            new DirectoryEntry("my dir", FileType.Directory),
            new DirectoryEntry("my file.txt", FileType.File)
        };

        public void Cd(string path)
        {
        }
    }
}
