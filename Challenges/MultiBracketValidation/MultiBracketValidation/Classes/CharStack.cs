using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
{
    class CharStack
    {
        //propertiy
        public CharNode Top { get; set; }

        //instantiate
        //stack created without a node given
        public CharStack()
        {
            Top = null;
        }

        //stack created with a node given
        public CharStack(CharNode node)
        {
            Top = node;
        }

        /// <summary>
        /// adds a node to the stack
        /// </summary>
        /// <param name="value">value of the new node</param>
        public void Push(char value)
        {
            CharNode newNode = new CharNode(value);
            newNode.Next = Top;
            Top = newNode;
        }

        /// <summary>
        /// remove a node from the stack
        /// </summary>
        /// <returns>the top node</returns>
        public CharNode Pop()
        {
            //should add check for if trying to pop from a null stack
            if (Top == null)
            {
                Console.WriteLine("The stack is empty");
                return null;
            }
            else
            {
                CharNode tempNode = Top;
                Top = Top.Next;
                tempNode.Next = null;
                return tempNode;
            }
        }

        /// <summary>
        /// looks at what is on the top of the stack
        /// </summary>
        /// <returns>the information of the top node in the stack</returns>
        public CharNode Peek()
        {
            return Top;
        }
    }
}
