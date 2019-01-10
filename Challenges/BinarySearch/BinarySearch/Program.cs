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

        public static int BinarySearch(int[] array, int key)
        {
            return 1;
        }
    }
}
