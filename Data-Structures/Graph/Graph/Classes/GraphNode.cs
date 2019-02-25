using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class GraphNode
    {
        public int Value { get; set; }
        public bool Visted { get; set; }
        public int EdgeWeight { get; set; }
        public GraphNode Next { get; set; }

        public GraphNode(int value)
        {
            Value = value;
            Visted = false;
            EdgeWeight = 0;
            Next = null;
        }
    }
}
