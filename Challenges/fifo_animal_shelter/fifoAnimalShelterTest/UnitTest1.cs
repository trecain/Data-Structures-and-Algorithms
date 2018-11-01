using System;
using Xunit;
using fifo_animal_shelter.Classes;

namespace fifoAnimalShelterTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Checks if a dog can be added to the shelter
        /// </summary>
        [Fact]
        public void CanTakeInADog()
        {
            Dog jeff = new Dog("Jeff");
            AnimalShelter animalShelter = new AnimalShelter(jeff);
            Assert.Equal("Jeff", animalShelter.FrontAnimal.Name);
        }


        /// <summary>
        /// Checks if a cat can be added to the shelter
        /// </summary>
        [Fact]
        public void CanTakeInACat()
        {
            Cat jiffy = new Cat("Jiffy");
            AnimalShelter animalShelter = new AnimalShelter(jiffy);
            Assert.Equal("Jiffy", animalShelter.FrontAnimal.Name);
        }


        /// <summary>
        /// Test if an animal can be added to the rear of the queue
        /// </summary>
        [Fact]
        public void EnqueueCanAddAnimalToRearOfQueue()
        {
            Dog doggy = new Dog("doggy");
            Dog jack = new Dog("jack");
            Cat catty = new Cat("catty");
            AnimalShelter animalSheter = new AnimalShelter(doggy);
            animalSheter.Enqueue(jack);
            animalSheter.Enqueue(catty);
            Assert.Equal("catty", animalSheter.RearAnimal.Name);
        }


        /// <summary>
        /// Can return the animal from the top of the queue
        /// </summary>
        [Fact]
        public void DequeueCanReturnsAnimalAtFrontOfQueue()
        {
            Dog doggy = new Dog("doggy");
            Dog jack = new Dog("jack");
            Cat catty = new Cat("catty");
            AnimalShelter animalShelter = new AnimalShelter(doggy);
            animalShelter.Enqueue(jack);
            animalShelter.Enqueue(catty);
            Assert.Equal("doggy", animalShelter.Dequeue().Name);
        }


        /// <summary>
        /// test that the first dog in the queue is returned
        /// </summary>
        [Fact]
        public void CanReturnFirstDogInQueue()
        {
            Cat coco = new Cat("coco");
            Dog doggy = new Dog("doggy");
            Dog jack = new Dog("jack");
            Cat catty = new Cat("catty");
            AnimalShelter animalShelter = new AnimalShelter(coco);
            animalShelter.Enqueue(doggy);
            animalShelter.Enqueue(jack);
            animalShelter.Enqueue(catty);
            animalShelter.Enqueue(coco);
            Assert.Equal("doggy", animalShelter.Dequeue(new Dog()).Name);
        }


        /// <summary>
        /// Test that the first cat in the queue can be returned
        /// </summary>
        [Fact]
        public void CanReturnFirstCatInQueue()
        {
            Cat coco = new Cat("coco");
            Dog doggy = new Dog("doggy");
            Dog jack = new Dog("jack");
            Cat catty = new Cat("catty");
            AnimalShelter animalShelter = new AnimalShelter(coco);
            animalShelter.Enqueue(doggy);
            animalShelter.Enqueue(coco);
            animalShelter.Enqueue(jack);
            animalShelter.Enqueue(catty);
            Assert.Equal("coco", animalShelter.Dequeue(new Cat()).Name);
        }


        /// <summary>
        /// test the the original order of animals maintains after dequeue
        /// </summary>
        [Fact]
        public void CanKeepOriginalOrderOfAnimals()
        {
            Cat coco = new Cat("coco");
            Dog doggy = new Dog("doggy");
            Dog jack = new Dog("jack");
            Cat catty = new Cat("catty");
            AnimalShelter animalShelter = new AnimalShelter(coco);
            animalShelter.Enqueue(doggy);
            animalShelter.Enqueue(jack);
            animalShelter.Enqueue(catty);
            animalShelter.Dequeue(new Dog());

            Assert.Equal("coco", animalShelter.FrontAnimal.Name);
        }


        /// <summary>
        /// Test that the first animal is returned if the pref is not a cat or dog
        /// </summary>
        [Fact]
        public void CanReturnFirstAnimalIfNotACatOrDog()
        {
            Cat coco = new Cat("coco");
            Dog doggy = new Dog("doggy");
            Dog jack = new Dog("jack");
            Cat catty = new Cat("catty");
            AnimalShelter animalShelter = new AnimalShelter(coco);
            animalShelter.Enqueue(doggy);
            animalShelter.Enqueue(coco);
            animalShelter.Enqueue(jack);
            animalShelter.Enqueue(catty);
            Assert.Equal("coco", animalShelter.Dequeue(new Moose()).Name);
        }
    }
}
