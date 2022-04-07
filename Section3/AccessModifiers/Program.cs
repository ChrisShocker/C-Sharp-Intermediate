using InternalExample;
namespace AccessModifiers
{
     class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            InternalExample.RateCalculator = new RateCalculator();
        }
    }
}
