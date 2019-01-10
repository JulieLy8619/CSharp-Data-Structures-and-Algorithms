using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] {1,2,3,4};
            BinarySearch(array1, 4); //one that works

            int[] array2 = new int[] { 2,4,6,8};
            BinarySearch(array2, 5); //one that returns -1
        }

        public static int BinarySearch(int[] arr, int key)
        {
            int start = 0; //for now I assume my array will always start at 0
            int end = arr.Length - 1;
            int midVal = (start + end) / 2;
            do
            {
                if (arr[midVal] == key)
                {
                    return key;
                }
                else if (arr[midVal] > key) //key is in bottom half of search range
                {
                    end = midVal - 1;
                }
                else if (arr[midVal] < key) // key is in top half of search range
                {
                    start = midVal + 1;
                }
                else
                {
                    return -1;
                }
            } while ((end - start) > 0);
        }
    }
}
