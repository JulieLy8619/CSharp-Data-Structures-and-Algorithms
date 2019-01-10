using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] {1,2,3,4};
            Console.WriteLine("test 1 (should be 3): ");
            Console.WriteLine(BinarySearch(array1, 4)); //one that works, should return 3 (index location)

            int[] array2 = new int[] { 2,4,6,8};
            Console.WriteLine("test 2 (should be -1): ");
            Console.WriteLine(BinarySearch(array2, 5)); //one that returns -1
            Console.ReadLine(); //so it doesn't auto exit
        }

        public static int BinarySearch(int[] arr, int key)
        {
            int start = 0; //for now I assume my array will always start at 0
            int end = arr.Length - 1;
            do
            {
                int midVal = (start + end) / 2;
                if (arr[midVal] == key) // it found it
                {
                    return midVal;
                }
                else if (arr[midVal] > key) //key is in bottom half of search range
                {
                    end = midVal - 1;
                }
                else if (arr[midVal] < key) // key is in top half of search range
                {
                    start = midVal + 1;
                }
                //else
                //{
                //    return -1; // it isn't in the array
                //}
            } while (start <= end);
            return -1; 
        }
    }
}
