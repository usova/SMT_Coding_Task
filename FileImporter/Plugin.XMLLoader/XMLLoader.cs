using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using FileImporter.Common;

namespace Plugin.XMLLoader
{
    public class XMLLoader : ILoader
    {
        public string SupportedExtension => ".xml";

        public Task<List<ImportedDataItem>> LoadAsync(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentNullException(nameof(filePath));

            if (!File.Exists(filePath))
                throw new ArgumentException($"File '{filePath}' is not found");

            var rows = File.ReadAllLines(filePath);

            var xmlContent = rows
                .SkipWhile(x => !x.ToLower().Contains("content"))
                .Skip(2);

            return 
                new TaskFactory<List<ImportedDataItem>>().StartNew(() =>
                    XDocument.Parse(String.Join(String.Empty, xmlContent))
                        .Root
                        .Elements()
                        .Select(x => Parse(x)).ToList());
        }

        private ImportedDataItem Parse(XElement element)
        {
            return new ImportedDataItem
            {
                Date = Convert.ToDateTime(element.Attribute("date").Value),
                Open = Convert.ToDecimal(element.Attribute("open").Value),
                High = Convert.ToDecimal(element.Attribute("high").Value),
                Low = Convert.ToDecimal(element.Attribute("low").Value),
                Close = Convert.ToDecimal(element.Attribute("close").Value),
                Volume = Convert.ToInt64(element.Attribute("volume").Value)

            };
        }
    }
}
