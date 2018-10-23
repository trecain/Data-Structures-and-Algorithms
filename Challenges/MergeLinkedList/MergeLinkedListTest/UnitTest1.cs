using System;
using Xunit;
using Day06_LinkedList.Classes;
using MergeLinkedList;

namespace MergeLinkedListTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(9, 2, 3, 1, 6, 5, "9 --> 2 --> 3 --> 1 --> 6 --> 5 --> NULL\n")]
        [InlineData(2, 4, 6, 11, 9, 5, "2 --> 4 --> 6 --> 11 --> 9 --> 5 --> NULL\n")]
        [InlineData(22, 44, 66, 111, 99, 55, "22 --> 44 --> 66 --> 111 --> 99 --> 55 --> NULL\n")]
        [InlineData(2, 4, 60, 116, 98, 105, "2 --> 4 --> 60 --> 116 --> 98 --> 105 --> NULL\n")]
        [InlineData(0, 0, 0, 0, 0, 0, "0 --> 0 --> 0 --> 0 --> 0 --> 0 --> NULL\n")]
        [InlineData(2, 2, 2, 2, 2, 2, "2 --> 2 --> 2 --> 2 --> 2 --> 2 --> NULL\n")]

        public void CanZipTwoList(int a, int b, int c, int d, int e, int f, string expectedString)
        {
            /// <summary>
            /// Creates the first linked list to be merged.
            /// </summary>
            LList firstList = new LList(new Node(e));
            firstList.Add(new Node(c));
            firstList.Add(new Node(a));

            /// <summary>
            /// Creates the second linked list to be merged.
            /// </summary>
            LList secondList = new LList(new Node(f));
            secondList.Add(new Node(d));
            secondList.Add(new Node(b));

            LList zipperMerged = new LList(Program.MergeLinkedList(firstList, secondList));
            Assert.Equal(expectedString, zipperMerged.Print());
        }

    }
}
