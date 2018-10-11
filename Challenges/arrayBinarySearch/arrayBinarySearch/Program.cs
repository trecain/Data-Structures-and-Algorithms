using System;

namespace arrayBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 4, 8, 15, 16, 23, 42 };
            int[] testArrayTwo = { 11, 22, 33, 44, 55, 66, 77 };
            Console.WriteLine(BinarySearch(testArray, 15));
            Console.WriteLine(BinarySearch(testArrayTwo, 15));
        }

        public static int BinarySearch(int[] sortedArray, int searchKey)
        {
            int min = 0;
            int max = sortedArray.Length;
            
            while (min <= max)
            {
                int middle = (min + max) / 2;
                if (sortedArray[middle] < searchKey )
                {
                    min = middle + 1;
                }
                else if (sortedArray[middle] > searchKey)
                {
                    max = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }
    }
}

