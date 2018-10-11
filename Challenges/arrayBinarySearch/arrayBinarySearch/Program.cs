using System;

namespace arrayBinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search.");  
        }

        public static int BinarySearch(int[] sortedArray, int searchKey)
        {
            //setting up variable for conditional statement.
            int min = 0;
            int max = sortedArray.Length - 1;
            
            //loops through the array until searchKey is found or end of array is hit.
            while (min <= max)
            {
                //set the index of the middle of the array
                int middle = (min + max) / 2;
                //If int at sorted index is greater than the searchkey move over to the left side of the array and search.
                if (sortedArray[middle] < searchKey )
                {
                    min = middle + 1;
                }
                //If int at sorted index is greater than the searchkey move over to the right side of the array and search.
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

