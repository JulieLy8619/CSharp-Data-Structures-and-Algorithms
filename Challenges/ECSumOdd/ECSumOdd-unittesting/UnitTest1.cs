using BreadthFirstTraversal.Classes;
using ECSumOdd;
using System;
using Xunit;

namespace ECSumOdd_unittesting
{
    public class UnitTest1
    {
        //test no odd numbers
        [Fact]
        public void Test1()
        {
            TreeNode testTreeNode1 = new TreeNode(4);
            testTreeNode1.LeftChild = new TreeNode(2);
            testTreeNode1.RightChild = new TreeNode(6);
            int result = Program.ECSumOdd(testTreeNode1);
            Assert.Equal(0, result);
        }

        //test all odd numbers
        [Fact]
        public void Test2()
        {
            TreeNode testTreeNode2 = new TreeNode(3);
            testTreeNode2.LeftChild = new TreeNode(1);
            testTreeNode2.RightChild = new TreeNode(5);
            int result = Program.ECSumOdd(testTreeNode2);
            Assert.Equal(9, result);
        }

        //test with all neg numbers
        [Fact]
        public void Test3()
        {
            TreeNode testTreeNode3 = new TreeNode(-3);
            testTreeNode3.LeftChild = new TreeNode(-1);
            testTreeNode3.RightChild = new TreeNode(-5);
            int result = Program.ECSumOdd(testTreeNode3);
            Assert.Equal(-9, result);
        }

        //test with some neg numbers
        [Fact]
        public void Test4()
        {
            TreeNode testTreeNode4 = new TreeNode(50);
            testTreeNode4.LeftChild = new TreeNode(25);
            testTreeNode4.LeftChild.LeftChild = new TreeNode(-13);
            testTreeNode4.LeftChild.RightChild = new TreeNode(45);
            testTreeNode4.RightChild = new TreeNode(75);
            testTreeNode4.RightChild.LeftChild = new TreeNode(65);
            testTreeNode4.RightChild.RightChild = new TreeNode(100);
            int result = Program.ECSumOdd(testTreeNode4);
            Assert.Equal(197, result);
        }

        //test empty tree, retract that, I can't have an empty tree

    }
}
