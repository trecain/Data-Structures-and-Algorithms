using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter.Classes
{
    public abstract class Animal
    {
        /// <summary>
        /// Gets or sets the Name property
        /// </summary>
        public string Name { get; set; }
        public Animal Next { get; set; }

        public Animal (string name)
        {
            Name = name;
        }
    }
}
