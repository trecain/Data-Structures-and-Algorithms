using System;
using Xunit;
using Day06_LinkedList.Classes;
using ReversedLL;

namespace ReversedLLTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanReverseLLThreeNumbers()
        {
            LList linkedList = new LList(new Node(3));
            linkedList.Add(new Node(9));
            linkedList.Add(new Node(4));

            Assert.Equal("3 --> 9 --> 4 --> NULL\n", Program.ReverseLL(linkedList).Print());
        }


        [Fact]
        public void CanReverseLLSixNumbers()
        {
            LList linkedList = new LList(new Node(3));
            linkedList.Add(new Node(9));
            linkedList.Add(new Node(4));
            linkedList.Add(new Node(9));
            linkedList.Add(new Node(4));
            linkedList.Add(new Node(4));

            Assert.Equal("3 --> 9 --> 4 --> 9 --> 4 --> 4 --> NULL\n", Program.ReverseLL(linkedList).Print());
        }

        [Fact]
        public void CanReverseLLTenNumbers()
        {
            LList linkedList = new LList(new Node(3));
            linkedList.Add(new Node(9));
            linkedList.Add(new Node(4));
            linkedList.Add(new Node(9));
            linkedList.Add(new Node(4));
            linkedList.Add(new Node(4));
            linkedList.Add(new Node(4));
            linkedList.Add(new Node(9));
            linkedList.Add(new Node(4));
            linkedList.Add(new Node(4));

            Assert.Equal("9 --> 4 --> 4 --> 4 --> 9 --> 4 --> 4 --> NULL\n", Program.ReverseLL(linkedList).Print());
        }
    }
}
