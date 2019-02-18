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

        /// <summary>
        /// adds key value node to linked list
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        public void Insert(string key, string value)
        {
            KVNode node = new KVNode(key, value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// checks if key is in linked list
        /// </summary>
        /// <param name="key">the key</param>
        /// <returns>true if found, false otherwise</returns>
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
        /// <summary>
        /// adds a node to the end of the linked list
        /// </summary>
        /// <param name="node">the node to add</param>
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
