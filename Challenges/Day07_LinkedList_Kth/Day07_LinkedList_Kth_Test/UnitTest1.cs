using System;
using Xunit;
using Day07_LinkedList_Kth;
using Day06_LinkedList.Classes;


namespace Day07_LinkedList_Kth_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(2, 3)]
        [InlineData(3, 8)]
      
        public void CanGetKthElement(int k, int expectedOutput)
        {
            LList list = new LList(new Node(1));
            list.Add(new Node(3));
            list.Add(new Node(8));
            list.Add(new Node(2));
            Assert.Equal(expectedOutput, Program.ReturnKthToLastNode(list, k).Value);
        }
    }
}
