using System;
using Xunit;
using Day06_LinkedList; 
using Day06_LinkedList.Classes;

namespace LinkedListTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to see if node value is added
        /// </summary>
        /// <param name="value">node value to be added</param>
        [Theory]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(90)]
        public void CanAdd(int value)
        {
            LList ll = new LList(new Node(1));
            ll.Add(new Node(value));
            Assert.True((int)ll.Head.Value == value);
        }

        /// <summary>
        /// Node will be added to the end of the Linked list 
        /// </summary>
        /// <param name="value">value of node to add</param>
        [Theory]
        [InlineData(53)]
        [InlineData(90)]
        [InlineData(3)]
        public void CanAppend(int value)
        {
            LList ll = new LList(new Node(2));
            ll.Add(new Node(12));
            ll.Add(new Node(13));
            ll.Append(new Node(value));
            Assert.True((int)ll.Head.Next.Next.Next.Value == value);
        }

        /// <summary>
        /// Node will be added before specified node.
        /// </summary>
        /// <param name="value">value of node to add</param>
        [Theory]
        [InlineData(7)]
        [InlineData(14)]
        [InlineData(12)]
        public void CanAddBefore(int value)
        {
            Node nodeToPrecede = new Node(1000);
            LList ll = new LList(nodeToPrecede);
            ll.AddBefore(new Node(value), nodeToPrecede);
            Assert.True((int)ll.Head.Value == value);
        }

        /// <summary>
        /// Node will be added after specified node.
        /// </summary>
        /// <param name="value">value of node to add</param>
        [Theory]
        [InlineData(66)]
        [InlineData(32)]
        [InlineData(98)]
        public void AddAfterTest(int value)
        {
            LList ll = new LList(new Node(100));
            ll.Add(new Node(390));
            Node nodeToFollow = new Node(1);
            ll.Add(nodeToFollow);
            ll.AddAfter(new Node(value), nodeToFollow);
            Assert.True((int)ll.Head.Next.Value == value);
        }
    }
}