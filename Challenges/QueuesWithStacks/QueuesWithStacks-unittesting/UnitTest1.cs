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

        [Fact]
        public void TestDeQWorks()
        {
            PseudoQueue newPseudoQ2 = new PseudoQueue();
            newPseudoQ2.PseudoQueueEnqueue(1);
            newPseudoQ2.PseudoQueueEnqueue(2);
            newPseudoQ2.PseudoQueueDequeue();
            Node answerNode = newPseudoQ2.PseudeoPeek();
            Assert.Equal(2, answerNode.Value); //2 is what should have been left in the "queue"
        }

        [Fact]
        public void TestNullDeQWorks()
        {
            PseudoQueue newPseudoQ3 = new PseudoQueue(2);
            newPseudoQ3.PseudoQueueEnqueue(1);
            newPseudoQ3.PseudoQueueDequeue();
            newPseudoQ3.PseudoQueueDequeue();
            newPseudoQ3.PseudoQueueDequeue(); //should error here or return null
            Node answerNode = newPseudoQ3.PseudeoPeek();
            Assert.Null(answerNode);
        }

        [Fact]
        public void TestEnQDeQWorks()
        {
            PseudoQueue newPseudoQ4 = new PseudoQueue(2);
            newPseudoQ4.PseudoQueueEnqueue(1);
            newPseudoQ4.PseudoQueueDequeue();
            newPseudoQ4.PseudoQueueDequeue();
            newPseudoQ4.PseudoQueueEnqueue(2);
            newPseudoQ4.PseudoQueueEnqueue(3);
            newPseudoQ4.PseudoQueueDequeue();
            Node answerNode = newPseudoQ4.PseudeoPeek();
            Assert.Equal(3, answerNode.Value);
        }
    }
}


/*
 Things I want to test
    -enqueuing- happy case
    -dequeuing- happy case
    -dequeuing a null "queue"
    -creating a queue without a node
    -creating a queue with a node
    -enqueuing 2, dequeing 2, enqueuing 2 and dequeuing 1
 */