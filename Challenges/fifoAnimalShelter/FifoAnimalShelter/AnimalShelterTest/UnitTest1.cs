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

            shelter.Enqueue(cat2);

            Assert.Equal(cat2, shelter.Rear);
        }
        
        /// <summary>
        /// 
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
    }
}
