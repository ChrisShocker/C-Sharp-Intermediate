using System;

namespace Constructor_Inheritance
{
    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Child class: Car initialized");

        }
        public Car(string color)
            : base(color) 
        {
            Console.WriteLine("Color is " + color);

        }
    }
}
