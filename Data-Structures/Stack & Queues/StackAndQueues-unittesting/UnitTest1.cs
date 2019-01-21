using System;
using Xunit;
using StackesAndQueues.Classes;

namespace StackAndQueues_unittesting
{
    public class UnitTest1
    {
        //stacks Push
        //new stack with node already
        [Fact]
        public void TestStackPush1()
        {
            Node testNode1 = new Node(5);
            Stack testStack1 = new Stack(testNode1);
            testStack1.Push(10);
            Node topNode = testStack1.Peek();
            Assert.Equal(10, topNode.Value);
        }
        //new stack without node, so should be null then add 1
        [Fact]
        public void TestStackPush2()
        {
            Stack testStack2 = new Stack();
            testStack2.Push(5);
            Node topNode = testStack2.Peek();
            Assert.Equal(5, topNode.Value);
        }
        [Fact]
        public void TestStackPush3()
        {
            Stack testStack3 = new Stack();
            testStack3.Push(1);
            testStack3.Push(2);
            testStack3.Push(3);
            Node topNode = testStack3.Peek();
            Assert.Equal(3, topNode.Value);
        }

        //stacks Pop
        [Fact]
        public void TestStackPop1()
        {
            Stack testStack4 = new Stack();
            testStack4.Push(1);
            testStack4.Push(2);
            testStack4.Pop();
            Node topNode = testStack4.Peek();
            Assert.Equal(1, topNode.Value);
        }
        [Fact]
        public void TestStackPop2()
        {
            Node testNode5 = new Node(5);
            Stack testStack5 = new Stack(testNode5);
            testStack5.Push(10);
            testStack5.Push(20);
            testStack5.Pop();
            Node topNode = testStack5.Peek();
            Assert.Equal(10, topNode.Value);
        }
        [Fact]
        public void TestStackPop3()
        {
            Stack testStack6 = new Stack();
            testStack6.Push(1);
            testStack6.Push(2);
            testStack6.Pop();
            testStack6.Pop();
            testStack6.Pop(); //test trying to pop off more than whats in stack
            Node topNode = testStack6.Peek();
            Assert.Null(topNode);
        }

        //stacks Peek
        [Fact]
        public void TestStackPeek1()
        {
            Node testNode7 = new Node(5);
            Stack testStack7 = new Stack(testNode7);
            testStack7.Push(10);
            Node topNode = testStack7.Peek();
            Assert.Equal(10, topNode.Value);
        }
        [Fact]
        public void TestStackPeek2()
        {
            Stack testStack8 = new Stack();
            testStack8.Push(5);
            Node topNode = testStack8.Peek();
            Assert.Equal(5, topNode.Value);
        }
        [Fact]
        public void TestStackPeek3()
        {
            Stack testStack9 = new Stack();
            Node topNode = testStack9.Peek();
            Assert.Null(topNode); //tests empty stack
        }

        ////queues Enqueue
        //[Fact]
        //public void Test1()
        //{

        //}
        //[Fact]
        //public void Test1()
        //{

        //}
        //[Fact]
        //public void Test1()
        //{

        //}

        ////queues Dequeue
        //[Fact]
        //public void Test1()
        //{

        //}
        //[Fact]
        //public void Test1()
        //{

        //}
        //[Fact]
        //public void Test1()
        //{

        //}

        ////queues Peek
        //[Fact]
        //public void Test1()
        //{

        //}
        //[Fact]
        //public void Test1()
        //{

        //}
        //[Fact]
        //public void Test1()
        //{

        //}
    }
}
