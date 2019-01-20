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
            LList newLL = null;

            //should return null
            newLL = Merge(list1, list2); //because it returns a LinkedList)

            list1.Insert(7);
            list1.Insert(5);
            list1.Insert(3);
            list1.Insert(1);

            list2.Insert(8);
            list2.Insert(6);
            list2.Insert(4);
            list2.Insert(2);

            Console.WriteLine("list1 ");
            list1.Print();
            Console.WriteLine();
            Console.WriteLine("list2 ");
            list2.Print();
            Console.WriteLine();

            newLL = Merge(list1, list2); //should return 1 2 3 4 5 6 7 8 null (happy case)
            Console.WriteLine("merge ll1 and ll2");
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
            Console.WriteLine("merge ll3 and ll4");
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
            Console.WriteLine("merge ll5 and ll6");
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
            LL1.Current = LL1.Head;
            LL2.Current = LL2.Head;
            if (LL1.Current == null && LL2.Current == null)
            {
                Console.WriteLine("Both lists were null");
                return null;
            }
            else if (LL1.Current == null && LL2.Current != null)
            {
                return LL2;
            }
            else if(LL1.Current != null && LL2.Current == null)
            {
                return LL1;
            }
            else 
            {
                //Console.WriteLine("else");
                Node tempNodePointer = LL1.Head;
                do
                {
                    tempNodePointer = LL2.Current.Next;
                    Console.WriteLine("tempNodePointer " + tempNodePointer.Value);
                    LL2.Current.Next = LL1.Current.Next;
                    Console.WriteLine("LL2.Current.Next " + LL2.Current.Next.Value);
                    LL1.Current.Next = LL2.Current;
                    Console.WriteLine("LL1.Current.Next " + LL1.Current.Next.Value);
                    LL1.Current = LL2.Current.Next;
                    Console.WriteLine("LL1.Current " + LL1.Current.Value);
                    LL2.Current = tempNodePointer;
                    Console.WriteLine("LL2.Current " + LL2.Current.Value);
                    Console.WriteLine("=====end of loop =======");
                } while (LL1.Current.Next != null && LL2.Current.Next != null);

                if (LL1.Current.Next != null && LL2.Current.Next == null)
                {
                    Console.WriteLine("in ll1 curr next not null and ll2 curr next null");
                    return LL1;
                }
                else if (LL1.Current.Next == null && LL2.Current.Next != null)
                {
                    Console.WriteLine("in ll1 curr next null and ll2 curr next not null");
                    LL1.Current.Next = LL2.Current;
                    return LL1;
                }
                return LL1;
            }
        }
    }
}
