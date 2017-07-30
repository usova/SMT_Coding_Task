using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileImporter.Common
{
    public interface ILoader
    {
        string SupportedExtension { get; }

        Task<List<ImportedDataItem>> LoadAsync(string filePath);
    }
}
