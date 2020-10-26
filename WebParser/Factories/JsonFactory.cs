using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WebParser
{
    public class JsonFactory : IDocumentFactory
    {
        public void CreateDocument(IEnumerable<IWebElement> webElements, string filePath)
        {
            var json = JsonSerializer.Serialize(webElements);
            File.WriteAllText(filePath, json);
        }
    }
}
