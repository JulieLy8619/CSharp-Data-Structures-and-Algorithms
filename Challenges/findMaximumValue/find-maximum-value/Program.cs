using BreadthFirstTraversal.Classes;
using System;

namespace find_maximum_value
{
    public class Program
    {
        /// <summary>
        /// main program that calls other methods, runs to the console
        /// </summary>
        /// <param name="args">the default params to work</param>
        static void Main(string[] args)
        {
            Console.WriteLine("This is the tree: ");
            //put in tree and print it here
            TreeNode treeNode1 = new TreeNode(8);
            treeNode1.LeftChild = new TreeNode(200);
            treeNode1.RightChild = new TreeNode(6);
            Console.WriteLine("root value: " + treeNode1.Value);
            Console.WriteLine("Left child value: " + treeNode1.LeftChild.Value);
            Console.WriteLine("Right child value: " + treeNode1.RightChild.Value);
            int answer = FindMaxValue(treeNode1);
            Console.WriteLine("This is the max value of the tree: " + answer);
            Console.ReadLine(); // to stop it from uto quitting
        }

        /// <summary>
        /// finds the max value in a tree
        /// </summary>
        /// <param name="root">the tree</param>
        /// <returns>the max value of the tree</returns>
        public static int FindMaxValue(TreeNode root)
        {
            QueueForTrees methodQueue = new QueueForTrees();
            int maxValue = root.Value;

            methodQueue.Enqueue(root);

            while (methodQueue.Peek() != null)
            {
                if (methodQueue.Front.Value.Value > maxValue)
                {
                    maxValue = methodQueue.Front.Value.Value;
                }
                Node temp = methodQueue.Dequeue();
                if (temp.Value.LeftChild != null)
                {
                    methodQueue.Enqueue(temp.Value.LeftChild);
                }
                if (temp.Value.RightChild != null)
                {
                    methodQueue.Enqueue(temp.Value.RightChild);
                }
            }
            return maxValue;
        }
    }
}
