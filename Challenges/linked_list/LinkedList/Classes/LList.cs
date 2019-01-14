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
        /// this adds a new node at the beginning of the linked list
        /// </summary>
        /// <param name="value">takes in the value one would like assigned to the node</param>
        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// wlks through the linked list and determines if a node with a certain value is in the list
        /// </summary>
        /// <param name="value">value one is looking for</param>
        /// <returns>true or false if a node with that value is found or not</returns>
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

        public void Print()
        {
            // output to the console the linked list
            Current = Head;
            while (Current.Next != null)
            {
                Console.Write(Current.Value + " -> ");
            }

        }


    }
}
