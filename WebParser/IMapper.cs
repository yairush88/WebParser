using System.Collections.Generic;

namespace WebParser
{
    public interface IMapper
    {
        IEnumerable<IWebElement> GetElements(string url);
    }
}
