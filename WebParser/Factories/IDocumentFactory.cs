using System.Collections.Generic;

namespace WebParser
{
    public interface IDocumentFactory
    {
        void CreateDocument(IEnumerable<IWebElement> webElements, string filePath);
    }
}
