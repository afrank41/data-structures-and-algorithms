using System;
using Xunit;
using FifoAnimalShelter.Classes;

namespace AnimalShelterTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests if an animal shelter can enqueue a new animal
        /// </summary>
        [Fact]
        public void CanEnqueueAnAnimal()
        {
            Animal cat1 = new Cat("cat1");
            Animal cat2 = new Cat("cat2");
            AnimalShelter shelter = new AnimalShelter(cat1);

            Assert.Equal("Added a cat to the shelter!", shelter.Enqueue(cat2));
        }
        
        /// <summary>
        /// Tests if an animal shelter can enqueue an animal that is not a cat or dog
        /// </summary>
        [Fact]
        public void CanEnqueueAnAnimalThatIsNotCatOrDog()
        {
            Animal cat1 = new Cat("cat1");
            Animal fish = new Fish("fish");
            AnimalShelter shelter = new AnimalShelter(cat1);

            Assert.Equal("You added a \"something\" to the shelter.", shelter.Enqueue(fish));
        }
        
        /// <summary>
        /// Tests if an animal can be dequeued from an animal shelter
        /// </summary>
        [Fact]
        public void CanDequeueAnAnimal()
        {
            Animal cat1 = new Cat("cat1");
            Animal cat2 = new Cat("cat2");
            AnimalShelter shelter = new AnimalShelter(cat1);
            shelter.Enqueue(cat2);

            shelter.Dequeue();

            Assert.Equal(cat2, shelter.Front);
        }

        /// <summary>
        /// Tests if the first cat in a queue is dequeued
        /// </summary>
        [Fact]
        public void CanDequeueFirstCat()
        {
            Animal cat1 = new Cat("cat1");
            Animal cat2 = new Cat("cat2");
            Animal dog1= new Dog("dog1");
            Animal dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(dog1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(cat1);
            shelter.Enqueue(cat2);

            Assert.Equal(cat1, shelter.Dequeue("cat"));
        }
        
        /// <summary>
        /// Tests if the first dog in a queue is dequeued
        /// </summary>
        [Fact]
        public void CanDequeueFirstDog()
        {
            Animal cat1 = new Cat("cat1");
            Animal cat2 = new Cat("cat2");
            Animal dog1= new Dog("dog1");
            Animal dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(cat1);
            shelter.Enqueue(cat2);
            shelter.Enqueue(dog1);
            shelter.Enqueue(dog2);

            Assert.Equal(dog1, shelter.Dequeue("dog"));
        }
        
        /// <summary>
        /// Tests if the cat or dog is not put into dequeue parameter that it returns animal in front of queue
        /// </summary>
        [Fact]
        public void DequeueFrontIfBadParameter()
        {
            Animal cat1 = new Cat("cat1");
            Animal cat2 = new Cat("cat2");
            Animal dog1= new Dog("dog1");
            Animal dog2 = new Dog("dog2");
            AnimalShelter shelter = new AnimalShelter(cat1);
            shelter.Enqueue(cat2);
            shelter.Enqueue(dog1);
            shelter.Enqueue(dog2);

            Assert.Equal(cat1, shelter.Dequeue("lizard"));
        }
    }
}
