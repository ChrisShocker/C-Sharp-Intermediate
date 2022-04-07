namespace Abstract_Classes_and_Members
{
    /*
     * Abstract classes and methods allow us to enforce how
     * implemented providing a commonality between objects
     * our classes are used by forcing abstract methods to be 
     * implemented providing a commonality between objects
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            // Shapes class is abstract so we can't create a Shapes object
            //var shape = new Shapes();

            var circle = new Circle();

            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
