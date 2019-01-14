using System;
using Xunit;
using _401d6LinkedList.Classes;


namespace linkedlist_unittesting
{
    public class UnitTest1
    {
        //test include
        [Fact]
        public void TestInclude()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);

            Assert.True(list.Includes(8));
        }
        [Fact]
        public void TestNotInclude()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);

            Assert.False(list.Includes(29));
        }
        [Fact]
        public void TestInclude2()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            bool temp = list.Includes(15);
            Assert.True(temp);
        }

        //test insert
        [Fact]
        public void TestInsert()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);

            Assert.True(list.Includes(4)); //because if it can find it, it was inserted
        }
        [Fact]
        public void TestInsert2()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);

            Assert.True(list.Includes(8)); //because if it can find it, it was inserted
        }
        [Fact]
        public void TestNotInsert() //i don't think this is how I should have tested it wasn't insterted...because I didn't try to insert it
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);

            Assert.False(list.Includes(29));
        }

        //print method didn't return anthing so can't test it

    }
}
