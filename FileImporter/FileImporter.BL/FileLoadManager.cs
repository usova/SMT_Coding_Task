using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FileImporter.BL.FileWatcher;
using FileImporter.Common;

namespace FileImporter.BL
{
    public class FileLoadManager
    {
        private IFileWatcher fileWatcher;
        private ILoaderFactory loaderFactory;

        private Dictionary<string, HashSet<string>> unsupportedFiles = new Dictionary<string, HashSet<string>>();

        public event DataLoadedEventHandler DataLoaded = delegate { };
        public event FileTypeNotSupportedEventtHandler FileNotSupported = delegate { };

        public FileLoadManager(ILoaderFactory loaderFactory)
        {
            if (loaderFactory == null)
                throw new ArgumentNullException(nameof(loaderFactory));

            this.loaderFactory = loaderFactory;
        }

        public void StartMonitoring(IFileWatcher fileWatcher)
        {
            if (fileWatcher == null)
                throw new ArgumentNullException(nameof(fileWatcher));

            this.fileWatcher = fileWatcher;
            this.fileWatcher.FileAdded += FileWatcher_FileAdded;

            fileWatcher.Start();
        }

        public void StopMonitoring()
        {
            fileWatcher.Stop();
            fileWatcher.FileAdded -= FileWatcher_FileAdded;
            fileWatcher = null;
        }

        public bool TryAddPlugin(string pluginPath)
        {
            if (!loaderFactory.ValidatePlugin(pluginPath))
                return false;

            ILoader loader = null;

            try
            {
                loader = loaderFactory.AddPlugin(pluginPath);
            }
            catch (Exception)
            {
                return false;
            }

            if (loader == null)
                return false;

            if (unsupportedFiles.ContainsKey(loader.SupportedExtension))
            {
                Parallel.ForEach(
                    unsupportedFiles[loader.SupportedExtension],
                    fileName => LoadDataFromFile(loader, fileName));
            }

            return true;
        }

        private void FileWatcher_FileAdded(object sender, FileAddedEventArgs args)
        {
            var loader = loaderFactory.GetLoader(args.FileExtension);

            if (loader == null)
            {
                AddFileToUnsupported(args.FileFullName);
                return;
            }

            LoadDataFromFile(loader, args.FileFullName);
        }

        private async void LoadDataFromFile(ILoader loader, string fileName)
        {
            var dataItems = await loader.LoadAsync(fileName);

            OnDataLoaded(dataItems);
        }

        private void OnDataLoaded(List<ImportedDataItem> dataItems)
        {
            DataLoaded?.Invoke(
                this,
                new DataLoadedEventArgs
                {
                    LoadedData = dataItems
                });
        }

        private void OnFileNotSupported(string fileExtension)
        {
            FileNotSupported?.Invoke(
                this,
                new FileTypeNotSupportedEventEventArgs
                {
                    FileExtension = fileExtension
                });
        }

        private void AddFileToUnsupported(string filePath)
        {
            var fileExtension = Path.GetExtension(filePath);

            if (!unsupportedFiles.ContainsKey(fileExtension))
            {
                unsupportedFiles[fileExtension] = new HashSet<string>();
                OnFileNotSupported(fileExtension);
            }

            unsupportedFiles[fileExtension].Add(filePath);
        }
    }
}
