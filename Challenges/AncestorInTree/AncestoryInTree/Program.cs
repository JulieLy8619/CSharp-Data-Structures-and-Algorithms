using BreadthFirstTraversal.Classes;
using System;

namespace AncestoryInTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the tree: ");
            //put in tree and print it here
            TreeNode treeNode1 = new TreeNode(8);
            treeNode1.LeftChild = new TreeNode(5);
            treeNode1.RightChild = new TreeNode(6);
            //treeNode1.RightChild.LeftChild = new TreeNode(1);
            //treeNode1.RightChild.RightChild = new TreeNode(3);
            Console.WriteLine("root value: " + treeNode1.Value);
            Console.WriteLine("Left child value: " + treeNode1.LeftChild.Value);
            Console.WriteLine("Right child value: " + treeNode1.RightChild.Value);
            //Console.WriteLine("Right child's Left value: " + treeNode1.RightChild.LeftChild.Value);
            //Console.WriteLine("Right child's Right value: " + treeNode1.RightChild.RightChild.Value);
            bool answer = IsAncestor(8, 5, treeNode1);
            Console.WriteLine("8 is an ancestor of 5 " + answer);
            Console.ReadLine(); // to stop it from auto quitting
        }

        public static bool IsAncestor(int A, int B, TreeNode root)
        {
            //bool iaAnswer = false;
            if (root == null)
            {
                return false;
            }
            //B isn't even in the tree
            if (TreeSearch(root, B) == false)
            {
                return false;
            }
            //A isn't even in the tree
            if (TreeSearch(root, A) == false)
            {
                return false; 
            }
            //A is in the tree
            else
            {
                if (root.Value == A)
                {
                    return TreeSearch(root, B);
                }
                return false;
            }
        }

        public static bool TreeSearch(TreeNode root, int value, bool answer)
        {
            //bool answer = false;
            if (root.Value == value)
            {
                //bool newAnswer = true;
                answer = true;
                return answer;
            }
            if (root == null)
            {
                return answer;
            }
            bool lAnswer = TreeSearch(root.LeftChild, value, answer);
            bool rAnswer = TreeSearch(root.RightChild, value, answer);
            return answer;
            //if (root.LeftChild != null)
            //{
            //    TreeSearch(root.LeftChild, value);
            //}
            //if (root.RightChild != null)
            //{
            //    TreeSearch(root.RightChild, value);
            //}
            //else if (root.LeftChild == null && root.RightChild == null && root.Value != value)
            //{
            //    return false;
            //}
            
        }
    }
}
