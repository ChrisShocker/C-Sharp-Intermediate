namespace Interfaces_and_Testability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
        
    }

    public class ShippingCalculator : IShippingCalculator 
    { 
        public float CalculateShipping(Order order)
        {
            //if order is less then 30 then shipping costs 10% of order cost
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            else
                return 0;
        }

    }
}
