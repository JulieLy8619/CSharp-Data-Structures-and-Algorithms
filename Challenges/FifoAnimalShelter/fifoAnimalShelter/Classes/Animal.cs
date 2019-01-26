using System;
using System.Collections.Generic;
using System.Text;

namespace fifoAnimalShelter.Classes
{
    //enum for just cart or dog
    public enum AnimalOption
    {
        Dog,
        Cat
    }

    class Animal
    {
        //property
        public AnimalOption AnimalProp { get; set; }

        //instantiate (with and without starter value)
        public Animal(AnimalOption animalParam)
        {
            AnimalProp = animalParam;
        }

    }
}
