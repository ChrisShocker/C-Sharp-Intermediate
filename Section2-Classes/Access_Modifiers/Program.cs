using System;

namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.setName("John");
            person.setBirthdate(new DateTime(2022,12,20));
            Console.WriteLine(person.getName());
            Console.WriteLine(person.getBirthDate());
        }
    }

    public class Person
    {
        private string _name;
        private DateTime _birthdate;

        public void setBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public void setName(String name)
        {
            this._name = name;
        }

        public String getName()
        {
            return this._name;
        }
        public DateTime getBirthDate()
        {
            return this._birthdate;
        }
    }
}
