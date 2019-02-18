using System;

namespace insertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            //make an array of unsort int
            int[] mainArray = new int[] {9, 8, 2, 1, 4};
            Console.WriteLine("Array getting sent into insertion sort: ");
            //for loop through array to print to screen
            for (int i = 0; i < mainArray.Length; i++)
            {
                Console.Write(mainArray[i] + " ");
            }
            Console.WriteLine(); //just for spacing

            //send it to the method
            int[] answerArray = new int[mainArray.Length];
            //it will return a sorted array
            answerArray = InsertionSort(mainArray);
            Console.WriteLine("Array results after insertion sort: ");
            //for loop through array to print to screen
            for (int i = 0; i < answerArray.Length; i++)
            {
                Console.Write(answerArray[i] + " ");
            }
            Console.WriteLine(); //just for spacing
            Console.ReadLine(); // to stop it from auto exit
        }

        /// <summary>
        /// sorts an array using insertion sort
        /// </summary>
        /// <param name="arr">an array</param>
        /// <returns>a sorted array</returns>
        public static int[] InsertionSort(int[] arr)
        {
            //int[] returnArr = new int[arr.Length];
            for (int i = 1; i < arr.Length; i++)
            {
                int counter = i - 1;
                int currentVal = arr[i];

                while (counter >= 0 && currentVal < arr[counter])
                {
                    arr[counter + 1] = arr[counter];
                    counter = counter - 1;
                }
                arr[counter + 1] = currentVal;
            }
            return arr;
        }
    }
}
