namespace Interfaces_and_Testability
{
    public interface IShippingCalculator
    {
        //Method to Caclulate order shipping
        float CalculateShipping(Order order);
        
    }

    //Implementes the shipping calculation for Interface
    //Read as "ShippingCalculator implements IShippingCalculator"
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
