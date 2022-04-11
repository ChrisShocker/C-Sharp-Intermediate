using System;

namespace Interfaces_and_Testability
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCaclulator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCaclulator = shippingCalculator; 
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
                    Cost = _shippingCaclulator.CalculateShipping(order),
                    ShippingDate = DateTime.Today.AddDays(2)

                };
            }
        }



    }
}
