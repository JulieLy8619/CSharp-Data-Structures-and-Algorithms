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
        //get head
        [Fact]
        public void TestGetHeadLL()
        {
            KVNodeLinkList testKVLL1 = new KVNodeLinkList();
            Assert.Null(testKVLL1.Head);
        }

        //set head
        [Fact]
        public void TestSetHeadLL()
        {
            KVNode testNode10 = new KVNode("cat", "dog");
            KVNodeLinkList testKVLL2 = new KVNodeLinkList();
            testKVLL2.Head = testNode10;
            Assert.Equal(testNode10, testKVLL2.Head);
        }

        //get current
        [Fact]
        public void TestGetCurrentLL()
        {
            KVNode testNode11 = new KVNode("cat", "dog");
            KVNodeLinkList testKVLL3 = new KVNodeLinkList();
            testKVLL3.Current = testNode11;
            Assert.Equal(testNode11, testKVLL3.Current);
        }

        //set current
        [Fact]
        public void TestSetCurrentLL()
        {
            KVNode testNode12 = new KVNode("cat", "dog");
            KVNode testNode13 = new KVNode("cat", "dog");
            KVNodeLinkList testKVLL4 = new KVNodeLinkList();
            testKVLL4.Current = testNode12;
            testKVLL4.Current = testNode13;
            Assert.Equal(testNode13, testKVLL4.Current);
        }

        //insert
        [Fact]
        public void TestLLInsert()
        {
            KVNodeLinkList testKVLL5 = new KVNodeLinkList();
            testKVLL5.Insert("cat", "dog");
            Assert.Equal("cat", testKVLL5.Head.Key);
        }

        //includes-true
        [Fact]
        public void TestLLIncludeTrue()
        {
            KVNodeLinkList testKVLL6 = new KVNodeLinkList();
            testKVLL6.Insert("cat", "dog");
            bool llAnswer1 = testKVLL6.Includes("cat");
            Assert.True(llAnswer1);
        }

        //includes- false
        [Fact]
        public void TestLLIncludeFalse()
        {
            KVNodeLinkList testKVLL7 = new KVNodeLinkList();
            testKVLL7.Insert("cat", "dog");
            bool llAnswer2 = testKVLL7.Includes("Apple");
            Assert.False(llAnswer2);
        }

        //append
        [Fact]
        public void TestLLAppend()
        {
            KVNodeLinkList testKVLL8 = new KVNodeLinkList();
            testKVLL8.Insert("cat", "dog");
            KVNode testNode14 = new KVNode("apple", "pear");
            testKVLL8.Append(testNode14);
            Assert.Equal("apple", testKVLL8.Head.Next.Key);
        }

        //test Hashtable=============================
        //Adding a key/value to your hashtable results in the value being in the data structure
        [Fact]
        public void TestHashTableAdd()
        {
            Hashtable testHashTable1 = new Hashtable();
            testHashTable1.AddToHashTable("cat", "dog");
            Assert.Equal("cat", testHashTable1.HashTableArray[3].Head.Key);
        }

        //Retrieving based on a key returns the value stored

        //Successfully returns null for a key that does not exist in the hashtable

        //Successfully handle a collision within the hashtable

        //Successfully retrieve a value from a bucket within the hashtable that has a collision

        //Successfully hash a key to an in-range value
        [Fact]
        public void TestHashIndexNumber()
        {
            Hashtable testHashTable1 = new Hashtable();
            int htAnswer1 = testHashTable1.Hash("a");
            Assert.Equal(1, htAnswer1);
        }


    }
}


