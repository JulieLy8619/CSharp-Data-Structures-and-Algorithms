using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public int counter = 0;
        public BinaryTreeNode root { get; set; }
        //otherwise I kept resetting it to a new array when I recursed
        public BinaryTreeNode[] preOrderReturnArray = new BinaryTreeNode[20];
        public BinaryTreeNode[] inOrderReturnArray = new BinaryTreeNode[20];
        public BinaryTreeNode[] postOrderReturnArray = new BinaryTreeNode[20];

        public BinaryTree(BinaryTreeNode rootNode)
        {
            root = rootNode;
        }

        /// <summary>
        /// Records the Root node before looking at Left/Right child
        /// </summary>
        /// <returns>an array of the binary tree nodes in Preorder</returns>
        public BinaryTreeNode[] preOrder(BinaryTreeNode root)
        {
            //BinaryTreeNode[] preOrderReturnArray = new BinaryTreeNode[20];
            if (counter == preOrderReturnArray.Length)
            {
                Array.Resize(ref preOrderReturnArray, preOrderReturnArray.Length * 2);
            }
            preOrderReturnArray[counter] = root;
            counter++;
            if (root.LeftChild != null)
            {
                preOrder(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                preOrder(root.RightChild);
            }
            return preOrderReturnArray;
        }

        /// <summary>
        /// Records the Root node inbetween looking at Left/Right child
        /// </summary>
        /// <returns>an array of the binary tree nodes in Inorder</returns>
        public BinaryTreeNode[] inOrder(BinaryTreeNode root)
        {
            //BinaryTreeNode[] inOrderReturnArray = new BinaryTreeNode[20];
            if (root.LeftChild != null)
            {
                inOrder(root.LeftChild);
            }
            if (counter == inOrderReturnArray.Length)
            {
                Array.Resize(ref inOrderReturnArray, inOrderReturnArray.Length * 2);
            }
            Console.WriteLine(root.Value);
            inOrderReturnArray[counter] = root;
            counter++;
            if (root.RightChild != null)
            {
                inOrder(root.RightChild);
            }
            return inOrderReturnArray;
        }

        /// <summary>
        /// Records the Root node after looking at Left/Right child
        /// </summary>
        /// <returns>an array of the binary tree nodes in Postorder</returns>
        public BinaryTreeNode[] postOrder(BinaryTreeNode root)
        {
            //BinaryTreeNode[] postOrderReturnArray = new BinaryTreeNode[20];
            if (root.LeftChild != null)
            {
                postOrder(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                postOrder(root.RightChild);
            }
            if (counter == postOrderReturnArray.Length)
            {
                Array.Resize(ref postOrderReturnArray, postOrderReturnArray.Length * 2);
            }
            postOrderReturnArray[counter] = root;
            counter++;
            return postOrderReturnArray;
        }
    }
}
