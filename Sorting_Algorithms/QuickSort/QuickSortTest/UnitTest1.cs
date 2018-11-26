using System;
using Xunit;
using QuickSort;

namespace QuickSortTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Checks that an array is sorted properly
        /// </summary>
        /// <param name="start">Starting array</param>
        /// <param name="end">Outputted array</param>
        [Theory]
        [InlineData(new int[] { 6, 3, 5, 4, 11 }, new int[] { 3, 4, 5, 6, 11 })]
        [InlineData(new int[] { 63, 34, 25, 64, 11 }, new int[] { 11, 25, 34, 63, 64 })]
        public void CanQuickSort(int[] start, int[] end)
        {
            Assert.Equal(Program.QuickSorts(start), end);
        }


        /// <summary>
        /// Can partition test
        /// </summary>
        [Fact]
        public void CanPartitionTest()
        {
            Assert.Equal(0, Program.Partition(new int[] { 5, 4, 3, 2, 1 }, 0, 4));
        }


        /// <summary>
        /// Can run swap test method
        /// </summary>
        [Fact]
        public void CanSwapTest()
        {
            int[] arr = new int[] { 9, 11, 3, 4, 2 };
            Program.Swap(arr, 0, 4);
            Assert.Equal(2, arr[0]);
        }
    }
}
