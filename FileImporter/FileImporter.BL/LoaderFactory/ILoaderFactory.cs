using FileImporter.Common;

namespace FileImporter.BL
{
    public interface ILoaderFactory
    {
        ILoader GetLoader(string fileExtension);

        ILoader AddPlugin(string pluginToCopyPath);

        bool ValidatePlugin(string pluginToCopyPath);
    }
}
