using System;
using Xunit;
using repeatedWord.Classes;
using HashTable.Classes;

namespace repeateword_unittesting
{
    public class UnitTest1
    {
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
    }
}
