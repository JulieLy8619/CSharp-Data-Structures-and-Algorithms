using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        //properties
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public Stack rearStack { get; set; }
        public Stack frontStack { get; set; }

        //instruction said to instantiate the stacks in this class

        //instantiate
        //queue with nothing given
        public PseudoQueue()
        {
            rearStack = null;
            frontStack = null;
            Front = null;
            Rear = null;
        }

        //queue with a given node
        //fo now we'll say we only can instantiate an empty queue
        //public PseudoQueue(Stack inputStack)
        //{
        //    Stack rearStack = inputStack
        //    Rear = inputStack.Top;
        //    //flip stack and set front
        //    Front = node;
        //}

        //start a queue with a node
        public PseudoQueue(Node node)
        {
            frontStack.Push(node);
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// will remove one node from the front of the "queue"
        /// </summary>
        /// <param name="node">returns "top" node</param>
        public Node PseudoQueueDequeue(Node node)
        {
            //if satacks are empty
            if (Front == null)
            {
                return null;
            }
            else
            {
                Node temp = Front;
                Front = Front.Next;
                temp.Next = null;
                frontStack.Pop();
                return temp;
            }
        }

        /// <summary>
        /// added a node to the end of the "queue"
        /// </summary>
        /// <param name="value">value of node you want to add</param>
        /// <returns>the queue after the new node is added</returns>
        public PseudoQueue PseudoQueueEnqueue(int value)
        {

        }

        //technically the docks didn't say we needed to do this
        //public Node PseudoPeek()
        //{

        //}
    }
}
