using System;

namespace Properties
{
    public class Person
    {
        public DateTime Birthdate { get; private set; }
        public string Name { get; private set; }

        public Person(DateTime birthdate, String name)
        {
            this.Birthdate = birthdate;
            this.Name = name;
        }

        //Birthdate should only set once, so private and no setter method
        //We can calculate their age based on current time - their birthDate
        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }
    }
}
