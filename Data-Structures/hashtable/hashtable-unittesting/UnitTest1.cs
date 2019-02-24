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
        public void TestHashTableAdd1()
        {
            Hashtable testHashTable1 = new Hashtable();
            testHashTable1.AddToHashTable("cat", "dog");
            Assert.Equal("cat", testHashTable1.HashTableArray[312].Head.Key);
        }
        [Fact]
        public void TestHashTableAdd2()
        {
            Hashtable testHashTable2 = new Hashtable();
            testHashTable2.AddToHashTable("cat", "dog");
            Assert.Equal("dog", testHashTable2.HashTableArray[312].Head.Value);
        }

        //Retrieving based on a key returns the value stored
        [Fact]
        public void TestHashTableGet()
        {
            Hashtable testHashTable3 = new Hashtable();
            testHashTable3.AddToHashTable("cat", "dog");
            string testAnswer1 = testHashTable3.GetFromHashTable("cat");
            Assert.Equal("dog", testAnswer1);
        }

        //Successfully returns null for a key that does not exist in the hashtable
        [Fact]
        public void TestHashTableGetForNull()
        {
            Hashtable testHashTable4 = new Hashtable();
            testHashTable4.AddToHashTable("cat", "dog");
            string testAnswer2 = testHashTable4.GetFromHashTable("bob");
            Assert.Null(testAnswer2);
        }

        //Successfully handle a collision within the hashtable
        [Fact]
        public void TestHashTableCollision1()
        {
            Hashtable testHashTable5 = new Hashtable();
            testHashTable5.AddToHashTable("cat", "dog");
            testHashTable5.AddToHashTable("rat", "newValue");
            string testAnswer3 = testHashTable5.GetFromHashTable("rat");
            Assert.Equal("newValue", testAnswer3);
        }
        [Fact]
        public void TestHashTableCollision2()
        {
            Hashtable testHashTable6 = new Hashtable();
            testHashTable6.AddToHashTable("cat", "dog");
            testHashTable6.AddToHashTable("rat", "newValue");
            string testAnswer4 = testHashTable6.GetFromHashTable("cat"); //checking orig is still there too
            Assert.Equal("dog", testAnswer4);
        }

        //Successfully retrieve a value from a bucket within the hashtable that has a collision
        //I don't think I either did the above tests right or this one, because they are the same....
        [Fact]
        public void TestHashTableCollisionValue()
        {
            Hashtable testHashTable7 = new Hashtable();
            testHashTable7.AddToHashTable("cat", "dog");
            testHashTable7.AddToHashTable("rat", "newValue");
            string testAnswer4 = testHashTable7.GetFromHashTable("rat");
            Assert.Equal("newValue", testAnswer4);
        }

        //Successfully hash a key to an in-range value
        [Fact]
        public void TestHashIndexNumber1()
        {
            Hashtable testHashTable8 = new Hashtable();
            int htAnswer8 = testHashTable8.Hash("a");
            Assert.Equal(97, htAnswer8);
        }
        [Fact]
        public void TestHashIndexNumber2()
        {
            Hashtable testHashTable9 = new Hashtable();
            int htAnswer9 = testHashTable9.Hash("}}}}}}}}y");
            Assert.Equal(97, htAnswer9);
        }

        //testing contains
        [Fact]
        public void TestHashContainsPass()
        {
            Hashtable testHashTable10 = new Hashtable();
            testHashTable10.AddToHashTable("cat", "dog");
            bool htAnswer10 = testHashTable10.HashTableContains("cat");
            Assert.True(htAnswer10);
        }

        [Fact]
        public void TestHashContainsFail()
        {
            Hashtable testHashTable11 = new Hashtable();
            testHashTable11.AddToHashTable("cat", "dog");
            bool htAnswer11 = testHashTable11.HashTableContains("apple");
            Assert.False(htAnswer11);
        }
    }
}


