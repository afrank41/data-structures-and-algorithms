using System;
using System.Collections.Generic;
using System.Text;
using StackQueue.Classes;

namespace FifoAnimalShelter.Classes
{
    public abstract class Animal
    {
        public Animal Next { get; set; }

        public string Name { get; set; }

        public abstract string Type { get; set; }
    }
}
