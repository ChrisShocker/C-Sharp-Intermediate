using System;

namespace Section_2_Classes
{
    internal class Person
    {
        public string Name;

        public void Introduce (string intro)
        {
            Console.WriteLine("Hi {0}, I am {1}", intro, Name); 

        }

        public static Person Parse(String str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Mary");
            person.Introduce("James");
        }
    }
}
