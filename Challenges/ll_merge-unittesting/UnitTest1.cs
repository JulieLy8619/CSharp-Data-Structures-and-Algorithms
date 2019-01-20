using System;
using Xunit;
using _401d6LinkedList;
using _401d6LinkedList.Classes;
using ll_Merge;

namespace ll_merge_unittesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestTwoNullLL()
        {
            LList listTest1 = new LList();
            LList listTest2 = new LList();
            LList newTestLL = ll_Merge.Program.Merge(listTest1, listTest2); //should return a null list 
            Assert.Null(newTestLL);
        }

        [Fact]
        public void TestLL1ShorterThanLL2()
        {

        }

        [Fact]
        public void TestLL2ShorterThanLL1()
        {

        }
    }
}
