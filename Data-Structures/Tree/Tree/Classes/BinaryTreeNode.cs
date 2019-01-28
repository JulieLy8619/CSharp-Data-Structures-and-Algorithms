using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTreeNode
    {
        public int Value { get; set; }
        public BinaryTreeNode LeftChild { get; set; }
        public BinaryTreeNode RightChild { get; set; }

        public BinaryTreeNode(int value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }
    }
}
