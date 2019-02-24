using BreadthFirstTraversal.Classes;
using HashTable.Classes;
using System;
using System.Collections.Generic;
using Tree.Classes;

namespace TreeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[] TreeIntersection(BinaryTree root1, BinaryTree root2)
        {
            QueueForTrees algoQueue = new QueueForTrees();
            Hashtable algoHashtable = new Hashtable();
            List<int> returnAnswer = new List<int>();
            TreeNode algoQTNode = new TreeNode(root1.root.Value);
            algoQueue.Enqueue(algoQTNode);
            while (algoQueue.Front != null)
            {
                Node temp = algoQueue.Dequeue();
                if (temp.Value.LeftChild != null)
                {
                    algoQueue.Enqueue(temp.Value.LeftChild);
                }
                if (temp.Value.RightChild != null)
                {
                    algoQueue.Enqueue(temp.Value.RightChild);
                }
                algoHashtable.AddToHashTable(temp.Value.Value.ToString(), temp.Value.Value.ToString());
            }
        }
    }
}
