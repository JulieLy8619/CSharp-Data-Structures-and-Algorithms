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
            HashTableArray = new KVNodeLinkList[10]; //choosing something small for testing purposes
        }

        //methods
        public void Add(string key, string value)
        {

        }

    }
}


//add: takes in both the key and value.This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
//get: takes in the key and returns the value from the table.
//contains: takes in the key and returns a boolean, indicating if the key exists in the table already.
//hash: takes in an arbitrary key and returns an index in the collection.
