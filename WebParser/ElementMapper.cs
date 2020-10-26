using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;

namespace WebParser
{
    public class ElementMapper : IMapper
    {
        public IEnumerable<IWebElement> GetElements(string url)
        {
            var elements = new List<IWebElement>();

            var htmlWeb = new HtmlWeb();
            var document = htmlWeb.Load(url);

            var imageNodes = document.DocumentNode.SelectNodes(@"//img").ToList();
            foreach (var node in imageNodes)
            {
                elements.Add(new ImageElement
                {
                    Source = node.Attributes["src"].Value,
                    Width = int.Parse(node.Attributes["width"].Value),
                    Height = int.Parse(node.Attributes["height"].Value)
                });
            }

            var textNodes = document.DocumentNode.SelectNodes(@"//text").ToList();
            foreach (var node in textNodes)
            {
                elements.Add(new TextElement { Text = node.InnerText });
            }

            return elements;
        }
    }
}
