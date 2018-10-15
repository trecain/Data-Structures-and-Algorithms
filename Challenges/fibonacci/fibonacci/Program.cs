using System;

namespace fibonacci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fibonacci Sequence.");
        }

        public static int FibonacciSequence(int num)
        {
            int result = 1, numOne = 0, numTwo = 1;
            if (num == 0)
            {
                return num;
            }
            else if (num <= 2)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    numOne = numTwo;
                    numTwo = result;
                    result = numOne + numTwo;
                }
            }
            return numOne;
        }
    }
}
