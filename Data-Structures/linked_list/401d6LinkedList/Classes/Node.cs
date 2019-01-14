using System;
using System.Collections.Generic;
using System.Text;

namespace _401d6LinkedList.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            //if (value == null)
            //{
            //    Value = 0;
            //}
            //else
            //{
                Value = value;
            //}
            Next = null; //default of new node in case it is at end
        }
    }
}
