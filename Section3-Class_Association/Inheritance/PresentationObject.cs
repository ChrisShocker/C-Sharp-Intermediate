using System;

namespace Inheritance
{
    public class PresentationObject
    {

        public int height { get; set; }
        public int width { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object Copied");

        }

        public void Duplicate()
        {
            Console.WriteLine("Object Duplicated");
        }


    }
}
