using HashTable.Classes;
using System;
using Xunit;

namespace hashtable_unittesting
{
    public class UnitTest1
    {
        //test KVNodes==============================
        //get key
        [Fact]
        public void TestGetKVNodeKey()
        {
            KVNode testNode1 = new KVNode("cat", "dog");
            Assert.Equal("cat", testNode1.Key);
        }

        //set key
        [Fact]
        public void TestSetKVNodeKey()
        {
            KVNode testNode2 = new KVNode("cat", "dog");
            testNode2.Key = "NewKey";
            Assert.Equal("NewKey", testNode2.Key);
        }

        //get value
        [Fact]
        public void TestGetKVNodeValue()
        {
            KVNode testNode3 = new KVNode("cat", "dog");
            Assert.Equal("dog", testNode3.Value);
        }

        //set value
        [Fact]
        public void TestSetKVNodeValue()
        {
            KVNode testNode4 = new KVNode("cat", "dog");
            testNode4.Value = "NewValue";
            Assert.Equal("NewValue", testNode4.Value);
        }

        //get next
        //I don't know if this was the right way to do get for next because I assigned it...
        [Fact]
        public void TestGetKVNodeNext()
        {
            KVNode testNode5 = new KVNode("cat", "dog");
            KVNode testNode6 = new KVNode("red", "blue");
            testNode5.Next = testNode6;
            Assert.Equal(testNode6, testNode5.Next);
        }

        //set next
        [Fact]
        public void TestSetKVNodeNext()
        {
            KVNode testNode7 = new KVNode("cat", "dog");
            KVNode testNode8 = new KVNode("red", "blue");
            KVNode testNode9 = new KVNode("apple", "banana");
            testNode7.Next = testNode8;
            testNode7.Next = testNode9;
            Assert.Equal(testNode9, testNode7.Next);
        }

        //test KVNodeLinkList========================

        //test Hashtable=============================
    }
}


//Adding a key/value to your hashtable results in the value being in the data structure
//Retrieving based on a key returns the value stored
//Successfully returns null for a key that does not exist in the hashtable
//Successfully handle a collision within the hashtable
//Successfully retrieve a value from a bucket within the hashtable that has a collision
//Successfully hash a key to an in-range value