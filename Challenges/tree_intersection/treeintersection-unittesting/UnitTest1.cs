using BreadthFirstTraversal.Classes;
using System;
using Xunit;
using System.Collections.Generic;
using TreeIntersection;

namespace treeintersection_unittesting
{
    public class UnitTest1
    {
        //happy case returns found items
        [Fact]
        public void TestHappyPass()
        {
            TreeNode testBTNode1 = new TreeNode(10);
            TreeNode testBTNode1Left = new TreeNode(100);
            TreeNode testBTNode1Right = new TreeNode(5);
            testBTNode1.LeftChild = testBTNode1Left;
            testBTNode1.RightChild = testBTNode1Right;
            BinaryTree testTree1 = new BinaryTree(testBTNode1);

            TreeNode testBTNode2 = new TreeNode(100);
            TreeNode testBTNode2Left = new TreeNode(1);
            TreeNode testBTNode2Right = new TreeNode(5);
            testBTNode2.LeftChild = testBTNode2Left;
            testBTNode2.RightChild = testBTNode2Right;
            BinaryTree testTree2 = new BinaryTree(testBTNode2);

            List<int> testAnswer1 = Program.TreeIntersection(testTree1, testTree2);

            Assert.Equal(100, testAnswer1[0]);
        }

        //happy fail, returns no matchs for trees that didn't have any matches
        [Fact]
        public void TestHapyFail()
        {
            TreeNode testBTNode3 = new TreeNode(10);
            TreeNode testBTNode3Left = new TreeNode(100);
            TreeNode testBTNode3Right = new TreeNode(5);
            testBTNode3.LeftChild = testBTNode3Left;
            testBTNode3.RightChild = testBTNode3Right;
            BinaryTree testTree3 = new BinaryTree(testBTNode3);

            TreeNode testBTNode4 = new TreeNode(-10);
            TreeNode testBTNode4Left = new TreeNode(-100);
            TreeNode testBTNode4Right = new TreeNode(-5);
            testBTNode4.LeftChild = testBTNode4Left;
            testBTNode4.RightChild = testBTNode4Right;
            BinaryTree testTree4 = new BinaryTree(testBTNode4);

            List<int> testAnswer2 = Program.TreeIntersection(testTree3, testTree4);

            Assert.Empty(testAnswer2);
        }

        //an empty tree
        [Fact]
        public void TestEmptyTree()
        {
            TreeNode testBTNode5 = new TreeNode(10);
            TreeNode testBTNode5Left = new TreeNode(100);
            TreeNode testBTNode5Right = new TreeNode(5);
            testBTNode5.LeftChild = testBTNode5Left;
            testBTNode5.RightChild = testBTNode5Right;
            BinaryTree testTree5 = new BinaryTree(testBTNode5);

            BinaryTree testTree6 = null;

            List<int> testAnswer3 = Program.TreeIntersection(testTree5, testTree6);

            Assert.Empty(testAnswer3);
        }
    }
}
