using System;
using System.Collections.Generic;
using System.Text;
using StackAndQueue.Classes;
using Day06_LinkedList.Classes;

namespace queuesWithStacks.Classes
{
    public class Queue
    {
        /// <summary>
        /// Sets the properties to hold the two stacks for the queue
        /// </summary>
        private Stack stackOne { get; set; }
        private Stack stackTwo { get; set; }


        /// <summary>
        /// Initializes the two stacks
        /// </summary>
        /// <param name="node">Node needed to initialize the stack</param>
        public Queue(Node node)
        {
            stackOne = new Stack(node);
            stackTwo = new Stack(node);
            stackTwo.Pop();
        }

        /// <summary>
        /// returns the top node on the stack
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            return stackOne.View();
        }


        /// <summary>
        /// Enqueues a specified node 
        /// </summary>
        /// <param name="node"></param>
        public void Enqueue(Node node)
        {
            while (stackOne.Size > 0)
            {
                stackTwo.Push(stackOne.Pop());
            }

            stackTwo.Push(node);

            while (stackTwo.Size > 0)
            {
                stackOne.Push(stackTwo.Pop());
            }
        }


        /// <summary>
        /// Dequeues a specified node
        /// </summary>
        /// <returns>Returns the node on the top of the stack</returns>
        public Node Dequeue()
        {
            if (stackOne.Size > 0)
            {
                return stackOne.Pop();
            }
            throw new NullReferenceException();
        }

    }
}
