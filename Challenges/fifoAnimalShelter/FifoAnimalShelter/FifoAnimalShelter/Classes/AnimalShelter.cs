using System;
using System.Collections.Generic;
using System.Text;
using StackQueue.Classes;

namespace FifoAnimalShelter.Classes
{
    public class AnimalShelter
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
            string message = "You added a \"something\" to the shelter.";

            if(animal is Cat)
            {
                Rear.Next = animal;
                Rear = animal;
                message = "Added a cat to the shelter!";
                return message;
            }
            else if (animal is Dog)
            {
                Rear.Next = animal;
                Rear = animal;
                message = "Added a dog to the shelter!";
                return message;
            }

            return message;
        }

        /// <summary>
        /// Removed an animal from the front of the animal shelter queue
        /// </summary>
        /// <returns>returns the animal removed</returns>
        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Removes the first cat or dog from the animal shelter queue
        /// </summary>
        /// <param name="animal">the animal type to be removed from queue</param>
        /// <returns>returns the animal object that was removed</returns>
        public Animal Dequeue(string animal)
        {   
            if (animal == "cat")
            {
                Animal temp = Front;
                while (!(Front is Cat))
                {
                    Enqueue(Dequeue());
                    if(temp == Front)
                    {
                        return Dequeue();
                    }
                }

                Animal cat = Dequeue();

                while(Front != temp)
                {
                    Enqueue(Dequeue());
                }

                return cat;
            }
            else if (animal == "dog")
            {
                Animal temp = Front;
                while (!(Front is Dog))
                {
                    Enqueue(Dequeue());
                    if (temp == Front)
                    {
                        return Dequeue();
                    }
                }

                Animal dog = Dequeue();

                while (Front != temp)
                {
                    Enqueue(Dequeue());
                }

                return dog;
            }
            else
            {
                return Front;
            }
        }
    }
}
