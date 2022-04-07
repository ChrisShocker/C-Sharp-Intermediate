using System.Collections;
using System.Collections.Generic;

namespace Upcasting_and_Downcasting
{
    public class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
            //Upcasting
            Square square = new Square();
            //Base class set to a derived class
            Shape shape = square;

            //Text and shape are references to the same obj in memory
            //Changing either one affects the same memory
            square.Width = 200;
            shape.Width = 100;
            //Now square .Width and shape.Width = 100


            //Unsafe type list
            //any object type can be added without any conversion
            //Array elements are being converted to the target type
            var list = new ArrayList();
            list.Add(1);
            list.Add("help");

            //Generic type list
            //Only the specified type can be added unless converted
            var genericList = new List<Shape>();


            //shapeD is of type Square
            Shape shapeD = new Square();

            //Downcast object and cast to access class properties
            //Convert ShapeD is of type sqaure
            Square squareD = (Square) shapeD;


        }



    }
}
