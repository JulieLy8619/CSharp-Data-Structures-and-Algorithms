using QueueWithStacks.Classes;
using System;

namespace QueueWithStacks
{
    class Program
    {
        public static void Main(string[] args)
        {
            QueueWithStacks();
            Console.ReadLine(); //to stop it from auto closing prog
        }

        /// <summary>
        /// 
        /// </summary>
        public static void QueueWithStacks()
        {
            //make a queue with stacks object
            PseudoQueue progPseudoStack = new PseudoQueue();
            progPseudoStack.PseudoQueueEnqueue(5);

            Console.WriteLine("the psuedo queue: ");
            progPseudoStack.PseudoQueuePrint();


            //enqueue

            //dequeue

            //do some console writelines so I can what the stacks and queues are doing
        }
    }
}
