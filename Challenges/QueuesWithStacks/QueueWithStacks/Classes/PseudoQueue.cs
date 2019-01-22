using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        //properties
        public Node Front { get; set; }
        public Node Rear { get; set; }

        //instantiate
        //queue with nothing given
        public PseudoQueue()
        {
            Front = null;
            Rear = null;
        }

        //queue with a given node
        public PseudoQueue(Node node)
        {
            Front = node;
            Rear = node;
        }
    }
}
