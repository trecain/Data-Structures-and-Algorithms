using System;
using Xunit;
using arrayBinarySearch;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 2, 3, 4, 5, 5, 6, 6, 777, 8, 8, 9 }, 30)]
        public void ReturnNegativeOneWhenValueNotInArray(int[] arr, int keyValue)
        {
            Assert.Equal(-1, Program.BinarySearch(arr, keyValue));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 2, 3, 4, 5, 5, 30, 6, 777, 8, 8, 9 }, 30, 7)]
        [InlineData(new int[] { 1, 2, 2, 3, 4, 5, 5, 30, 6, 777, 8, 8, 9 }, 777, 9)]
        public void IndexOfKeyValueIsReturned(int[] sortedArr, int keyValue, int expectedIndex)
        {
            Assert.Equal(expectedIndex, Program.BinarySearch(sortedArr, keyValue));
        }

    }
}
