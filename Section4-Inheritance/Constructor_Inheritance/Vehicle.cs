using System;

namespace Constructor_Inheritance
{
    public class Vehicle
    {
        private string _color;
        public Vehicle()
        {
            Console.WriteLine("Vehicle initialized");
        }

        public Vehicle(string color)
        {
            _color = color;
        }

    }
}
