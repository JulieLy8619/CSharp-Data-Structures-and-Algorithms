using System;
using System.Collections.Generic;
using System.Text;

namespace fifoAnimalShelter.Classes
{
    //Node just adjusted so animal type instead of int type for VALUE
    public class AnimalNode
    {
        public Animal AnimalValue { get; set; }
        public AnimalNode Next { get; set; }

        public AnimalNode()
        {

        }
        public AnimalNode(Animal value)
        {
            AnimalValue = value;
            Next = null;
        }
    }
}
