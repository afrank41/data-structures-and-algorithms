using System;
using FifoAnimalShelter.Classes;

namespace FifoAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat1 = new Cat("cat1");
            Animal cat2 = new Cat("cat2");
            Animal cat3 = new Cat("cat3");
            Animal dog1 = new Dog("dog1");
            Animal dog2 = new Dog("dog2");
            Animal dog3 = new Dog("dog3");
            Animal fish = new Fish("fish");

            AnimalShelter shelter = new AnimalShelter(cat1);

            shelter.Enqueue(cat2);
            shelter.Enqueue(cat3);
            shelter.Enqueue(dog1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(dog3);
            shelter.Enqueue(fish);

            Console.WriteLine(shelter.Dequeue("dog").Name);

            Console.WriteLine(shelter.Front.Name);
        }
    }
}
