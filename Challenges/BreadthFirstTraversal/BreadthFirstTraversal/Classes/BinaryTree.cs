using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal.Classes
{
    class BinaryTree
    {
        public int counter = 0;
        public TreeNode root { get; set; }

        public BinaryTree(TreeNode rootNode)
        {
            root = rootNode;
        }
    }
}
