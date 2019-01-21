using System;
using System.Collections.Generic;
using System.Text;

namespace StackesAndQueues.Classes
{
    public class Stack
    {
        //propertiy
        public Node Top { get; set; }
        
        //instantiate
        //stack created without a node given
        public Stack()
        {
            Top = null;
        }

        //stack created with a node given
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// adds a node to the stack
        /// </summary>
        /// <param name="value">value of the new node</param>
        public void Push(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Top;
            Top = newNode;
        }

        /// <summary>
        /// remove a node from the stack
        /// </summary>
        /// <returns>the top node</returns>
        public Node Pop()
        {
            Node tempNode = Top;
            Top = Top.Next;
            tempNode.Next = null;
            return tempNode;
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
