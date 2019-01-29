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
            FBObjectForNode nodeObj1 = new FBObjectForNode(5);

        }

        public static void FizzBuzzTree(FBNode root)
        {
            if (root.LeftChild != null)
            {
                FizzBuzzTree(root.LeftChild);
            }
            else if (root.RightChild != null)
            {
                FizzBuzzTree(root.RightChild);
            }
            else if (root.Value.IntValue % 3 == 0 && root.Value.IntValue % 5 == 0)
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
        }

    }
}
