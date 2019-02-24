using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    public class Hashtable
    {
        //properties
        public KVNodeLinkList[] HashTableArray { get; set; }

        //instantiation
        public Hashtable()
        {
            HashTableArray = new KVNodeLinkList[1024]; 
        }

        //methods
        /// <summary>
        /// Adds a new key value pair to hash table
        /// </summary>
        /// <param name="key">the key</param>
        /// <param name="value">the value</param>
        public void AddToHashTable(string key, string value)
        {
            int hashIndex = Hash(key);
            if (HashTableArray[hashIndex] == null)
            {
                KVNodeLinkList tempLL = new KVNodeLinkList();
                HashTableArray[hashIndex] = tempLL;
                HashTableArray[hashIndex].Insert(key, value);
            }
            else
            {
                KVNode newNode = new KVNode(key, value);
                HashTableArray[hashIndex].Append(newNode);
            }
        }

        /// <summary>
        /// Will find the value of the given key, in a hashtable
        /// </summary>
        /// <param name="key">the key</param>
        /// <returns>the key's value</returns>
        public string GetFromHashTable(string key)
        {
            int hashIndex = Hash(key);
            if (HashTableArray[hashIndex] == null)
            {
                Console.WriteLine(key + " isn't in the HashTable");
                return null;
            }
            else
            {
                if (HashTableArray[hashIndex].Includes(key) == true)
                {
                    while (HashTableArray[hashIndex].Current.Next != null)
                    {
                        if (HashTableArray[hashIndex].Current.Key == key)
                        {
                            return HashTableArray[hashIndex].Current.Value;
                        }
                        HashTableArray[hashIndex].Current = HashTableArray[hashIndex].Current.Next;
                    }
                    if (HashTableArray[hashIndex].Current.Key == key)
                    {
                        return HashTableArray[hashIndex].Current.Value;
                    }
                    else
                    {
                        Console.WriteLine(key + " isn't in the HashTable");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine(key + " isn't in the HashTable");
                    return null;
                }
            }

        }

        /// <summary>
        /// Will check if the key is in the hashtable
        /// </summary>
        /// <param name="key">the key</param>
        /// <returns>true if it is, false if it is not</returns>
        public bool HashTableContains(string key)
        {
            int hashIndex = Hash(key);
            if (HashTableArray[hashIndex] == null)
            {
                return false;
            }
            else if (HashTableArray[hashIndex].Includes(key) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Will hash the key into a number that can be an index in the hashtable
        /// </summary>
        /// <param name="key">the key</param>
        /// <returns>the index number</returns>
        public int Hash(string key)
        {
            int hashIndex = 0;
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(key);
            for (int i = 0; i < ASCIIValues.Length; i++)
            {
                hashIndex = hashIndex + ASCIIValues[i];
            }
            hashIndex = hashIndex % 1024;
            return hashIndex;
        }
    }
}

