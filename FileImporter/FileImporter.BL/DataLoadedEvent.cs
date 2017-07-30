using System;
using System.Collections.Generic;
using FileImporter.Common;

namespace FileImporter.BL
{
    public delegate void DataLoadedEventHandler(object sender, DataLoadedEventArgs args);

    public class DataLoadedEventArgs : EventArgs
    {
        public List<ImportedDataItem> LoadedData { get; set; }
    }
}
