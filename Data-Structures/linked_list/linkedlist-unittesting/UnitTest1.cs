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

        //tests append
        [Fact]
        public void TestAppendWorks1()
        {
            //if I append and check it is in it then it made it in
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Append(2);
            Assert.True(list.Includes(2));
        }
        [Fact]
        public void TestAppendWorks2()
        {
            //if I append and check it is in it then it made it in
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Append(2);
            list.Append(100);
            Assert.True(list.Includes(4));
        }
        [Fact]
        public void TestAppendNotWorks()
        {
            //if I append and check it is in it then it made it in
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Append(2);
            Assert.False(list.Includes(10));
        }


        //test insertbefore
        [Fact]
        public void TestInsertBeforeWorks()
        {
            //if I insertbefore and check it is in it then it made it in
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.InsertBefore(8,2);
            Assert.True(list.Includes(2));
        }
        [Fact]
        public void TestInsertBeforeWorks2()
        {
            //if I insertbefore and check it is in it then it made it in
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.InsertBefore(8, 2);
            list.InsertBefore(15, 9);
            Assert.True(list.Includes(9));
        }
        [Fact]
        public void TestInsertBeforeNotWorks()
        {
            //if I insertbefore and check it is in it then it made it in
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.InsertBefore(8, 2);
            Assert.False(list.Includes(9));
        }

        //test insertafter
        [Fact]
        public void TestInsertAfterWorks()
        {
            //if I insertbefore and check it is in it then it made it in
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.InsertAfter(8, 2);
            Assert.True(list.Includes(2));
        }
        [Fact]
        public void TestInsertAfterWorks2()
        {
            //if I insertbefore and check it is in it then it made it in
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.InsertAfter(8, 2);
            list.InsertAfter(15, 9);
            Assert.True(list.Includes(9));
        }
        [Fact]
        public void TestInsertAfterNotWorks()
        {
            //if I insertbefore and check it is in it then it made it in
//TA HELP HERE TOO: I don't think this is the correct way to check it
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.InsertAfter(8, 2);
            Assert.False(list.Includes(9));
        }
    }
}
