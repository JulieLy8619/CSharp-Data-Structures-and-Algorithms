using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        /// <summary>
        /// adds a node to a binary search tree
        /// </summary>
        /// <param name="root">the binary tree we're adding it to</param>
        /// <param name="addValue">value we want to add to tree</param>
        public void Add(BinaryTreeNode root, int addValue)
        {
            while (root.LeftChild != null || root.RightChild != null)
            {
                if(addValue > root.Value)
                {
                    Add(root.RightChild, addValue);
                }
                else
                {
                    Add(root.LeftChild, addValue);
                }
            }
            if(addValue > root.Value)
            {
                root.RightChild = new BinaryTreeNode(addValue);
            }
            else
            {
                root.LeftChild = new BinaryTreeNode(addValue);
            }
        }

        /// <summary>
        /// searches a binary search tree if a node is in it
        /// </summary>
        /// <param name="root">the tree we are searching</param>
        /// <param name="searchValue">the value one is looking for</param>
        /// <returns>true if found, otherwise false</returns>
        public bool Contains(BinaryTreeNode root, int searchValue)
        {
            if (root == null)
            {
                return false; //it didn't find the search value
            }
            if (searchValue == root.Value)
            {
                return true;
            }
            else if (searchValue < root.Value)
            {
                return Contains(root.LeftChild, searchValue);
            }
            else 
            {
                return Contains(root.RightChild, searchValue);
            }
        }
    }
}
