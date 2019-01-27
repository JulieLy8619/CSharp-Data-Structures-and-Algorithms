using System;
using System.Collections.Generic;
using System.Text;

namespace fifoAnimalShelter.Classes
{
    public class AnimalQueue
    {
        //properties
        public AnimalNode Front { get; set; }
        public AnimalNode Rear { get; set; }

        //instantiate (with and without starter "node")
        public AnimalQueue()
        {
            Front = null;
            Rear = null;
        }
        public AnimalQueue(AnimalNode node)
        {
            Front = node;
            Rear = node;
        }

        //enqueue
        /// <summary>
        /// this will enqueue into a queue but with an animal object
        /// </summary>
        /// <param name="value">an animal object</param>
        public void Enqueue(Animal value)
        {
            if (Front == null) //if queue was empty and I add one
            {
                AnimalNode newNode = new AnimalNode(value);
                Rear = newNode;//is this redundent because this should have happened in the instatiate with value because of line above
                Front = newNode;//is this redundent
            }
            else
            {
                AnimalNode newNode = new AnimalNode(value);
                Rear.Next = newNode;
                Rear = newNode;
            }
        }

        //dequeue
        /// <summary>
        /// this will dequeue from a queue, but just done with an animal object
        /// </summary>
        /// <returns>a node that has an onimal object</returns>
        public AnimalNode Dequeue()
        {
            //should add check if trying to dequeue from an empty queue
            if (Front == null)
            {
                return null;
            }
            else
            {
                AnimalNode temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }
        }

        /// <summary>
        /// peeks at the front of the queue
        /// </summary>
        /// <returns>the information of the node at the front of the queue</returns>
        public AnimalNode Peek()
        {
            return Front;
        }
    }
}
