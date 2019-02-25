using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class GraphNode
    {
        public string Value { get; set; }
        public bool Visted { get; set; }
        public GraphNode Next { get; set; }
    }
}
