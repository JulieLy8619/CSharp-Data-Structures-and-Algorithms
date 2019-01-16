using System;
using _401d6LinkedList;
using _401d6LinkedList.Classes;

namespace ll_kth_from_end
{
    public class Program //so can test
    {
        static void Main(string[] args)
        {
            LList list = new LList();
            //test if null list
            int testK0 = KthFromEnd(list, 2); //should return null
            list.Print();
            Console.WriteLine();
            Console.WriteLine("test on null list: " + testK0);
             
            Console.WriteLine("inserted 4 8 15 20 25 50");
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(20);
            list.Insert(25);
            list.Insert(50);
            list.Print();
            Console.WriteLine();

            //Happy case: should return 15
            int testK1 = KthFromEnd(list, 2); 
            Console.WriteLine("test for 2 from end " + testK1);
            list.Print();
            Console.WriteLine();

            //test if k is bigger than length
            int testK2 = KthFromEnd(list, 10);
            Console.WriteLine("test k bigger than list " + testK2);
            list.Print();
            Console.WriteLine();

            //test if k is a neg num
            int testK3 = KthFromEnd(list, -5);
            Console.WriteLine("test k is neg " + testK3);
            list.Print();
            Console.WriteLine();

            //Happy case: should return 4
            int testK4 = KthFromEnd(list, 0);
            Console.WriteLine("test 0 " + testK4);
            list.Print();
            Console.WriteLine();

            //Happy case: should return 8
            int testK5 = KthFromEnd(list, 1);
            Console.WriteLine("test 1 " + testK5);
            list.Print();
            Console.WriteLine();

            //Happy case: should return 8
            int testK6 = KthFromEnd(list, 2);
            Console.WriteLine("test 2 " + testK6);
            list.Print();
            Console.WriteLine();


            //test if k is not a num, nvm don't need to make this test, won't compile if not int


            Console.ReadLine(); //to stop it from auto exiting

        }

        //Per TA Philip, he said someone messed with the documentaion and I can take in 2 params (list and K)
        static int KthFromEnd(LList list, int keyNum)
        {
            if (keyNum < 0)
            {
                Console.WriteLine("I don't do negative numbers");
                return 0; //won't let me return null
            }
            else
            {
                int counterLength = 0;
                int counterForK = 0;

                list.Current = list.Head;
                if (list.Head == null)
                {
                    Console.WriteLine("The linked list is Null");
                    Console.WriteLine("return from null IF");
                    return 0; //won't let me return null
                }
                else
                {
                    //gets length of link list
                    while (list.Current.Next != null)
                    {
                        counterLength++;
                        list.Current = list.Current.Next;
                    }
                    counterLength++; //one more for last node in list

                    counterForK = counterLength - keyNum;

                    if (counterForK < 0)
                    {
                        Console.WriteLine($"The Linked List isn't longer than {keyNum}");
                        Console.WriteLine("return from key num too big IF");
                        return 0; //won't let me return null
                    }
                    else
                    {
                        //reset to head and rewalk to k from end length
                        list.Current = list.Head;
                        //Console.WriteLine("head value" + list.Head.Value);
                        //Console.WriteLine("counter for K " + counterForK);
                        for (int i = 0; i < (counterForK-1); i++)
                        {
                            //Console.WriteLine("list current value in FOR loop " + list.Current.Value);
                            list.Current = list.Current.Next;
                        }
                        //Console.WriteLine("return from FOR list");
                        return list.Current.Value;
                    }
                }
            }
        }
    }
}
