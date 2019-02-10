using BreadthFirstTraversal.Classes;
using System;

namespace ECSumOdd
{
    public class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode1 = new TreeNode(3);
            treeNode1.LeftChild = new TreeNode(7);
            treeNode1.RightChild = new TreeNode(6);
            Console.WriteLine("root value: " + treeNode1.Value);
            Console.WriteLine("Left child value: " + treeNode1.LeftChild.Value);
            Console.WriteLine("Right child value: " + treeNode1.RightChild.Value);

            Console.WriteLine(); //just for space
            int result = ECSumOdd(treeNode1);
            Console.WriteLine("The sum of the odd numbers in the tree is " + result);
            Console.ReadLine(); //to stop it from auto exit
        }

        public static int ECSumOdd(TreeNode root)
        {
            QueueForTrees methodQueue = new QueueForTrees();
            methodQueue.Enqueue(root);
            int sum = 0;

            while (methodQueue.Peek() != null)
            {
                if(methodQueue.Front.Value.Value % 2 == 1 || methodQueue.Front.Value.Value % 2 == -1)
                {
                    sum = sum + methodQueue.Front.Value.Value;
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
            return sum;
        }
    }
}
