using BreadthFirstTraversal.Classes;
using System;
using Xunit;

namespace BreadthFirst_unittesting
{
    public class UnitTest1
    {
        //enqueue
        [Fact]
        public void TestEQ1()
        {
            TreeNode treeNode1 = new TreeNode(1);
            TreeNode treeNode2 = new TreeNode(2);
            Node node1 = new Node(treeNode1);
            QueueForTrees newQueue1 = new QueueForTrees(node1);
            newQueue1.Enqueue(treeNode2);
            Assert.Equal(2, newQueue1.Rear.Value.Value);
        }
        [Fact]
        public void TestEQ2()
        {
            TreeNode treeNode3 = new TreeNode(1);
            TreeNode treeNode4 = new TreeNode(2);
            TreeNode treeNode5 = new TreeNode(3);
            Node node2 = new Node(treeNode3);
            QueueForTrees newQueue2 = new QueueForTrees(node2);
            newQueue2.Enqueue(treeNode4);
            newQueue2.Enqueue(treeNode5);
            Assert.Equal(3, newQueue2.Rear.Value.Value);
        }
        [Fact]
        public void TestEQ3()
        {
            TreeNode treeNode6 = new TreeNode(1);
            TreeNode treeNode7 = new TreeNode(2);
            TreeNode treeNode8 = new TreeNode(3);
            TreeNode treeNode9 = new TreeNode(4);
            Node node3 = new Node(treeNode6);
            QueueForTrees newQueue3 = new QueueForTrees(node3);
            newQueue3.Enqueue(treeNode7);
            newQueue3.Enqueue(treeNode8);
            newQueue3.Enqueue(treeNode9);
            Assert.Equal(4, newQueue3.Rear.Value.Value);
        }

        //dequeue
        [Fact]
        public void TestDQ1()
        {
            TreeNode treeNode10 = new TreeNode(1);
            TreeNode treeNode11 = new TreeNode(2);
            TreeNode treeNode12 = new TreeNode(3);
            TreeNode treeNode13 = new TreeNode(4);
            Node node4 = new Node(treeNode10);
            QueueForTrees newQueue4 = new QueueForTrees(node4);
            newQueue4.Enqueue(treeNode11);
            newQueue4.Enqueue(treeNode12);
            newQueue4.Enqueue(treeNode13);
            newQueue4.Dequeue();
            Assert.Equal(2, newQueue4.Front.Value.Value);
        }
        [Fact]
        public void TestDQ2()
        {
            TreeNode treeNode14 = new TreeNode(1);
            TreeNode treeNode15 = new TreeNode(2);
            Node node5 = new Node(treeNode14);
            QueueForTrees newQueue5 = new QueueForTrees(node5);
            newQueue5.Enqueue(treeNode15);
            Node returnNode1 = newQueue5.Dequeue();
            Assert.Equal(1, returnNode1.Value.Value);
        }
        [Fact]
        public void TestDQ3()
        {
            TreeNode treeNode16 = new TreeNode(1);
            TreeNode treeNode17 = new TreeNode(2);
            Node node6 = new Node(treeNode16);
            QueueForTrees newQueue6 = new QueueForTrees(node6);
            newQueue6.Enqueue(treeNode17);
            newQueue6.Dequeue();
            Node returnNode2 = newQueue6.Dequeue();
            Assert.Equal(2, returnNode2.Value.Value);
        }

        //peek
        //test for a null queue
        [Fact]
        public void TestPeek1()
        {
            TreeNode treeNode18 = new TreeNode(1);
            TreeNode treeNode19 = new TreeNode(2);
            Node node7 = new Node(treeNode18);
            QueueForTrees newQueue7 = new QueueForTrees(node7);
            newQueue7.Enqueue(treeNode19);
            Node returnNode3 = newQueue7.Peek();
            Assert.Equal(1, returnNode3.Value.Value);
        }
        [Fact]
        public void TestPeek2()
        {
            QueueForTrees newQueue8 = new QueueForTrees();
            Node returnNode4 = newQueue8.Peek();
            Assert.Null(returnNode4);
        }
        [Fact]
        public void TestPeek3()
        {
            TreeNode treeNode20 = new TreeNode(1);
            TreeNode treeNode21 = new TreeNode(2);
            Node node8 = new Node(treeNode20);
            QueueForTrees newQueue9 = new QueueForTrees(node8);
            newQueue9.Enqueue(treeNode21);
            newQueue9.Dequeue();
            Node returnNode5 = newQueue9.Peek();
            Assert.Equal(2, returnNode5.Value.Value);
        }
    }
}
//breadthfirst was a void method and it empties it's queue so I couldn't test it.