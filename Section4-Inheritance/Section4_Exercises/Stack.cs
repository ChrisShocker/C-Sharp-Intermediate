using System;
using System.Collections;

namespace Section4_Stack_Exercise
{
    public class Stack
    {
        private ArrayList _list = new ArrayList();

        public Stack()
        {
            var _list = new ArrayList();

        }
        public Stack(ArrayList list)
        {
            this._list = new ArrayList();
        }

        public void push(object obj)
        {
            if (obj == null)
                return;
            else
                _list.Insert(0, obj);
        }
        public void pop()
        {
            if (_list.Count == 0)
                return;
            else
            {
                _list.RemoveAt(0);
            }
        }

        public void clear()
        {
            _list.Clear();
        }

        public void printList()
        {
            foreach (object obj in _list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
