using System;
using System.Collections.Generic;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coding Challenge: Merge Sort");

            Console.WriteLine($"List to merge sort: [10, 4, 3, 11, 9, 13] = [{String.Join(", ", MergeSort(new int[] { 11, 9, 8, 14, 1, 2 }))}]");
        }


        /// <summary>
        /// Mergesort that adds the sorted values into the return list
        /// </summary>
        /// <param name="myArray">The array to be sorted</param>
        /// <param name="returnList"></param>
        public static int[] MergeSort(int[] myArray)
        {
            if (myArray.Length > 1)
            {
                // shows each half of the array sizes
                int leftSize = myArray.Length / 2;
                int rightSize = myArray.Length - leftSize;

                // puts first half in left array 
                int[] left = new int[leftSize];
                Array.Copy(myArray, 0, left, 0, leftSize);

                // puts second half in right array
                int[] right = new int[rightSize];
                Array.Copy(myArray, myArray.Length / 2, right, 0, rightSize);

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, myArray);
            }
            return myArray;
        }


        /// <summary>
        /// combines two sorted arrays 
        /// </summary>
        /// <param name="left">left half of the array</param>
        /// <param name="right">right half of the array</param>
        /// <param name="arr">main array</param>
        /// <returns></returns>
        public static int[] Merge(int[] left, int[] right, int[] arr)
        {
            // left pointer 
            int i = 0;
            // right pointer
            int j = 0;
            // end array pointer 
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                //checks if the value of left array is less than the value of the right array
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    // increment
                    i++;
                }
                else
                {
                    // add values of the right array into the main array
                    arr[k] = right[j];
                    // increment 
                    j++;
                }
                // increment the pointer of main array
                k++;
            }

            if (i == left.Length)
            {
                // copy right array into main array 
                Array.Copy(right, j, arr, k, right.Length - j);
            }
            else
            {
                Array.Copy(left, i, arr, k, left.Length - i);
            }
            return arr;
        }
    }
}
