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
            PseudoQueue progPseudoStack = new PseudoQueue(1);
            progPseudoStack.PseudoQueueEnqueue(2);
            progPseudoStack.PseudoQueueEnqueue(3);
            progPseudoStack.PseudoQueueDequeue();
            progPseudoStack.PseudoQueueDequeue();
            progPseudoStack.PseudoQueueEnqueue(4);
            progPseudoStack.PseudoQueueDequeue();

            Console.WriteLine("the psuedo queue: ");
            progPseudoStack.PseudoQueuePrint();


            //enqueue

            //dequeue

            //do some console writelines so I can what the stacks and queues are doing
        }
    }
}
