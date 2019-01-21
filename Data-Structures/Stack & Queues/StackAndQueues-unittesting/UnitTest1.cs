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

        ////stacks Pop
        //[Fact]
        //public void Test1()
        //{

        //}
        //public void Test1()
        //{

        //}
        //public void Test1()
        //{

        //}

        ////stacks Peek
        //[Fact]
        //public void Test1()
        //{

        //}
        //public void Test1()
        //{

        //}
        //public void Test1()
        //{

        //}

        ////queues Enqueue
        //[Fact]
        //public void Test1()
        //{

        //}
        //public void Test1()
        //{

        //}
        //public void Test1()
        //{

        //}

        ////queues Dequeue
        //[Fact]
        //public void Test1()
        //{

        //}
        //public void Test1()
        //{

        //}
        //public void Test1()
        //{

        //}

        ////queues Peek
        //[Fact]
        //public void Test1()
        //{

        //}
        //public void Test1()
        //{

        //}
        //public void Test1()
        //{

        //}
    }
}
