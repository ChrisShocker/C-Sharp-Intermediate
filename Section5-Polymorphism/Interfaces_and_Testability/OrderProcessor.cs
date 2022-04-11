using System;

namespace Interfaces_and_Testability
{
    public class OrderProcessor
    {
        private readonly ShippingCaclulator _shippingCaclulator;

        public OrderProcessor()
        {
            _shippingCaclulator = new ShippingCaclulator(); 
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("Order already processed");

            else
            {
                //Create new Shipment object and set values
                order.Shipment = new Shipment
                {
                    Cost = _shippingCaclulator.CaclulateShipping(order),
                    ShippingDate = DateTime.Today.AddDays(2);

                }
            }
        }



    }
}
