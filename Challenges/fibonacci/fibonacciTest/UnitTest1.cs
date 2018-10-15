using System;
using Xunit;
using fibonacci; 

namespace fibonacciTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        [InlineData(5, 5)]
        [InlineData(21, 8)]
        [InlineData(987, 16)]
        public void CanReturnFibonacciNumberIterative(int expected, int num)
        {
            Assert.Equal(expected, Program.FibonacciSequence(num));
        }
    }
}
