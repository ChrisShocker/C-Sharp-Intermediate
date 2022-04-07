using System;

namespace InternalExample
{
    public class Customer
    {
        public string Name { get; set; }
        public int id { get; set; }
        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.calculate(this);

        }

    }
}
