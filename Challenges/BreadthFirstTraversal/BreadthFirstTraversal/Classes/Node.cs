using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal.Classes
{
    class Node
    {
        public TreeNode Value { get; set; }
        public Node Next { get; set; }

        public Node(TreeNode value)
        {
            Value = value;
            Next = null;
        }
    }
}
