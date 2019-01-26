using System;
using System.Collections.Generic;
using System.Text;

namespace fifoAnimalShelter.Classes
{
    class AnimalQueue
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

        public AnimalNode Peek()
        {
            return Front;
        }
    }
}
