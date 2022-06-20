using System;

namespace Task2
{
    internal class FileInformation
    {
        public string Name { get; }
        public string Extension { get; }
        public string DirectoryName { get; }
        public long Length { get; }
        public DateTime CreationTime { get; }
        public DateTime LastWriteTime { get; }

        public FileInformation(string name, string extension, string directoryName, long length, DateTime creationTime, DateTime lastWriteTime)
        {
            Name = name;
            Extension = extension;
            DirectoryName = directoryName;
            Length = length;
            CreationTime = creationTime;
            LastWriteTime = lastWriteTime;
        }

        public override bool Equals(object obj)
        {
            return obj is FileInformation other &&
                   Name == other.Name &&
                   Extension == other.Extension &&
                   DirectoryName == other.DirectoryName &&
                   Length == other.Length &&
                   CreationTime == other.CreationTime &&
                   LastWriteTime == other.LastWriteTime;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Extension, DirectoryName, Length, CreationTime, LastWriteTime);
        }
    }
}
