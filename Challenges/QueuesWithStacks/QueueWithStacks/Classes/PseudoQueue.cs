using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        //properties
        Stacks inStack = new Stacks();
        Stacks outStack = new Stacks();

        //instruction said to instantiate the stacks in the class
        //queue with nothing given
        public PseudoQueue()
        {
            //inStack = null;
            //outStack = null;
        }

        //instantiate a "queue" with a node
        public PseudoQueue(int value)
        {
            inStack.Push(value);
        }

        /// <summary>
        /// will remove one node from the "front" of the "queue"
        /// </summary>
        /// <param name="node">returns "top" node</param>
        public Node PseudoQueueDequeue()
        {
            if (outStack.Top != null)

            {
                return outStack.Pop();
            }
            else
            {
                while (inStack.Top != null)
                {
                    Node tempNode = inStack.Pop();
                    outStack.Push(tempNode.Value);
                }
                return outStack.Pop();
            }
        }

        /// <summary>
        /// added a node to the end of the "queue" so this puts it into the IN stack
        /// </summary>
        /// <param name="value">value of node you want to add</param>
        public void PseudoQueueEnqueue(int value)
        {
            inStack.Push(value);
        }

        /// <summary>
        /// peek what is at "front" of "queue" (I needed this for testing purposes
        /// </summary>
        /// <returns>node at "front" of "queue"</returns>
        public Node PseudeoPeek()
        {
            if (outStack.Top != null)
            {
                return outStack.Peek();
            }
            else
            {
                while (inStack.Top != null)
                {
                    Node tempNode = inStack.Pop();
                    outStack.Push(tempNode.Value);
                }
                return outStack.Peek();
            }
        }
    }

}
