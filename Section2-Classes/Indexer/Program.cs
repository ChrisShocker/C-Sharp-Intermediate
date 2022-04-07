using System;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Jake";

            Console.WriteLine(cookie["name"]);
        }
    }
}
