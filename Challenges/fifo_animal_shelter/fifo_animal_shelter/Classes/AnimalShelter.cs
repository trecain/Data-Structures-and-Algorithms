using System;
using System.Collections.Generic;
using System.Text;
using StackAndQueue.Classes;

namespace fifo_animal_shelter.Classes
{
    class AnimalShelter
    {
        /// <summary>
        /// sets the queue for the animal shelter
        /// </summary>
        public Queue Queue { get; set; }

        /// <summary>
        /// Animal constructor
        /// </summary>
        public AnimalShelter()
        {
            ///<summary>
            /// Creates a queue and adds a node with a value of nine
            /// </summary>
            Queue = new Queue(new Node(9));
            Queue.Dequeue();
        }


        /// <summary>
        /// Enqueues the animal into the queue
        /// </summary>
        /// <param name="animal"></param>
        public void Enqueue(Animal animal)
        {
            Queue.Enqueue(new Node(animal));
        }

        public Animal Dequeue(string animal)
        {
            ///<summary>
            /// checks to see if the animal is a dog or cat
            /// cast queue to type animal and returns the the node value
            /// </summary>
            if (animal != "dog" && animal != "cat")
            {
                return (Animal)Queue.Dequeue().Value;
            }

            ///<summary>
            /// saves a reference to the peeked node on the queue for animal comparison
            /// </summary>
            Object head = Queue.View().Value;
            Type animalType = (animal == "dog" ? typeof(Dog) : typeof(Cat));

            if (Queue.View().Value.GetType() == animalType)
            {
                return (Animal)Queue.Dequeue().Value;
            }

            Animal animalFound = null; 

            ///<summary>
            /// Search and reorder while animal found is null and queue is out of order
            /// </summary>
            while (animalFound == null || Queue.View().Value != head)
            {
                Queue.Enqueue(Queue.Dequeue());

                if (animalFound == null && Queue.View().Value.GetType() == animalType)
                {
                    animalFound = (Animal)Queue.Dequeue().Value;
                }
            }
            return animalFound;
        }

    }
}
