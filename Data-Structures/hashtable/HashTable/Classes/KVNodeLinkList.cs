using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    public class KVNodeLinkList
    {
        public KVNode Head { get; set; }
        public KVNode Current { get; set; }

        public KVNodeLinkList()
        {
            Head = null;
        }

        public void Insert(string key, string value)
        {
            KVNode node = new KVNode(key, value);
            node.Next = Head;
            Head = node;
        }

        public bool Includes(string key)
        {
            Current = Head;
            if (Head == null)
            {
                return false;
            }
            else
            {
                while (Current.Next != null)
                {
                    if (Current.Key == key)
                    {
                        return true;
                    }
                    Current = Current.Next;
                }
                if (Current.Key == key)
                {
                    return true;
                }

                return false;
            }
        }

        public void Append(KVNode node)
        {
            Current = Head; 
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = node;
        }
    }
}
