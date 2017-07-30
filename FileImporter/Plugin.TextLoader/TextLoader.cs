using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FileImporter.Common;

namespace Plugin.TextLoader
{
    public class TextLoader : ILoader
    {
        public string SupportedExtension => ".txt";
        private const char Delimeter = ';';

        public Task<List<ImportedDataItem>> LoadAsync(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentNullException(nameof(filePath));

            if (!File.Exists(filePath))
                throw new ArgumentException($"File '{filePath}' is not found");

            return new TaskFactory<List<ImportedDataItem>>().StartNew(() =>
            {
                var rows = File.ReadAllLines(filePath);

                return rows
                    .SkipWhile(x => !x.ToLower().Contains("content"))
                    .Skip(2)
                    .AsParallel()
                    .Select(Parse)
                    .ToList();
            });
        }

        private ImportedDataItem Parse(string row)
        {
            var columns = row.Split(Delimeter);

            return new ImportedDataItem
            {
                Date = Convert.ToDateTime(columns[0]),
                Open = Convert.ToDecimal(columns[1]),
                High = Convert.ToDecimal(columns[2]),
                Low = Convert.ToDecimal(columns[3]),
                Close = Convert.ToDecimal(columns[4]),
                Volume = Convert.ToInt64(columns[5])
            };
        }
    }
}
