using _401d6LinkedList.Classes;
using System;

namespace _401d6LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NodeExample();
        }

        static void NodeExample()
        {
            //Node node = new Node(8);
            //Console.WriteLine(node.Value);
            LList list = new LList();

            //tests linklist is empty
            Console.WriteLine("Empty list");
            list.InsertBefore(5,10);
            list.InsertAfter(5,10);
            list.Append(100);

            Console.WriteLine("added 4 8 15 list");
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);

            //Console.WriteLine($"Does 8 Exist?: {list.Includes(8)}");
            //Console.WriteLine($"Does 18 Exist?: {list.Includes(18)}");

            list.Print();
            Console.WriteLine();

            Console.WriteLine("insert before at begining");
            list.InsertBefore(15, 16);
            list.Print();
            Console.WriteLine();
            Console.WriteLine("insert before at middle");
            list.InsertBefore(8, 9);
            list.Print();
            Console.WriteLine();
            Console.WriteLine("insert before at end");
            list.InsertBefore(4, 5);
            list.Print();
            Console.WriteLine();
            Console.WriteLine("insert before not in list");
            list.InsertBefore(99, 100);
            list.Print();
            Console.WriteLine();
            Console.WriteLine("============");
            Console.WriteLine("insert after at begining");
            list.InsertAfter(16, 80);
            list.Print();
            Console.WriteLine();
            Console.WriteLine("insert after at middle");
            list.InsertAfter(8, 70);
            list.Print();
            Console.WriteLine();
            Console.WriteLine("insert after at end");
            list.InsertAfter(4, 60);
            list.Print();
            Console.WriteLine();
            Console.WriteLine("insert after not in list");
            list.InsertAfter(88, 100);
            list.Print();
            Console.WriteLine();

            list.Print();
            Console.WriteLine();

            Console.WriteLine("test append");
            list.Append(500);
            list.Print();
            Console.WriteLine($"Does 500 Exist?: {list.Includes(500)}");
            Console.ReadLine(); // to stop it from auto closing

        }
    }
}
