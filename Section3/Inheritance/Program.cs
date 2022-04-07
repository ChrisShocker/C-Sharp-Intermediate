using System;

namespace Inheritance
{
    public class Program
    {

        static void Main(string[] args)
        {
            Text text = new Text();
            text.AddHyperlink("string");
        }
    }

    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("Link added to " +url);
        }


    }
}
