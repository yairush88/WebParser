using System;
using System.Collections.Generic;

namespace WebParser
{
    public class DomManager
    {
        private IDocumentFactory _documentFactory;
        private readonly IMapper _elementMapper;
        private IEnumerable<IWebElement> _elements;

        public DomManager()
        {
            _elementMapper = new ElementMapper();
        }
        
        public void CreateReport(string url, FileType fileType, string filePath)
        {
            _documentFactory = CreateFactory(fileType);
            _elements = _elementMapper.GetElements(url);
            _documentFactory.CreateDocument(_elements, filePath);
        }

        private IDocumentFactory CreateFactory(FileType fileType)
        {
            IDocumentFactory factory;

            switch (fileType)
            {
                case FileType.CSV:
                    factory = new CSVFactory();
                    break;
                case FileType.JSON:
                    factory = new JsonFactory();
                    break;
                case FileType.PDF:
                    factory = new JsonFactory();
                    break;
                default:
                    throw new NotSupportedException($"File type {fileType} not supported.");
            }

            return factory;
        }
    }
}
