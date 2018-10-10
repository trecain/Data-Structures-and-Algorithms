using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 2, 4, 6, 8 };
            int[] testingArray = ArrayShift(testArray, 5);
            Console.WriteLine(testingArray);
            Console.WriteLine($"Result: {string.Join(", ", testingArray)}");
        }

        public static int[] ArrayShift(int[] arr, int value)
        {
            int[] shiftedArray = new int[arr.Length + 1];
            decimal shiftIndex = Math.Ceiling((decimal)(arr.Length / 2));
            Console.WriteLine(value);
      
            for (int i = 0; i < shiftedArray.Length; i++)
            {
                if (i < shiftIndex)
                {
                    shiftedArray[i] = arr[i];
                }
                else if (i == shiftIndex)
                {
                    shiftedArray[i] = value;
                }
                else
                {
                    shiftedArray[i] = arr[i - 1];
                }
            }
            return shiftedArray;
        }
    }
}
