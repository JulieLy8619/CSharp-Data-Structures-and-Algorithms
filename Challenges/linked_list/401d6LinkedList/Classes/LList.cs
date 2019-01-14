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

        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

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
                //Console.WriteLine("NEXT" + Current.Next);
                Console.Write(Current.Value + " -> ");
                Current = Current.Next;
            }
            Console.Write(Current.Value); //last node
        }


    }
}
