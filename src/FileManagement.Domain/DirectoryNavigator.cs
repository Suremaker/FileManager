using System;
using System.Collections.Generic;
using FileManagement.Domain.FileSystem;

namespace FileManagement.Domain
{
    public class DirectoryNavigator : IDirectoryNavigator
    {
        private readonly FileManager _manager;
        public string Path { get; private set; } = string.Empty;
        public IReadOnlyList<DirectoryEntry> Entries { get; private set; }

        public DirectoryNavigator(FileManager manager)
        {
            _manager = manager;
        }

        public void Cd(string path)
        {
            Entries = Array.Empty<DirectoryEntry>();
            Path = path;
            Entries = _manager.ScanDirectory(Path);
        }
    }
}
