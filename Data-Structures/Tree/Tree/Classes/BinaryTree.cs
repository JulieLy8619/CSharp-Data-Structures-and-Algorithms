using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    class BinaryTree
    {
        public int counter = 0;
 
        /// <summary>
        /// Records the Root node before looking at Left/Right child
        /// </summary>
        /// <returns>an array of the binary tree nodes in Preorder</returns>
        public BinaryTreeNode[] preOrder(BinaryTreeNode root)
        {
            BinaryTreeNode[] preOrderReturnArray = [20];
            if (counter == preOrderReturnArray.Length)
            {
                Array.Resize(ref preOrderReturnArray, preOrderReturnArray.Length * 2);
            }
            preOrderReturnArray[counter] = root;
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
            BinaryTreeNode[] inOrderReturnArray = [20];
            if (root.LeftChild != null)
            {
                preOrder(root.LeftChild);
            }
            if (counter == inOrderReturnArray.Length)
            {
                Array.Resize(ref inOrderReturnArray, inOrderReturnArray.Length * 2);
            }
            inOrderReturnArray[counter] = root;
            if (root.RightChild != null)
            {
                preOrder(root.RightChild);
            }
            return inOrderReturnArray;
        }

        /// <summary>
        /// Records the Root node after looking at Left/Right child
        /// </summary>
        /// <returns>an array of the binary tree nodes in Postorder</returns>
        public BinaryTreeNode[] postOrder(BinaryTreeNode root)
        {
            BinaryTreeNode[] postOrderReturnArray = [20];
            if (root.LeftChild != null)
            {
                preOrder(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                preOrder(root.RightChild);
            }
            if (counter == postOrderReturnArray.Length)
            {
                Array.Resize(ref postOrderReturnArray, postOrderReturnArray.Length * 2);
            }
            postOrderReturnArray[counter] = root;
            return postOrderReturnArray;
        }
    }
}
