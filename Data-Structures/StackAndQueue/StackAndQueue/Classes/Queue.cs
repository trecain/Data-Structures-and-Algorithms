using System;
using System.Collections.Generic;
using System.Text;
using Day06_LinkedList.Classes;

namespace StackAndQueue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Back { get; set; }

        ///<summary>
        /// A new Queue is created with front and back nodes.
        /// </summary>
        /// <param name="node">Param for the nodes</param>

        public Queue(Node node)
        {
            Front = node;
            Back = node;
        }


        /// <summary>
        /// Returns the Queues front node
        /// </summary>
        /// <returns>The front Node</returns>
        public Node View()
        {
            return Front;
        }


        /// <summary>
        /// Adds node to the end of the Queue
        /// </summary>
        /// <param name="node">Node to be added</param>
        public void addsNodeToEndOfTheQueue(Node node)
        {
            Back.Next = node;
            Back = node;
        }


        /// <summary>
        /// Removes node from the front of the Queue
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public Node RemovesNodeFromFrontOfTheQueue()
        {
            Node holdsPeekedQueue = View();
            Front = Front.Next;
            holdsPeekedQueue.Next = null;
            return holdsPeekedQueue;
        }
    }
}
