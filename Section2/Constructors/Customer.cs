using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(string name):this()
        {
            this.Name = name;
        }

        public Customer(int id):this()
        {
            this.Id = id;
        }

        public Customer(string name, int id):this(id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
