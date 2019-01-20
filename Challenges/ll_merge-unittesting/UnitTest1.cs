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
            LList list3 = new LList();
            LList list4 = new LList();

            list3.Insert(100);
            list3.Insert(90);

            list4.Insert(95);
            list4.Insert(85);
            list4.Insert(75);
            list4.Insert(65);

            LList newLL2 = ll_Merge.Program.Merge(list3, list4);
            int counter = 0;
            newLL2.Current = newLL2.Head;
            do
            {
                counter++;
                newLL2.Current = newLL2.Current.Next;
            } while (newLL2.Current.Next != null);
            counter++; //one more to count last in link
            Assert.Equal(6, counter);
        }

        [Fact]
        public void TestLL2ShorterThanLL1()
        {
            LList list5 = new LList();
            LList list6 = new LList();

            list5.Insert(100);
            list5.Insert(90);
            list5.Insert(80);
            list5.Insert(70);
            list5.Insert(60);

            list6.Insert(95);
            list6.Insert(85);

            LList newLL3 = ll_Merge.Program.Merge(list5, list6);
            int counter = 0;
            newLL3.Current = newLL3.Head;
            do
            {
                counter++;
                newLL3.Current = newLL3.Current.Next;
            } while (newLL3.Current.Next != null);
            counter++; //one more to count last in link
            Assert.Equal(7, counter);
        }
    }
}
