using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter.Classes
{
    public class Cat : Animal
    {
        public override string Type { get; set; } = "cat";

        public Cat(string name)
        {
            Name = name;
        }
    }
}
