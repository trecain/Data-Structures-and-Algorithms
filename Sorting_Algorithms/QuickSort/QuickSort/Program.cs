using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coding Challenge: Quick Sort");
            int[] myArray = { 10, 80, 30, 90, 40, 50, 70 };
            QuickSort(myArray, 0, myArray.Length - 1);
        }
        
        public static int[] QuickSorts(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
            return arr; 
        }


        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Partitions the Algorithm
                int position = Partition(arr, left, right);
                // sort the left side
                QuickSort(arr, left, position - 1);
                // sort the right side
                QuickSort(arr, position + 1, right);
            }
        }


        public static int Partition(int[] arr, int left, int right)
        {
            // sets the pivot
            int pivot = arr[right];
            // gets the lower value index
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);
            Console.WriteLine(string.Join(",", arr));
            return low + 1;
        }


        public static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
