using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing_and_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NOT type safe so boxing can occur depending on the values passed in
            var list = new ArrayList();

            //boxing occurs since integer is of value type
            list.Add(1);

            //boxing doesn't occur since string is of reference type
            list.Add("John");

            //boxing occurs since structs are of value type
            list.Add(DateTime.Now);


            var anotherList = new List<int>();
            //type safety with no boxing since the list stores a lit of int not objects
            anotherList.Add(1);

            //type safety with no boxing...
            var names = new List<string>();
            names.Add("Joe");

        }
    }
}
