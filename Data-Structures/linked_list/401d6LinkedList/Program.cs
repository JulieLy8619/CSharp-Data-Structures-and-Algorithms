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
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);

            Console.WriteLine($"Does 8 Exist?: {list.Includes(8)}");
            Console.WriteLine($"Does 18 Exist?: {list.Includes(18)}");

            list.Print();

            list.InsertBefore(99, 8);
            Console.WriteLine();
            list.Print();
            list.InsertBefore(8, 7);
            Console.WriteLine();
            list.Print();
            Console.ReadLine(); // to stop it from auto closing

        }
    }
}
