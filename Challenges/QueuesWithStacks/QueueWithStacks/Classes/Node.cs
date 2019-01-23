using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        //instantiaton
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
