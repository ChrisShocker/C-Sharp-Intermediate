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
    }


    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
