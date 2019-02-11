using BreadthFirstTraversal.Classes;
using System;

namespace TreeHeight
{
    public class Program
    {
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
            int heightAnswer = FindTreeHeight(treeNode1);
            Console.WriteLine("The height of the tree is " + heightAnswer);
            int levelAnswer = FindTreeLevel(treeNode1);
            Console.WriteLine("and the tree level is  " + levelAnswer);
            Console.ReadLine(); // to stop it from uto quitting
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int FindTreeHeight(TreeNode root)
        {
            QueueForTrees methodQ = new QueueForTrees();
            int heightAnswer = 0;

            methodQ.Enqueue(root);

            while (methodQ.Front != null)
            {
                if (methodQ.Front.Value.LeftChild != null || methodQ.Front.Value.RightChild != null)
                {
                    heightAnswer++;
                }
                Node tempNode = methodQ.Dequeue();
                if (tempNode.Value.LeftChild != null)
                {
                    methodQ.Enqueue(tempNode.Value.LeftChild);
                }
                if (tempNode.Value.RightChild != null)
                {
                    methodQ.Enqueue(tempNode.Value.RightChild);
                }
            }
            return heightAnswer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int FindTreeLevel(TreeNode root)
        {
            QueueForTrees methodQ = new QueueForTrees();
            int levelAnswer = 1;

            methodQ.Enqueue(root);

            while (methodQ.Front != null)
            {
                if (methodQ.Front.Value.LeftChild != null || methodQ.Front.Value.RightChild != null)
                {
                    levelAnswer++;
                }
                Node tempNode = methodQ.Dequeue();
                if (tempNode.Value.LeftChild != null)
                {
                    methodQ.Enqueue(tempNode.Value.LeftChild);
                }
                if (tempNode.Value.RightChild != null)
                {
                    methodQ.Enqueue(tempNode.Value.RightChild);
                }
            }
            return levelAnswer;
        }
    }
}
