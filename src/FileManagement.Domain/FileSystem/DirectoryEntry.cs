namespace FileManagement.Domain.FileSystem
{
    public class DirectoryEntry
    {
        public DirectoryEntry(string name, FileType type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public FileType Type { get; }
    }
}
