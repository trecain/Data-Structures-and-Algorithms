using System;
using Xunit;
using Day06_LinkedList.Classes;
using StackAndQueue.Classes;
using queuesWithStacks.Classes;

namespace queuesWithStacksTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueueNode()
        {
            Node node = new Node(9);
            Node enqueuedNode = new Node(8);
            queuesWithStacks.Classes.Queue queue = new queuesWithStacks.Classes.Queue(node);
            queue.Enqueue(enqueuedNode);
            Assert.Equal(queue.Peek(), node);
        }
    }
}
