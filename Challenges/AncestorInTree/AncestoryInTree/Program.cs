using BreadthFirstTraversal.Classes;
using System;

namespace AncestoryInTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the tree: ");
            //put in tree and print it here
            TreeNode treeNode1 = new TreeNode(8);
            treeNode1.LeftChild = new TreeNode(5);
            treeNode1.RightChild = new TreeNode(6);
            treeNode1.RightChild.LeftChild = new TreeNode(1);
            treeNode1.RightChild.RightChild = new TreeNode(3);
            Console.WriteLine("root value: " + treeNode1.Value);
            Console.WriteLine("Left child value: " + treeNode1.LeftChild.Value);
            Console.WriteLine("Right child value: " + treeNode1.RightChild.Value);
            Console.WriteLine("Right child's Left value: " + treeNode1.RightChild.LeftChild.Value);
            Console.WriteLine("Right child's Right value: " + treeNode1.RightChild.RightChild.Value);
            bool answer = IsAncestor(8, 3, treeNode1);
            Console.WriteLine("8 is an ancestor of 3 " + answer);
            Console.ReadLine(); // to stop it from auto quitting
        }

        /// <summary>
        /// determines if a value is an ancestor of another value in a binary tree
        /// </summary>
        /// <param name="A">is this an ancestor</param>
        /// <param name="B">this is the one we are checking if A was an ancestor</param>
        /// <param name="root">the binary tree</param>
        /// <returns></returns>
        public static bool IsAncestor(int A, int B, TreeNode root)
        {
            QueueForTrees methodQ = new QueueForTrees();
            bool foundA = false;

            methodQ.Enqueue(root);
            while (methodQ.Front != null)
            {
                Node tempNode = methodQ.Dequeue();
                if (tempNode.Value.Value == A)
                {
                    foundA = true;
                }
                if (tempNode.Value.Value == B && foundA == true)
                {
                    return true;
                }
                if (tempNode.Value.LeftChild != null)
                {
                    methodQ.Enqueue(tempNode.Value.LeftChild);
                }
                if (tempNode.Value.RightChild != null)
                {
                    methodQ.Enqueue(tempNode.Value.RightChild);
                }
            }
            return false;
        }

        
    }
}
