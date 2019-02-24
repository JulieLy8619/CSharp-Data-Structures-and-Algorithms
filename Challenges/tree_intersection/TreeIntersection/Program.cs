using BreadthFirstTraversal.Classes;
using HashTable.Classes;
using System;
using System.Collections.Generic;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //make one tree
            TreeNode BTNode1 = new TreeNode(10);
            TreeNode BTNode1Left = new TreeNode(100);
            TreeNode BTNode1Right = new TreeNode(5);
            BTNode1.LeftChild = BTNode1Left;
            BTNode1.RightChild = BTNode1Right;
            BinaryTree tree1 = new BinaryTree(BTNode1);
            Console.WriteLine("This is the first tree: ");
            Console.WriteLine("root " + BTNode1.Value);
            Console.WriteLine("Left " + BTNode1.LeftChild.Value);
            Console.WriteLine("Right " + BTNode1.RightChild.Value);


            //make second tree
            TreeNode BTNode2 = new TreeNode(100);
            TreeNode BTNode2Left = new TreeNode(1);
            TreeNode BTNode2Right = new TreeNode(5);
            BTNode2.LeftChild = BTNode2Left;
            BTNode2.RightChild = BTNode2Right;
            BinaryTree tree2 = new BinaryTree(BTNode2);
            Console.WriteLine("This is the second tree: ");
            Console.WriteLine("root " + BTNode2.Value);
            Console.WriteLine("Left " + BTNode2.LeftChild.Value);
            Console.WriteLine("Right " + BTNode2.RightChild.Value);

            //run it through method
            List<int> consoleAnswer = TreeIntersection(tree1, tree2);
            Console.WriteLine("returned answer is");
            Console.WriteLine(consoleAnswer[0]);
            Console.WriteLine(consoleAnswer[1]);

            Console.ReadLine(); //so it doesn't auto quit
        }

        /// <summary>
        /// Compares two trees and itentify where they shares the same values
        /// </summary>
        /// <param name="root1">one tree</param>
        /// <param name="root2">second tree</param>
        /// <returns>a list of the values the two trees share</returns>
        public static List<int> TreeIntersection(BinaryTree root1, BinaryTree root2)
        {
            QueueForTrees algoQueue = new QueueForTrees();
            Hashtable algoHashtable = new Hashtable();
            List<int> returnAnswer = new List<int>();
            string valForHT = "";
            bool comparison;

            if (root1 == null || root2 ==null)
            {
                return returnAnswer;
            }

            TreeNode algoQT1Node = root1.root;
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
            TreeNode algoQT2Node = root2.root;
            algoQueue.Enqueue(algoQT2Node);
            while (algoQueue.Front != null)
            {
                Node temp = algoQueue.Dequeue();
                valForHT = temp.Value.Value.ToString();
                comparison = algoHashtable.HashTableContains(valForHT);
                if (comparison == true)
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
