using System;

namespace Interfaces_and_Testability
{
    public class Order
    {
        public float TotalPrice;
        public DateTime DateOrdered;
        public int OrderID { get; set; }
        public Shipment Shipment { get; set; }
        public bool IsShipped
        {
            get { return Shipment != null; }
        }


    }
}
