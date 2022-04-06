using System;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1876,1,2), "Hello");
            Console.WriteLine("Name: {0} Age: {1}",person.Name, person.Age);
        }
    }
}
