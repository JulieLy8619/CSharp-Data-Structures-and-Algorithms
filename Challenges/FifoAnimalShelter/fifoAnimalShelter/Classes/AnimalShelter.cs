using System;
using System.Collections.Generic;
using System.Text;

namespace fifoAnimalShelter.Classes
{
    public class AnimalShelter
    {
        //properties
        public AnimalQueue AnimalQueue1 = new AnimalQueue();
        public AnimalQueue AnimalQueue2 = new AnimalQueue();

        //instantiate (with and without starter "node")
        //public AnimalShelter() //I don't think I need this because they already got created in the properties
        //{

        //}
        //instantiate
        public AnimalShelter(Animal newAnimal)
        {
            AnimalQueue1.Enqueue(newAnimal);
        }

        //enqueue
        /// <summary>
        /// Adds a new animal to the shelter (queue1)
        /// </summary>
        /// <param name="value">animal object want to add to shelter (queue)</param>
        public void ShelterEnqueue(Animal value)
        {
            AnimalQueue1.Enqueue(value);
        }

        //dequeue, this is where there is a param to check adopter's pref
        /// <summary>
        /// checks if the animal user is looking for is in shelter
        /// </summary>
        /// <param name="pref">what animal is the user searching for</param>
        /// <returns>if the animal is in the shelter, returns the animal, else null</returns>
        public AnimalNode ShelterDequeue(Animal pref)
        {
            if (AnimalQueue1.Peek() == null && AnimalQueue2.Peek() == null) //shelter is empty
            {
                return null; 
            }
            else
            {
                while (AnimalQueue1.Peek() != null)
                {
                    if (AnimalQueue1.Peek().AnimalValue.AnimalProp == pref.AnimalProp)
                    {
                        AnimalNode returnAnimal = new AnimalNode();
                        returnAnimal = AnimalQueue1.Dequeue();
                        //moves remainder of queue to other queue to keep correct order
                        while (AnimalQueue1.Peek() != null)
                        {
                            AnimalNode tempAnimal = new AnimalNode();
                            tempAnimal = AnimalQueue1.Dequeue();
                            AnimalQueue2.Enqueue(tempAnimal.AnimalValue);
                        }
                        //my design pushes it back to the first queue because of how I add to the shelter
                        while (AnimalQueue2.Peek() != null)
                        {
                            AnimalNode tempAnimal = new AnimalNode();
                            tempAnimal = AnimalQueue2.Dequeue();
                            AnimalQueue1.Enqueue(tempAnimal.AnimalValue);
                        }
                        return returnAnimal;
                    }
                    else
                    {
                        AnimalNode tempAnimal = new AnimalNode();
                        tempAnimal = AnimalQueue1.Dequeue();
                        AnimalQueue2.Enqueue(tempAnimal.AnimalValue);
                    }
                }
                return null;
            }
        }
    }
}
