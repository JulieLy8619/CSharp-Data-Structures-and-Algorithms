using System;

namespace _401d6LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        //public LList(Node node)
        //{
        //    Head = node;
        //}

        /// <summary>
        /// inserts a node at the beginning of the linked list
        /// </summary>
        /// <param name="value">takes in the new value of the node</param>
        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// checks if a value is in the node list
        /// </summary>
        /// <param name="value">value one is looking for</param>
        /// <returns>true or false if the value is in the list</returns>
        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// walks through node lists and prints value to screen
        /// </summary>
        public void Print()
        {
            // output to the console the linked list
            Current = Head;
            while (Current.Next != null)
            {
                //Console.WriteLine("NEXT" + Current.Next);
                Console.Write(Current.Value + " -> ");
                Current = Current.Next;
            }
            Console.Write(Current.Value); //last node
        }


    }
}
