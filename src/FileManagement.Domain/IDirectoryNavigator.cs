using System.Collections.Generic;
using FileManagement.Domain.FileSystem;

namespace FileManagement.Domain
{
    public interface IDirectoryNavigator
    {
        string Path { get; }
        IReadOnlyList<DirectoryEntry> Entries { get; }
        void Cd(string path);
    }
}