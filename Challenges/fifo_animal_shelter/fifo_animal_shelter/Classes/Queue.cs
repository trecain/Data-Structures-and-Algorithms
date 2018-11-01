using System;
using System.Collections.Generic;
using System.Text;


namespace queue_with_stacks.Classes
{
    public class Queue
    {
        /// <summary>
        /// Sets the two properties for the front and the rear nodes of the queue
        /// </summary>
        public fifo_animal_shelter.Classes.Node Front { get; set; }
        public fifo_animal_shelter.Classes.Node Rear { get; set; }

        public Queue(fifo_animal_shelter.Classes.Node node)
        {
            Front = node;
            Rear = node;
        }


        /// <summary>
        /// Returns the first node of the queue
        /// </summary>
        /// <returns></returns>
        public fifo_animal_shelter.Classes.Node Peek()
        {
            return Front;
        }


        /// <summary>
        /// Adds a node the the queue
        /// </summary>
        /// <param name="node"></param>
        public void Enqueue(fifo_animal_shelter.Classes.Node node)
        {
            Rear.Next = node;
            Rear = node;
        }


        /// <summary>
        /// returns the removed node
        /// </summary>
        /// <returns>temp</returns>
        public fifo_animal_shelter.Classes.Node Dequeue()
        {
            try
            {
                fifo_animal_shelter.Classes.Node temp = Front;
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
