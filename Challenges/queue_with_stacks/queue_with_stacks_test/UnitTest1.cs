using System;
using Xunit;
using queue_with_stacks_test;
using StackAndQueue.Classes;
using Day06_LinkedList.Classes
using StackAndQueue.Classes;

namespace queue_with_stacks_test
{
    public class UnitTest1
    {
        [Fact]
        public void QueueCanEnqueueNode()
        {
            Node newNode = new Node(1);
            Node enqueuedNode = new Node(3);
            QueueWithStacks.Classes.Queue myQueue = new queue_with_stacks.Classes.Queue(newNode);
            myQueue.Enqueue(new Node(2));
            myQueue.Enqueue(enqueuedNode);
            Assert.Equal(myQueue.Peek(), newNode);
        }
    }
}
