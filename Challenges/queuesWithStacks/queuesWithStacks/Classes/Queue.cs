using System;
using System.Collections.Generic;
using System.Text;
using StackAndQueue.Classes;
using Day06_LinkedList.Classes;

namespace queuesWithStacks.Classes
{
    class Queue
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
            while (stackOne.TopNode != null)
            {
                stackTwo.Push(stackOne.Pop());
            }

            while (stackTwo.TopNode != null)
            {
                stackOne.Push(stackTwo.Pop());
            }
        }

        public Node Dequeue()
        {
            if (stackOne.TopNode != null)
            {
                try
                {
                    return stackOne.Pop();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            throw new NullReferenceException();
        }

    }
}
