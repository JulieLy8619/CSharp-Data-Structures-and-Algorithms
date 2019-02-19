using System;
using Xunit;
using repeatedWord.Classes;
using HashTable.Classes;
using repeatedWord;

namespace repeateword_unittesting
{
    public class UnitTest1
    {
        //happy case
        [Fact]
        public void TestRepeatwordHappyCase()
        {
            string testInput1 = "this will return this";
            string testAnswer1 = Program.RepeatedWord(testInput1);
            Assert.Equal("this", testAnswer1);
        }

        //no repeated words
        [Fact]
        public void TestRepeatwordHappyFailCase()
        {
            string testInput2 = "this will return null";
            string testAnswer2 = Program.RepeatedWord(testInput2);
            Assert.Null(testAnswer2);
        }

        //empty string
        [Fact]
        public void TestRepeatwordEmptyString()
        {
            string testInput3 = "";
            string testAnswer3 = Program.RepeatedWord(testInput3);
            Assert.Null(testAnswer3);
        }

        //string with weird characters
        [Fact]
        public void TestRepeatwordWeirdString()
        {
            string testInput4 = ". rose & & %% bob kathy Kathy bob";
            string testAnswer4 = Program.RepeatedWord(testInput4);
            Assert.Equal("bob", testAnswer4);
        }

        //hashtable class================
        //only changed the hash from hashtable class we did before, so this is what I am re-testing for that the hash works as expected
        [Fact]
        public void TestHashIndexNumber1()
        {
            HashTable2 testHashTable1 = new HashTable2();
            int htAnswer1 = testHashTable1.Hash("a");
            Assert.Equal(97, htAnswer1);
        }
        [Fact]
        public void TestHashIndexNumber2()
        {
            HashTable2 testHashTable2 = new HashTable2();
            int htAnswer2 = testHashTable2.Hash("}}}}}}}}y");
            Assert.Equal(97, htAnswer2);
        }

        //i will also re-test the others for a good defense, because I changed the hash and they depended on the hash
        //Adding a key/value to your hashtable results in the value being in the data structure
        [Fact]
        public void TestHashTableAdd1()
        {
            Hashtable testHashTable1 = new Hashtable();
            testHashTable1.AddToHashTable("cat", "dog");
            Assert.Equal("cat", testHashTable1.HashTableArray[3].Head.Key);
        }
        [Fact]
        public void TestHashTableAdd2()
        {
            Hashtable testHashTable2 = new Hashtable();
            testHashTable2.AddToHashTable("cat", "dog");
            Assert.Equal("dog", testHashTable2.HashTableArray[3].Head.Value);
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

    }
}
