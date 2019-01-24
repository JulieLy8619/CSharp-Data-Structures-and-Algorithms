using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        //properties
        public Stacks frontStack = new Stacks();
        public Stacks rearStack = new Stacks();
        //public Stacks rearStack { get; set; }
        //public Stacks frontStack { get; set; }


        //instruction said to instantiate the stacks in this class

        //instantiate
        //queue with nothing given
        public PseudoQueue()
        {
            rearStack = null;
            frontStack = null;
        }

        //instantiate a "queue" with a node
        public PseudoQueue(int value)
        {
            frontStack.Push(value); //which should point "top" to this node
        }

        /// <summary>
        /// will remove one node from the "front" of the "queue"
        /// </summary>
        /// <param name="node">returns "top" node</param>
        public Node PseudoQueueDequeue()
        {
            //if stack is empty
            if (frontStack.Top == null)
            {
                return null;
            }
            else
            {
                //just has one node in list
                //need to add if we try to dequeue more than what is in the list
                if (frontStack.Top.Next == null)
                {
                    return frontStack.Top;
                }
                else
                {
                    do
                    {
                        Node tempNode1 = frontStack.Pop();
                        rearStack.Push(tempNode1.Value);
                    } while (frontStack.Top.Next != null);
                    Node returnNode = frontStack.Pop();
                    do
                    {
                        Node tempNode2 = rearStack.Pop();
                        frontStack.Push(tempNode2.Value);
                    } while (rearStack.Top.Next != null); //moves all back to front stack
                    //do it once more for last item
                    Node tempNode3 = rearStack.Pop();
                    frontStack.Push(tempNode3.Value);
                    return returnNode;
                }
            }
        }

        /// <summary>
        /// added a node to the end of the "queue" (which is the bottom of the bottom of the stack)
        /// </summary>
        /// <param name="value">value of node you want to add</param>
        /// <returns>the queue (which is the stack) after the new node is added</returns>
        public void PseudoQueueEnqueue(int value)
        {
            //if (frontStack == null)
            //{
            //    Node newNode = new Node(value);
            //    frontStack.Top = newNode;
            //}
            //else
            //{
                frontStack.Push(value);
            //return frontStack;
        //}
        }

        //just so I can check and see it is working
        //not allowed to iterate through a stack or queue
        public void PseudoQueuePrint()
        {
            Node tempIterator = frontStack.Top;
            do
            {
                Console.Write(tempIterator.Value + " => ");
                tempIterator = tempIterator.Next;
            } while (tempIterator.Next != null); //this breaks when I only have one item in stack
            Console.WriteLine(tempIterator.Value);

        }
    }

}
