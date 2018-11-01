using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Classes
{
    class AnimalShelter
    {
        /// <summary>
        /// Sets the properties to hold the front and rear animals
        /// </summary>
        public Animal FrontAnimal { get; set; }
        public Animal RearAnimal { get; set; }
       

        /// <summary>
        /// Constructor to set the front and rear animals properties
        /// </summary>
        /// <param name="animal"></param>
        public AnimalShelter(Animal animal)
        {
            FrontAnimal = animal;
            RearAnimal = animal;
        }


        /// <summary>
        /// Grabs the first animal and returns it
        /// </summary>
        /// <returns>Returns the first Animal node</returns>
        public Animal Peek()
        {
            return FrontAnimal;
        }


        /// <summary>
        /// Adds an animal to the rear of the queue
        /// </summary>
        /// <param name="animal"></param>
        public void Enqueue(Animal animal)
        {
            RearAnimal.Next = animal;
            RearAnimal = animal;
        }

        public Animal Dequeue(Animal pref)
        {
            Animal res = null;
            Animal temp = null;

            if (pref.GetType() == FrontAnimal.GetType())
            {
                res = Dequeue();
            }
            else
            {
                temp = Dequeue();
                Enqueue(temp);
                while (FrontAnimal != temp)
                {
                    if ((FrontAnimal.GetType() == pref.GetType()) && (res == null))
                    {
                        res = Dequeue();
                    }
                    else
                    {
                        Enqueue(Dequeue());
                    }
                }
            }
            if (res == null)
            {
                res = Dequeue();
            }
            return res;
        }

        public Animal Dequeue()
        {
            Animal temp = Peek();
            FrontAnimal = FrontAnimal.Next;
            temp.Next = null;
            return temp;
        }

    }
}
