using System;
using System.Collections.Generic;

namespace Method_Overriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                //calls the Draw method for whatever object is inside the List
                shape.Draw();
            }
        }
    }
}
