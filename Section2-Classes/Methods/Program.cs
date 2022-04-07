using System;

namespace Methods
{

    internal partial class Program
    {
        static void Main(string[] args)
        {
            usePoints();
            useCaculator();
            useParse(4);
            useParse("5");
        }

        //Takes in a string and attempts to parse it into a number
        static void useParse(int number)
        {
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("Conversion failed");
        }
        static void useParse(string input)
        {
            int number;
            var result = int.TryParse(input, out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
                Console.WriteLine("Conversion failed");
        }

        //Calls calulator class that adds numbers passed to it
        static void useCaculator()
        {
            var calculator = new Calculator();
            Console.WriteLine("The value of the calculator is {0}", calculator.Add(10, 5, 6));
        }

        //Calls Point class that displayst points passed to it
        static void usePoints()
        {
            try
            {
                var point = new Point(5, 7);
                Console.WriteLine("Point is at ({0}, {1})", point.x, point.y);

                point.Move(new Point(6, 8));
                Console.WriteLine("Point is at ({0}, {1})", point.x, point.y);

                point.Move(100, 300);
                Console.WriteLine("Point is at ({0}, {1})", point.x, point.y);
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error occurred");
            }

        }
    }
}
