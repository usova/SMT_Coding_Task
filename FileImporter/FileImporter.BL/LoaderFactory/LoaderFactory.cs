using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using FileImporter.Common;

namespace FileImporter.BL
{
    public class LoaderFactory : ILoaderFactory
    {
        private const string PluginFileNamePattern = "Plugin.*.dll";

        private Dictionary<string, ILoader> loaderToFileExtensionStrategy = new Dictionary<string, ILoader>(StringComparer.OrdinalIgnoreCase);
        private Dictionary<string, ILoader> loaderToPluginNameStrategy = new Dictionary<string, ILoader>(StringComparer.OrdinalIgnoreCase);

        public LoaderFactory()
        {
            FillLoaderCreationStrategy();
        }

        public ILoader GetLoader(string fileExtension)
        {
            if (string.IsNullOrWhiteSpace(fileExtension))
                throw new ArgumentNullException(nameof(fileExtension));

            if (!loaderToFileExtensionStrategy.ContainsKey(fileExtension))
                FillLoaderCreationStrategy();

            return loaderToFileExtensionStrategy.ContainsKey(fileExtension)
                ? loaderToFileExtensionStrategy[fileExtension]
                : null;
        }

        public bool ValidatePlugin(string pluginToCopyPath)
        {
            if (string.IsNullOrWhiteSpace(pluginToCopyPath))
                return false;

            if (!Path.GetExtension(pluginToCopyPath).Equals(".dll", StringComparison.OrdinalIgnoreCase))
                return false;

            return true;
        }

        public ILoader AddPlugin(string pluginToCopyPath)
        {
            var destinationFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.GetFileName(pluginToCopyPath)) ;

            if (loaderToPluginNameStrategy.ContainsKey(Path.GetFileName(pluginToCopyPath)))
                return loaderToPluginNameStrategy[Path.GetFileName(pluginToCopyPath)];

            File.Copy(pluginToCopyPath, destinationFilePath);

            return LoadPluginFile(destinationFilePath);
        }

        private List<string> GetPluginFilePath()
        {
            var appFolder = AppDomain.CurrentDomain.BaseDirectory;

            return Directory.GetFiles(appFolder, PluginFileNamePattern, SearchOption.AllDirectories).ToList();
        }

        private void FillLoaderCreationStrategy()
        {
            foreach (var pluginPath in GetPluginFilePath())
            {
                LoadPluginFile(pluginPath);
            }
        }

        private ILoader LoadPluginFile(string pluginFilePath)
        {
            var pluginName = Path.GetFileName(pluginFilePath);

            if (loaderToPluginNameStrategy.ContainsKey(pluginName))
                return loaderToPluginNameStrategy[pluginName];

            var pluginDLL = Assembly.LoadFile(pluginFilePath);
            var loaderType = pluginDLL
                .GetExportedTypes()
                .Where(type => type.GetInterfaces().Contains(typeof(ILoader)))
                .FirstOrDefault();

            var loader = (ILoader)Activator.CreateInstance(loaderType);

            if (!loaderToFileExtensionStrategy.ContainsKey(loader.SupportedExtension))
            {
                loaderToFileExtensionStrategy.Add(loader.SupportedExtension, loader);
            }

            if (!loaderToPluginNameStrategy.ContainsKey(pluginName))
            {
                loaderToPluginNameStrategy.Add(pluginName, loader);
            }

            return loader;
        }
    }
}
