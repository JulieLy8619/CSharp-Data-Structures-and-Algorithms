using System;
using System.Collections.Generic;
using System.Text;

namespace fifoAnimalShelter.Classes
{
    //should be like queue but with animal tye instad of int
    class AnimalShelter
    {
        //properties
        public AnimalQueue AnimalQueue1 = new AnimalQueue();
        public AnimalQueue AnimalQueue2 = new AnimalQueue();

        //instantiate (with and without starter "node")
        public AnimalShelter()
        {

        }
        public AnimalShelter(Animal newAnimal)
        {
            AnimalQueue1.Enqueue(newAnimal);
        }

        //enqueue


        //dequeue, this is where there is a param to check adopter's pref
    }
}
