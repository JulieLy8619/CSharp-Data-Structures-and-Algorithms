using BreadthFirstTraversal.Classes;
using HashTable.Classes;
using System;
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
            int[] returnArray = new int[10]; //how know size, do i need resize logic then?
            int indexCounter = 0;
            algoQueue.Enqueue(root1);
        }
    }
}
