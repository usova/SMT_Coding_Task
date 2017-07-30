using System;

namespace FileImporter.BL.FileWatcher
{
    public delegate void FileAddedEventHandler(object sender, FileAddedEventArgs args);

    public class FileAddedEventArgs : EventArgs
    {
        public string FileFullName { get; set; }

        public string FileExtension { get; set; }

        public string Name { get; set; }
    }
}
