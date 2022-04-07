using System;

namespace Method_Overriding
{
    public class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        //public Position Position { get; set; }
        public virtual void Draw()
        {

        }
    }

    //Adding children classes that now overried the draw function won't affect the other classes
    //this results in a program that's more loosley couple and allows the project to be less fragile
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");


            //calls the parent draw method
            //base.Draw();
        }

    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }



}
