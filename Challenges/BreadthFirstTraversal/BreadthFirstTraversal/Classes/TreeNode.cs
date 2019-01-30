using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal.Classes
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Next { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }
        
        public TreeNode(int value)
        {
            Value = value;
            Next = null;
            LeftChild = null;
            RightChild = null;
        }
    }
}
