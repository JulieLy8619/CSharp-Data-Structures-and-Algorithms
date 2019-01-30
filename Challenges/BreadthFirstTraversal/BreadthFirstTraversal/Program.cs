using BreadthFirstTraversal.Classes;
using System;

namespace BreadthFirstTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }

        public static void BreadthFirst(TreeNode root)
        {
            QueueForTrees methodQueue = new QueueForTrees();

            methodQueue.Enqueue(root.Value);
            if (root.LeftChild != null)
            {
                methodQueue.Enqueue(root.LeftChild.Value);
            }
            if (root.RightChild != null)
            {
                methodQueue.Enqueue(root.RightChild.Value);
            }
            while (methodQueue != null)
            {
                Console.WriteLine(root.Value);
                TreeNode temp = methodQueue.Dequeue();
                if (temp.LeftChild != null)
                {
                    methodQueue.Enqueue(temp.LeftChild.Value);
                }
                if (temp.RightChild != null)
                {
                    methodQueue.Enqueue(temp.RightChild.Value);
                }
            }
        }
    }
}
