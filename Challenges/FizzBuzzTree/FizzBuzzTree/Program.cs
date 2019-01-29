using System;
using FizzBuzzTree.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            //build object to put in tree
            //build tree
            FBObjectForNode nodeObj1 = new FBObjectForNode(3); //fizz
            FBObjectForNode nodeObj2 = new FBObjectForNode(11); //nothing
            FBObjectForNode nodeObj3 = new FBObjectForNode(21); // fizz
            FBObjectForNode nodeObj4 = new FBObjectForNode(30); //fizzbuzz
            FBObjectForNode nodeObj5 = new FBObjectForNode(25); //buzz

            FBNode treeRoot = new FBNode(nodeObj1);
            treeRoot.LeftChild = new FBNode(nodeObj2);
            treeRoot.RightChild = new FBNode(nodeObj3);
            treeRoot.LeftChild.LeftChild = new FBNode(nodeObj4);
            treeRoot.LeftChild.RightChild = new FBNode(nodeObj5);

            Console.WriteLine("this is what the tree looks like before fizzbuzztree");
            Console.WriteLine("root " + treeRoot.Value.IntValue);
            Console.WriteLine("root left " + treeRoot.LeftChild.Value.IntValue);
            Console.WriteLine("root right " + treeRoot.RightChild.Value.IntValue);
            Console.WriteLine("root left left " + treeRoot.LeftChild.LeftChild.Value.IntValue);
            Console.WriteLine("root left right " + treeRoot.LeftChild.RightChild.Value.IntValue);

            Console.WriteLine(); // just because I like space

            FBNode returnedTree = FizzBuzzTree(treeRoot);

            Console.WriteLine("this is what the tree looks like after fizzbuzztree");
            Console.WriteLine("root " + returnedTree.Value.StringValue);
            Console.WriteLine("root left " + returnedTree.LeftChild.Value.StringValue);
            Console.WriteLine("root right " + returnedTree.RightChild.Value.StringValue);
            Console.WriteLine("root left left " + returnedTree.LeftChild.LeftChild.Value.StringValue);
            Console.WriteLine("root left right " + returnedTree.LeftChild.RightChild.Value.StringValue);

            Console.ReadLine(); //stop it from auto quitting
        }

        /// <summary>
        /// this will update a tree with fizz, buzz, or fizzbuzz depending if the node is div by 3, 5 or both
        /// </summary>
        /// <param name="root">takes in a tree</param>
        /// <returns>a revised tree</returns>
        public static FBNode FizzBuzzTree(FBNode root)
        {
            if (root.LeftChild != null)
            {
                FizzBuzzTree(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                FizzBuzzTree(root.RightChild);
            }
            if (root.Value.IntValue % 3 == 0 && root.Value.IntValue % 5 == 0)
            {
                root.Value.StringValue = "FizzBuzz";
            }
            else if (root.Value.IntValue % 5 == 0)
            {
                root.Value.StringValue = "Buzz";
            }
            else if (root.Value.IntValue % 3 == 0)
            {
                root.Value.StringValue = "Fizz";
            }
            else
            {
                root.Value.StringValue = Convert.ToString(root.Value.IntValue); //so can easily print later
            }
            return root;
        }

    }
}
