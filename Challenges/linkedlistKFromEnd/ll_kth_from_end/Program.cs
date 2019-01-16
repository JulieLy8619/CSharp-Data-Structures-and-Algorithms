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
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            KthFromEnd(2); //should return 15
        }
        static int KthFromEnd(int keyNum)
        {

        }
    }
}
