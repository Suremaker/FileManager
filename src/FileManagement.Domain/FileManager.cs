using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FileManagement.Domain.FileSystem;

namespace FileManagement.Domain
{
    public class FileManager
    {
        public IReadOnlyList<DirectoryEntry> ScanDirectory(string path)
        {
            return new DirectoryInfo(path).EnumerateFileSystemInfos()
                .Select(i => new DirectoryEntry(
                    i.Name,
                    (i.Attributes & FileAttributes.Directory) != 0 ? FileType.Directory : FileType.File))
                .ToArray();
        }

        public string GetCurrentDirectory() => Environment.CurrentDirectory;
    }
}