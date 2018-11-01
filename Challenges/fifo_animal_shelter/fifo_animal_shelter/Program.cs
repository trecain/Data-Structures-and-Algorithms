using System;
using fifo_animal_shelter.Classes;

namespace fifo_animal_shelter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("First In First Out Animal");
            FIFOAnimalShelter();
        }

        public static void FIFOAnimalShelter()
        {
            AnimalShelter animalShelter = new AnimalShelter(new Cat("james"));

            Dog boogalou = new Dog("Boogalou");
            animalShelter.Enqueue(boogalou);
            Console.WriteLine($"A cat named {boogalou.Name} was taken into the shelter");

            Dog blackMagic = new Dog("Black Magic");
            animalShelter.Enqueue(blackMagic);
            Console.WriteLine($"A dog named {blackMagic.Name} was taken into the shelter");

            Cat garfield = new Cat("Garfield");
            animalShelter.Enqueue(boogalou);
            Console.WriteLine($"A cat named {garfield.Name} was taken into the shelter");

            Cat clover = new Cat("Clover");
            animalShelter.Enqueue(clover);
            Console.WriteLine($"A cat named {clover.Name} was taken into the shelter");

            Dog bruno = new Dog("Bruno");
            animalShelter.Enqueue(bruno);
            Console.WriteLine($"A dog named {bruno.Name} was taken into the shelter");

            Console.WriteLine("First Cat taken in: {0}", animalShelter.Dequeue().Name);
            Console.WriteLine("First selected dog {0}", animalShelter.Dequeue(new Dog("tre")).Name);
        }
    }
}
