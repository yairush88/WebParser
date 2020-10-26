using System;

namespace WebParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var domManager = new DomManager();
            domManager.CreateReport("https://www.w3schools.com/html/default.asp", FileType.JSON, "c:\test.txt");

            Console.ReadLine();
        }
    }
}
