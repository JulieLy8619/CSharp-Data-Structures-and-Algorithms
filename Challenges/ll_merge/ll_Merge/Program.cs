using System;
using _401d6LinkedList;
using _401d6LinkedList.Classes;


namespace ll_Merge
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList list1 = new LList();
            LList list2 = new LList();
            //should return a null list
            LList newLL = Merge(list1, list2); //because it returns a LinkedList)

            list1.Insert(7);
            list1.Insert(5);
            list1.Insert(3);
            list1.Insert(1);

            list1.Insert(8);
            list1.Insert(6);
            list1.Insert(4);
            list1.Insert(2);

            newLL = Merge(list1, list2); //should return 1 2 3 4 5 6 7 8 null (happy case)
            newLL.Print();
            Console.WriteLine("==========");
            LList list3 = new LList();
            LList list4 = new LList();

            list3.Insert(100);
            list3.Insert(90);


            list4.Insert(95);
            list4.Insert(85);
            list4.Insert(75);
            list4.Insert(65);

            LList newLL2 = Merge(list3, list4); //when list 1 is short than list 2
            //should be 100 95 90 85 75 65
            newLL2.Print();
            Console.WriteLine("==========");
            LList list5 = new LList();
            LList list6 = new LList();

            list5.Insert(100);
            list5.Insert(90);
            list5.Insert(80);
            list5.Insert(70);

            list6.Insert(95);
            list6.Insert(85);

            LList newLL3 = Merge(list5, list6); //when list 2 is short than list 1
            //should be 100 95 90 85 80 70
            newLL3.Print();
            Console.WriteLine();

            Console.ReadLine(); //stops rog from auto exiting

        }
        /// <summary>
        /// Given two linked lists, this method will ziper the two lists twogether
        /// </summary>
        /// <param name="LL1">linked list 1</param>
        /// <param name="LL2">link list 2</param>
        /// <returns>a linked list </returns>
        public static LList Merge(LList LL1, LList LL2)
        {
            Node tempNodePointer = LL1.Head;
            LL1.Current = LL1.Head;

            return null;
        }
    }
}
