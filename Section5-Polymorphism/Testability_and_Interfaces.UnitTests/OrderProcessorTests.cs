using Interfaces_and_Testability;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testability_and_Interfaces.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        //Naming convention: MethodName_Condition_Expectation
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };
            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetShipmentPropertyOfOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());

            //IsShipped bool is false
            var order = new Order();

            orderProcessor.Process(order);

            //Make sure IsShipped is false
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(2), order.Shipment.ShippingDate);
        }

    }


    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
