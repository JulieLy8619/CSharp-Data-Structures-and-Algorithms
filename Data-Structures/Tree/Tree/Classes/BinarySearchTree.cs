using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public BinaryTreeNode root { get; set; }
        public BinarySearchTree(BinaryTreeNode rootNode)
        {
            root = rootNode;
        }
        /// <summary>
        /// adds a node to a binary search tree
        /// </summary>
        /// <param name="root">the binary tree we're adding it to</param>
        /// <param name="addValue">value we want to add to tree</param>
        public void Add(BinaryTreeNode root, int addValue)
        {
            //i assumed if there were duplicates I would default and add to the left
            if(addValue > root.Value && root.RightChild != null)
            {
                Console.WriteLine("in while and more than");
                Add(root.RightChild, addValue);
            }
            else if(addValue < root.Value && root.LeftChild != null)
            {
                Console.WriteLine("in while and less than");
                Add(root.LeftChild, addValue);
            }
            else if (addValue > root.Value && root.RightChild == null)
            {
                Console.WriteLine("addvalue is more than root value" + addValue + " " + root.Value);
                root.RightChild = new BinaryTreeNode(addValue);
            }
            else if (addValue <= root.Value && root.LeftChild == null)
            {
                Console.WriteLine("addvalue is less than root value" + addValue + " " + root.Value);
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
