using System;
using Xunit;
using BreadthFirstTraversal.Classes;
using TreeHeight;

namespace TreeHeight_unittesting
{
    public class UnitTest1
    {
        //happy case for tree height
        [Fact]
        public void TestHappyCaseHeight()
        {
            TreeNode testTreeNode1 = new TreeNode(100);
            testTreeNode1.LeftChild = new TreeNode(200);
            testTreeNode1.RightChild = new TreeNode(1);
            int answer1 = Program.FindTreeHeight(testTreeNode1);
            Assert.Equal(1, answer1);
        }

        //null tree for tree height
        //which I can't test for a null tree because i don't have a way to set up a null tree

        //uneven tree for tree height
        [Fact]
        public void TestUnevenCaseHeight()
        {
            TreeNode testTreeNode2 = new TreeNode(100);
            testTreeNode2.LeftChild = new TreeNode(200);
            testTreeNode2.RightChild = new TreeNode(1);
            testTreeNode2.RightChild.LeftChild = new TreeNode(5);
            testTreeNode2.RightChild.LeftChild.LeftChild = new TreeNode(50);
            int answer2 = Program.FindTreeHeight(testTreeNode2);
            Assert.Equal(3, answer2);
        }

        //a node without children height
        [Fact]
        public void TestNoChildrenCaseHeight()
        {
            TreeNode testTreeNode3 = new TreeNode(100);
            int answer3 = Program.FindTreeHeight(testTreeNode3);
            Assert.Equal(0, answer3);
        }

        //happy case for tree level
        [Fact]
        public void TestHappyCaseLevel()
        {
            TreeNode testTreeNode4 = new TreeNode(100);
            testTreeNode4.LeftChild = new TreeNode(200);
            testTreeNode4.RightChild = new TreeNode(1);
            int answer4 = Program.FindTreeLevel(testTreeNode4);
            Assert.Equal(2, answer4);
        }

        //null tree for tree level
        //which I can't test for a null tree because i don't have a way to set up a null tree

        //uneven tree fro tree level
        [Fact]
        public void TestUnevenCaseLevel()
        {
            TreeNode testTreeNode5 = new TreeNode(100);
            testTreeNode5.LeftChild = new TreeNode(200);
            testTreeNode5.RightChild = new TreeNode(1);
            testTreeNode5.RightChild.LeftChild = new TreeNode(5);
            testTreeNode5.RightChild.LeftChild.LeftChild = new TreeNode(50);
            int answer5 = Program.FindTreeLevel(testTreeNode5);
            Assert.Equal(4, answer5);
        }

        //a node without children level
        [Fact]
        public void TestNoChildrenCaseLevel()
        {
            TreeNode testTreeNode6 = new TreeNode(100);
            int answer6 = Program.FindTreeLevel(testTreeNode6);
            Assert.Equal(1, answer6);
        }
    }
}
