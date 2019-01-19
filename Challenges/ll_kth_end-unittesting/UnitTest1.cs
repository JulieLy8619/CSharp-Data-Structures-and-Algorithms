using System;
using Xunit;
using _401d6LinkedList.Classes;
using ll_kth_from_end;

namespace ll_kth_end_unittesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestKthsFromEndHappyCase()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(20);
            list.Insert(25);
            list.Insert(50);
            int testK1 = Program.KthFromEnd(list, 3);
            Assert.Equal(20, testK1);
        }

        [Fact]
        public void TestNotReturnOtherNumberThatIsKthFromEnd()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(20);
            list.Insert(25);
            list.Insert(50);
            int testK2 = Program.KthFromEnd(list, 3);
            Assert.NotEqual(15, testK2);
        }
        [Fact]
        public void TestNullLinkListKthFromEnd()
        {
            LList list = new LList();
            int testK3 = Program.KthFromEnd(list, 3);
            Assert.Equal(0, testK3); //because it should have returns 0 if it was a Null list
        }

        [Fact]
        public void TestOutOfScopeKthFromEnd()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            int testK4 = Program.KthFromEnd(list, 10);
            Assert.Equal(0, testK4); //because it should have returns 0 if K was longer than LinkedList
        }

        [Fact]
        public void TestNegNumKthFromEnd()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            int testK4 = Program.KthFromEnd(list, -5);
            Assert.Equal(0, testK4); //because it should have returns 0 if K was neg number
        }
    }
}
