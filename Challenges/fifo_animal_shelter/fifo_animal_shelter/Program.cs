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
            AnimalShelter animalShelter = new AnimalShelter();

            Cat boogalou = new Cat { Name = "Boogalou" };
            animalShelter.Enqueue(boogalou);
            Console.WriteLine($"A cat named {boogalou.Name} was taken into the shelter");

            Dog blackMagic = new Dog{ Name = "Black Magic" };
            animalShelter.Enqueue(blackMagic);
            Console.WriteLine($"A dog named {blackMagic.Name} was taken into the shelter");

            Cat garfield = new Cat { Name = "Garfield" };
            animalShelter.Enqueue(boogalou);
            Console.WriteLine($"A cat named {garfield.Name} was taken into the shelter");

            Cat clover = new Cat { Name = "Clover" };
            animalShelter.Enqueue(clover);
            Console.WriteLine($"A cat named {clover.Name} was taken into the shelter");

            Dog bruno = new Dog { Name = "Bruno" };
            animalShelter.Enqueue(bruno);
            Console.WriteLine($"A dog named {bruno.Name} was taken into the shelter");

            Console.WriteLine("First Cat taken in: {0}", animalShelter.Dequeue("cat").Name);
        }
    }
}
