using System;
using System.Collections.Generic;
using System.Text;
using StackAndQueue.Classes;


namespace queue_with_stacks.Classes
{
    class Queue
    {
        /// <summary>
        /// Sets the two properties for the front and the rear nodes of the queue
        /// </summary>
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }


        /// <summary>
        /// Returns the first node of the queue
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            return Front;
        }


        /// <summary>
        /// Adds a node the the queue
        /// </summary>
        /// <param name="node"></param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }


        /// <summary>
        /// returns the removed node
        /// </summary>
        /// <returns>temp</returns>
        public Node Dequeue()
        {
            try
            {
                Node temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp; 
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
