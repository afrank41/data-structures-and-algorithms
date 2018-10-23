using System;
using System.Collections.Generic;
using System.Text;
using StackQueue.Classes;

namespace FifoAnimalShelter.Classes
{
    class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
        }

        /// <summary>
        /// Adds an animal node to the rear of a queue in the animal shelter
        /// </summary>
        /// <param name="animal">animal node to be added to queue</param>
        /// <returns>returns a success message if a dog or cat is enqueued</returns>
        public string Enqueue(Animal animal)
        {
            string message = $"Not a cat or dog. You added a {animal.Type} to the shelter.";

            if(animal is Cat)
            {
                Rear.Next = animal;
                Rear = animal;
                message = $"Added a {animal.Type} to the shelter!";
                return message;
            }
            else if (animal is Dog)
            {
                Rear.Next = animal;
                Rear = animal;
                message = $"Added a {animal.Type} to the shelter!";
                return message;
            }

            return message;
        }

        /// <summary>
        /// Removes either a cat or dog node from the front of its respective queue within the animal shelter
        /// </summary>
        /// <param name="animal">"cat" or "dog" to specify which queue to have node removed from front</param>
        /// <returns></returns>
        public Animal Dequeue(string animal)
        {       
        }
    }
}
