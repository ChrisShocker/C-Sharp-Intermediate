using System;

namespace Abstract_Classes_and_Members
{
    public abstract class Shapes
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Do some common operation between all shapes");
        }

        public void Select()
        {
            Console.WriteLine("Select a shape");
        }
    }
}
