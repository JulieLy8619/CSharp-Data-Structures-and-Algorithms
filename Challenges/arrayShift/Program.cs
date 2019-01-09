using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrArg = new int[] {2, 4, 6, 8};
            Console.ReadLine(); //so it doesn;t auto exit when it is done
        }

        private static Array[] ArrayShift(int[] arr, int num)
        {
            int midArr = (arr.Length)/2; //if length is odd will it round up or down (if down, then need func to round up)
            int newArrLength = arr.Length + 1;
            int[] newArr = new int[newArrLength];

            //loop through param arr and populate new array and insert new num
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
                    newArr[i] = arr[i-1];
                }
            }
            return newArr[];
        }
    }
}
