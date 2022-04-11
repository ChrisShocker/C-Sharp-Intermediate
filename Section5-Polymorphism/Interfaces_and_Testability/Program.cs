using System;

namespace Interfaces_and_Testability
{
    public class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order();
                //= new Order(order.DateOrdered = DateTime.Now, order.TotalPrice = 200f);
            orderProcessor.Process(order); 
        }

    }
}
