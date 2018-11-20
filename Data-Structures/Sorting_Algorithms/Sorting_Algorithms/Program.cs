using System;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHALLENGE: Implement Insertion Sort");
            int[] sampleArray = { 3, 7, 4, 9, 5, 2, 6, 1 };
            InsertionSort(sampleArray);
            foreach(int num in sampleArray)
            {
                Console.WriteLine(num);
            }
        }

        static void InsertionSort(int[] myArray)
        {
            for (int i = 1; i < myArray.Length; i++)
            {
                int temp = myArray[i];
                int j = i - 1;

                while (j >=0 && temp < myArray[j])
                {
                    myArray[j + 1] = myArray[j];
                    j--;
                }
                myArray[j + 1] = temp;
            }
        }
    }
}
