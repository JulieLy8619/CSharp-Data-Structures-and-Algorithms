using System;
using Xunit;
using _401d6LinkedList.Classes;
using ll_kth_from_end;

namespace ll_kth_end_unittesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
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
        public void Test2()
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
        public void Test3()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(20);
            list.Insert(25);
            list.Insert(50);
            int testK3 = Program.KthFromEnd(list, 0);
            Assert.Equal(4, testK3);
        }
    }
}
