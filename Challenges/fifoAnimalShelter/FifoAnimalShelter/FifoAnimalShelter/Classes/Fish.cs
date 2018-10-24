using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter.Classes
{
    public class Fish : Animal
    {
        public override string Type { get; set; } = "fish";

        public Fish(string name)
        {
            Name = name;
        }
    }
}
