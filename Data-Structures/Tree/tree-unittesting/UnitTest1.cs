using System;
using Xunit;
using Tree.Classes;

namespace tree_unittesting
{
    public class UnitTest1
    {
        //preorder
        [Fact]
        public void TestPreorder1()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(10);
            BinaryTree testTree1 = new BinaryTree(node1);
            BinaryTreeNode[] answer1 = new BinaryTreeNode[5];
            answer1 = testTree1.preOrder(testTree1.root);
            Assert.Equal(10, answer1[0].Value); //should just have the 10 value
        }
        [Fact]
        public void TestPreorder2()
        {
            BinaryTreeNode node2 = new BinaryTreeNode(10);
            BinaryTreeNode node3 = new BinaryTreeNode(20);
            BinaryTreeNode node4 = new BinaryTreeNode(30);
            BinaryTree testTree2 = new BinaryTree(node2);
            testTree2.root.LeftChild = node3;
            testTree2.root.RightChild = node4;
            BinaryTreeNode[] answer2 = new BinaryTreeNode[5];
            answer2 = testTree2.preOrder(testTree2.root); //answer should be 10 20 30
            Assert.Equal(30, answer2[2].Value);
        }
        [Fact]
        public void TestPreorder3()
        {
            BinaryTreeNode node5 = new BinaryTreeNode(10);
            BinaryTreeNode node6 = new BinaryTreeNode(20);
            BinaryTreeNode node7 = new BinaryTreeNode(30);
            BinaryTreeNode node8 = new BinaryTreeNode(40);
            BinaryTreeNode node9 = new BinaryTreeNode(50);
            BinaryTree testTree3 = new BinaryTree(node5);
            testTree3.root.LeftChild = node6;
            testTree3.root.RightChild = node7;
            testTree3.root.LeftChild.LeftChild = node8;
            testTree3.root.LeftChild.RightChild = node9;
            BinaryTreeNode[] answer3 = new BinaryTreeNode[5];
            answer3 = testTree3.preOrder(testTree3.root); //answer should be 10 20 40 50 30
            Assert.Equal(50, answer3[3].Value);
        }

        //inorder
        [Fact]
        public void TestInorder1()
        {
            BinaryTreeNode node10 = new BinaryTreeNode(10);
            BinaryTree testTree4 = new BinaryTree(node10);
            BinaryTreeNode[] answer4 = new BinaryTreeNode[5];
            answer4 = testTree4.inOrder(testTree4.root);
            Assert.Equal(10, answer4[0].Value); //should just have the 10 value
        }
        [Fact]
        public void TestInorder2()
        {
            BinaryTreeNode node11 = new BinaryTreeNode(10);
            BinaryTreeNode node12 = new BinaryTreeNode(20);
            BinaryTreeNode node13 = new BinaryTreeNode(30);
            BinaryTree testTree5 = new BinaryTree(node11);
            testTree5.root.LeftChild = node12;
            testTree5.root.RightChild = node13;
            BinaryTreeNode[] answer5 = new BinaryTreeNode[5];
            answer5 = testTree5.inOrder(testTree5.root); //answer should be 20 10 30
            Assert.Equal(10, answer5[1].Value);
        }
        [Fact]
        public void TestInorder3()
        {
            BinaryTreeNode node14 = new BinaryTreeNode(10);
            BinaryTreeNode node15 = new BinaryTreeNode(20);
            BinaryTreeNode node16 = new BinaryTreeNode(30);
            BinaryTreeNode node17 = new BinaryTreeNode(40);
            BinaryTreeNode node18 = new BinaryTreeNode(50);
            BinaryTree testTree6 = new BinaryTree(node14);
            testTree6.root.LeftChild = node15;
            testTree6.root.RightChild = node16;
            testTree6.root.LeftChild.LeftChild = node17;
            testTree6.root.LeftChild.RightChild = node18;
            BinaryTreeNode[] answer6 = new BinaryTreeNode[5];
            answer6 = testTree6.inOrder(testTree6.root); //answer should be 40 20 50 10 30
            Assert.Equal(10, answer6[3].Value);
        }

        //postorder
        [Fact]
        public void TestPostorder1()
        {
            BinaryTreeNode node19 = new BinaryTreeNode(10);
            BinaryTree testTree4 = new BinaryTree(node19);
            BinaryTreeNode[] answer7 = new BinaryTreeNode[5];
            answer7 = testTree4.postOrder(testTree4.root);
            Assert.Equal(10, answer7[0].Value); //should just have the 10 value
        }
        [Fact]
        public void TestPostorder2()
        {
            BinaryTreeNode node20 = new BinaryTreeNode(10);
            BinaryTreeNode node21 = new BinaryTreeNode(20);
            BinaryTreeNode node22 = new BinaryTreeNode(30);
            BinaryTree testTree5 = new BinaryTree(node20);
            testTree5.root.LeftChild = node21;
            testTree5.root.RightChild = node22;
            BinaryTreeNode[] answer8 = new BinaryTreeNode[5];
            answer8 = testTree5.postOrder(testTree5.root); //answer should be 20 30 10
            Assert.Equal(30, answer8[1].Value);
        }
        [Fact]
        public void TestPostorder3()
        {
            BinaryTreeNode node23 = new BinaryTreeNode(10);
            BinaryTreeNode node24 = new BinaryTreeNode(20);
            BinaryTreeNode node25 = new BinaryTreeNode(30);
            BinaryTreeNode node26 = new BinaryTreeNode(40);
            BinaryTreeNode node27 = new BinaryTreeNode(50);
            BinaryTree testTree6 = new BinaryTree(node23);
            testTree6.root.LeftChild = node24;
            testTree6.root.RightChild = node25;
            testTree6.root.LeftChild.LeftChild = node26;
            testTree6.root.LeftChild.RightChild = node27;
            BinaryTreeNode[] answer9 = new BinaryTreeNode[5];
            answer9 = testTree6.postOrder(testTree6.root); //answer should be 40 50 20 30 10
            Assert.Equal(10, answer9[4].Value);
        }

        //add

        //contains
    }
}

/*
Things to test:
binary node: nothing no methods
binary tree: 
    -preorder
    -inorder
    -postorder
binary search tree
    -add
    -contains
 */