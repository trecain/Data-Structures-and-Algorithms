using System;
using Xunit;
using Day06_LinkedList.Classes;
using StackAndQueue.Classes;
using StackAndQueue;

namespace StackAndQueueTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test that we can view the stack
        /// </summary>
        /// <param name="value"></param>
        /// <param name="expectedValue"></param>
        [Theory]
        [InlineData(4, 4)]
        [InlineData(9, 9)]
        [InlineData(0, 0)]

        public void CanViewTheNodeOffTheStack(int value, int expectedValue)
        {
            Stack testStack = new Stack(new Node(value));
            Assert.Equal(expectedValue, testStack.View().Value);
        }


        /// <summary>
        /// Test that we can pop a node off the stack
        /// </summary>
        /// <param name="value"></param>
        /// <param name="expectedValue"></param>
        [Theory]
        [InlineData(7, 7)]
        [InlineData(5, 5)]
        [InlineData(3, 3)]
        public void CanPopOffStack(int value, int expectedValue)
        {
            Stack testStack = new Stack(new Node(value));
            Assert.Equal(expectedValue, testStack.Pop().Value);
        }


        [Theory]
        [InlineData(7, 7)]
        [InlineData(5, 5)]
        [InlineData(3, 3)]
        public void CanViewNodeAtTopOfStack(int value, int expectedValue)
        {
            Queue testQueue = new Queue(new Node(value));
            Assert.Equal(expectedValue, testQueue.View().Value);
        }

        [Theory]
        [InlineData(7, 7)]
        [InlineData(5, 5)]
        [InlineData(3, 3)]
        public void CanRemoveNodeFromQueue(int value, int expectedValue)
        {
            Queue testQueue = new Queue(new Node(value));
            Assert.Equal(expectedValue, testQueue.Dequeue().Value);
        }

        [Fact]
        public void CanCreateANewStack()
        {
            Assert.Equal(3, Program.CreateNewStack().View().Value);
        }

        [Fact]
        public void CanCreateANewQueue()
        {
            Assert.Equal(9, Program.CreateNewQueue().View().Value);
        }
    }
}
