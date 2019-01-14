using System;

namespace ECFib
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please choose which N-th number of the Fibonacci Sequecnce you would like the number for?");
            string UserChoice = Console.ReadLine();
            try
            {
                int userChoiceInt = Convert.ToInt32(UserChoice);

                int answer = FibNum(userChoiceInt);

                Console.WriteLine($"The {userChoiceInt} position of the Fibonacci sequence is {answer}");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
            Console.ReadLine(); //just to stop it from auto closing
        }

        /// <summary>
        /// Will determine the fib number at the Nth location. I assumed the fib sequence started at 0 than 1
        /// </summary>
        /// <param name="num">the Nth number</param>
        /// <returns>the Nth number of the fib sequence</returns>
        public static int FibNum(int num)
        {
            /*
            new Array
            for i arr length
            if i is 0 then 0
            if i is 1 then 1
            arr i = Array (i -2) + Array (i -1)
            return Array at num
            */
            int[] arr = new int[num + 1]; //added one just for buffer
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    arr[i] = 0;
                }
                else if (i == 1)
                {
                    arr[i] = 1;
                }
                else
                {
                    arr[i] = arr[i - 2] + arr[i - 1];
                }
            }
            return arr[num-1];
        }
    }
}
