using System;
using Xunit;
using MergeSort;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// can perform a merge sort test
        /// </summary>
        /// <param name="start"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(new int[] { 7, 9, 1, 3, 19 }, new int[] { 1, 3, 7, 9, 19})]
        [InlineData(new int[] { 19, 18, 17, 3, 4, 5 }, new int[] { 3, 4, 5, 17, 18, 19 })]
        public void CanMergeSort(int[] start, int[] expected)
        {
            Assert.Equal(Program.MergeSort(start), expected);
        }


        /// <summary>
        /// can merge two arrays
        /// </summary>
        [Fact]
        public void CanMerge()
        {
            int[] myArray = new int[6] { 0, 0, 0, 0, 0, 0 };
            Assert.Equal(new int[] { 2, 1, 3, 4, 5, 6 }, Program.Merge(new int[] { 2, 1, 3 }, new int[] { 4, 5, 6}, myArray));
        }
    }
}
