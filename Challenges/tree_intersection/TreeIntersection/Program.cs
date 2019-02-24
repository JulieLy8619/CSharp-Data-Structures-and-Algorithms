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

        public List<int> TreeIntersection(BinaryTree root1, BinaryTree root2)
        {
            QueueForTrees algoQueue = new QueueForTrees();
            Hashtable algoHashtable = new Hashtable();
            List<int> returnAnswer = new List<int>();

            TreeNode algoQT1Node = new TreeNode(root1.root.Value);
            algoQueue.Enqueue(algoQT1Node);
            while (algoQueue.Front != null)
            {
                Node temp = algoQueue.Dequeue();
                algoHashtable.AddToHashTable(temp.Value.Value.ToString(), temp.Value.Value.ToString());
                if (temp.Value.LeftChild != null)
                {
                    algoQueue.Enqueue(temp.Value.LeftChild);
                }
                if (temp.Value.RightChild != null)
                {
                    algoQueue.Enqueue(temp.Value.RightChild);
                }
            }
            //can re-use the queue because it wouldn't exit above while loop until it was empty
            TreeNode algoQT2Node = new TreeNode(root2.root.Value);
            algoQueue.Enqueue(algoQT2Node);
            while (algoQueue.Front != null)
            {
                Node temp = algoQueue.Dequeue();
                if (algoHashtable.HashTableContains(temp.Value.Value.ToString()) == true)
                {
                    returnAnswer.Add(temp.Value.Value);
                }
                if (temp.Value.LeftChild != null)
                {
                    algoQueue.Enqueue(temp.Value.LeftChild);
                }
                if (temp.Value.RightChild != null)
                {
                    algoQueue.Enqueue(temp.Value.RightChild);
                }
                
            }
            return returnAnswer;
        }
    }
}
