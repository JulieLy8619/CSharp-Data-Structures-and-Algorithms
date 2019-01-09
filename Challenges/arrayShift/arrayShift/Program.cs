using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrArg1 = new int[] {2, 4, 6, 8}; //even and sorted
            ArrayShift(arrArg1, 5);
            Console.WriteLine(""); //just to space out the output

            int[] arrArg2 = new int[] {8, 9, 1, 3, 6}; // odd and not sorted
            ArrayShift(arrArg2, 100);
            Console.WriteLine(""); //just to space out the output

            int[] arrArg3 = new int[] {}; //empty array
            ArrayShift(arrArg3, 10);
            Console.WriteLine(""); //just to space out the output

            Console.ReadLine(); //so it doesn;t auto exit when it is done
        }

        private static int[] ArrayShift(int[] arr, int num)
        {
            int midArr = 0;
            if (arr.Length % 2 == 0)
            {
                midArr = arr.Length / 2;
            }
            else
            {
                midArr = (arr.Length / 2) + 1; //for when it is odd and instruction said we round up 
            }

            //int midArr = (arr.Length) / 2;
            int newArrLength = arr.Length + 1;
            int[] newArr = new int[newArrLength];

            //loop through param arr and populate new array and insert new num
            Console.WriteLine("Your new Array is ");
            for (int i = 0; i < newArrLength; i++)
            {
                if (i == midArr)
                {
                    newArr[i] = num;
                }
                else if (i < midArr)
                {
                    newArr[i] = arr[i];
                }
                else if (i > midArr)
                {
                    newArr[i] = arr[i - 1];
                }

                Console.Write(newArr[i] + " ");
            }
            return newArr;
        }
    }
}
