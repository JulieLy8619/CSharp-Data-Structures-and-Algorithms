using BreadthFirstTraversal.Classes;
using System;

namespace TreeHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

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
                    methodQ.Enqueue(tempNode.Value.RightChild)
                }
            }
            return heightAnswer;

        }
    }
}
