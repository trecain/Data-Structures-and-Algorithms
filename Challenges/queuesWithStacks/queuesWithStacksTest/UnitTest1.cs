using System;
using Xunit;
using Day06_LinkedList.Classes;
using StackAndQueue.Classes;
using queuesWithStacks.Classes;

namespace queuesWithStacksTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Enqueue node
        /// </summary>
        [Fact]
        public void CanEnqueueNode()
        {
            Node node = new Node(9);
            Node enqueuedNode = new Node(8);
            queuesWithStacks.Classes.Queue queue = new queuesWithStacks.Classes.Queue(node);
            queue.Enqueue(enqueuedNode);
            Assert.Equal(queue.Peek(), node);
        }
            

        /// <summary>
        /// Can queue
        /// </summary>
        [Fact]
        public void CanQueue()
        {
            Node node = new Node(1);
            queuesWithStacks.Classes.Queue queue = new queuesWithStacks.Classes.Queue(node);
            Assert.Equal(queue.Peek(), node);
        }


        /// <summary>
        /// Enqueued node order stays the same after being dequeued
        /// </summary>
        /// <param name="nodes">The nodes.</param>
        /// <param name="expected">The expected.</param>
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 4, 5, 6, 7, 8 }, new int[] { 4, 5, 6, 7, 8 })]
        [InlineData(new int[] { 4, 5 }, new int[] { 4, 5 })]

        public void NodeOrderRemainsAfterBeingDequeued(int[] nodes, int[] expected)
        {
            queuesWithStacks.Classes.Queue queue = new queuesWithStacks.Classes.Queue(new Node(nodes[0]));
            int[] arr = new int[nodes.Length];

            for (int i = 1; i < nodes.Length; i++)
            {
                queue.Enqueue(new Node(nodes[i]));
            }

            for (int i = 0; i < nodes.Length; i++)
            {
                arr[i] = (int)queue.Dequeue().Value;
            }

            Assert.Equal(expected, arr);
        }


        /// <summary>
        /// Dequeue to the expected node
        /// </summary>
        /// <param name="nodes">The nodes.</param>
        /// <param name="expected">The expected.</param>
        /// <param name="times">The times.</param>
        [Theory]
        [InlineData(new int[] { 1, 1, 4, 4, 5 }, 4, 3)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1, 0)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5, 5)]
        public void CanGetNodeFromDequeue(int[] nodes, int expected, int times)
        {
            queuesWithStacks.Classes.Queue queue = new queuesWithStacks.Classes.Queue(new Node(nodes[0]));

            for (int i = 1; i < nodes.Length; i++)
            {
                queue.Enqueue(new Node(nodes[i]));
            }

            for (int i = 1; i < times; i++)
            {
                queue.Dequeue();
            }

            Assert.Equal(expected, (int)queue.Dequeue().Value);
        }

        /// <summary>
        /// Can peek at node in queue
        /// </summary>
        [Fact]
        public void CanPeek()
        {
            Node nodeOne = new Node(3);
            Node nodeTwo = new Node(2);
            queuesWithStacks.Classes.Queue queue = new queuesWithStacks.Classes.Queue(nodeOne);
            queue.Enqueue(nodeTwo);

            Assert.Equal(queue.Peek(), nodeOne);

        }
    }
}
    
