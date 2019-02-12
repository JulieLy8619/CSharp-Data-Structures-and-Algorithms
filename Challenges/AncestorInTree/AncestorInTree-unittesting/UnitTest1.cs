using AncestoryInTree;
using BreadthFirstTraversal.Classes;
using System;
using Xunit;

namespace AncestorInTree_unittesting
{
    public class UnitTest1
    {
        //test happy case
        [Fact]
        public void TestHappyCase()
        {
            TreeNode treeNode1 = new TreeNode(8);
            treeNode1.LeftChild = new TreeNode(5);
            treeNode1.RightChild = new TreeNode(6);
            treeNode1.RightChild.LeftChild = new TreeNode(1);
            treeNode1.RightChild.RightChild = new TreeNode(3);
            bool answer1 = Program.IsAncestor(8, 3, treeNode1);
            Assert.True(answer1);
        }

        //test neither is in tree
        [Fact]
        public void TestBadCase()
        {
            TreeNode treeNode2 = new TreeNode(8);
            treeNode2.LeftChild = new TreeNode(5);
            treeNode2.RightChild = new TreeNode(6);
            treeNode2.RightChild.LeftChild = new TreeNode(1);
            treeNode2.RightChild.RightChild = new TreeNode(3);
            bool answer2 = Program.IsAncestor(1, 2, treeNode2);
            Assert.False(answer2);
        }

        //test one is in the tree
        [Fact]
        public void TestANotInTree()
        {
            TreeNode treeNode3 = new TreeNode(8);
            treeNode3.LeftChild = new TreeNode(5);
            treeNode3.RightChild = new TreeNode(6);
            treeNode3.RightChild.LeftChild = new TreeNode(1);
            treeNode3.RightChild.RightChild = new TreeNode(3);
            bool answer3 = Program.IsAncestor(1, 6, treeNode3);
            Assert.False(answer3);
        }

        //test other is in the tree
        [Fact]
        public void TestBNotInTree()
        {
            TreeNode treeNode4 = new TreeNode(8);
            treeNode4.LeftChild = new TreeNode(5);
            treeNode4.RightChild = new TreeNode(6);
            treeNode4.RightChild.LeftChild = new TreeNode(1);
            treeNode4.RightChild.RightChild = new TreeNode(3);
            bool answer4 = Program.IsAncestor(8, 100, treeNode4);
            Assert.False(answer4);
        }

        //test wrong order
        [Fact]
        public void TestWrongOrder()
        {
            TreeNode treeNode5 = new TreeNode(8);
            treeNode5.LeftChild = new TreeNode(5);
            treeNode5.RightChild = new TreeNode(6);
            treeNode5.RightChild.LeftChild = new TreeNode(1);
            treeNode5.RightChild.RightChild = new TreeNode(3);
            bool answer5 = Program.IsAncestor(6, 8, treeNode5);
            Assert.False(answer5);
        }
    }
}
