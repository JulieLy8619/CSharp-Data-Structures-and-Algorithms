using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    public class Hashtable
    {
        //properties
        KVNodeLinkList[] HashTableArray { get; set; }

        //instantiation
        public Hashtable()
        {
            HashTableArray = new KVNodeLinkList[5]; //choosing something small for testing purposes
        }

        //methods
        //add
        public void AddToHasTable(string key, string value)
        {
            int hashIndex = Hash(key);
            if (HashTableArray[hashIndex] == null)
            {
                HashTableArray[hashIndex].Insert(key, value);
            }
            else
            {
                KVNode newNode = new KVNode(key, value);
                HashTableArray[hashIndex].Append(newNode);
            }
        }

        //get
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

        //contains
        public bool HashTableContains(string key)
        {
            int hashIndex = Hash(key);
            if (HashTableArray[hashIndex].Includes(key) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //hash
        public static int Hash(string key)
        {
            int hashIndex = key.Length % 5;
            //Amanda said we're writing our own, she didn't say write a good one...
            return hashIndex;
        }
    }
}


//add: takes in both the key and value.This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
//get: takes in the key and returns the value from the table.
//contains: takes in the key and returns a boolean, indicating if the key exists in the table already.
//hash: takes in an arbitrary key and returns an index in the collection.
