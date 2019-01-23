using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class Stacks
    {
        //propertiy
        public Node Top { get; set; }

        //instantiate
        //stack created without a node given
        public Stacks()
        {
            Top = null;
        }

        //stack created with a node given
        public Stacks(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// adds a node to the stack
        /// </summary>
        /// <param name="value">value of the new node</param>
        public void Push(int value)
        {
            if (Top == null)
            {
                Node newNode = new Node(value);
                Top = newNode;
            }
            else
            {
                Node newNode = new Node(value);
                newNode.Next = Top;
                Top = newNode;
            }
        }

        /// <summary>
        /// remove a node from the stack
        /// </summary>
        /// <returns>the top node</returns>
        public Node Pop()
        {
            //should add check for if trying to pop from a null stack
            if (Top == null)
            {
                Console.WriteLine("The stack is empty");
                return null;
            }
            else
            {
                Node tempNode = Top;
                Top = Top.Next;
                tempNode.Next = null;
                return tempNode;
            }
        }

        /// <summary>
        /// looks at what is on the top of the stack
        /// </summary>
        /// <returns>the information of the top node in the stack</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
