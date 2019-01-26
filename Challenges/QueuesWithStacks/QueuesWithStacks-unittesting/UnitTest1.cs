using System;
using Xunit;
using QueueWithStacks.Classes;
using QueueWithStacks;

namespace QueuesWithStacks_unittesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestEnQWorks()
        {
            PseudoQueue newPseudoQ = new PseudoQueue();
            newPseudoQ.PseudoQueueEnqueue(5);
            Node answerNode = newPseudoQ.PseudeoPeek();
            Assert.Equal(5, answerNode.Value);
        }

        //[Fact]
        //public void TestDeQWorks()
        //{

        //}

        //[Fact]
        //public void TestNullDeQWorks()
        //{

        //}
    }
}


/*
 Things I want to test
    -enqueuing- happy case
    -dequeuing- happy case
    -dequeuing a null "queue"
    -enqueuing 2, dequeing 2, enqueuing 2 and dequeuing 1
 */