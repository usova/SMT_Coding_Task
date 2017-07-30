using System;

namespace FileImporter.BL
{
    public delegate void FileTypeNotSupportedEventtHandler(object sender, FileTypeNotSupportedEventEventArgs args);

    public class FileTypeNotSupportedEventEventArgs : EventArgs
    {
        public string FileExtension { get; set; }
    }
}
