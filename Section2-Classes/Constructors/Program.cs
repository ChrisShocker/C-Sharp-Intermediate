using System;

namespace Constructors
{

    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Jake", 1);
            Console.WriteLine(customer.Name + " Id: " + customer.Id);
            var order = new Order();
            customer.Orders.Add(order);

        }
    }
}
