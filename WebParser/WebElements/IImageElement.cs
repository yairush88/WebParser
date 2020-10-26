namespace WebParser
{
    interface IImageElement : IWebElement
    {
        public string Source { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
