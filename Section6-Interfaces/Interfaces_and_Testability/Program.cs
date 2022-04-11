using System;

namespace Interfaces_and_Testability
{
    public class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DateOrdered = DateTime.Now, TotalPrice = 200f };
            orderProcessor.Process(order); 
        }

    }
}
