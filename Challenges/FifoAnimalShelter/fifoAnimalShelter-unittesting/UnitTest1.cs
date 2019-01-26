using System;
using Xunit;
using fifoAnimalShelter.Classes;

namespace fifoAnimalShelter_unittesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestAnimalQEnQ1()
        {
            Animal dogGeorge = new Animal(AnimalOption.Dog);
            AnimalQueue georgeQ = new AnimalQueue();
            georgeQ.Enqueue(dogGeorge);
            AnimalNode georgeNode = georgeQ.Dequeue();
            AnimalOption type = georgeNode.AnimalValue.AnimalProp;
            Assert.Equal(AnimalOption.Dog, type);

        }
        [Fact]
        public void TestAnimalQEnQ2()
        {
            Animal dogBob = new Animal(AnimalOption.Dog);
            Animal catBetty = new Animal(AnimalOption.Cat);
            AnimalQueue newQ2 = new AnimalQueue();
            newQ2.Enqueue(dogBob);
            newQ2.Enqueue(catBetty);
            AnimalNode newQ2Rear = newQ2.Rear;
            Assert.Equal(AnimalOption.Cat, newQ2Rear.AnimalValue.AnimalProp);
        }
        [Fact]
        public void TestAnimalQEnQ3()
        {
            Animal catKitty = new Animal(AnimalOption.Cat);
            Animal dogLarry = new Animal(AnimalOption.Dog);
            Animal catJenny = new Animal(AnimalOption.Cat);
            AnimalNode kittyNode = new AnimalNode(catKitty);
            AnimalQueue newQ3 = new AnimalQueue(kittyNode);
            newQ3.Enqueue(dogLarry);
            newQ3.Enqueue(catJenny);
            AnimalNode newQ3Rear = newQ3.Rear;
            Assert.Equal(AnimalOption.Cat, newQ3Rear.AnimalValue.AnimalProp);
        }


        //[Fact]
        //public void Test1()
        //{

        //}
    }
}

/*
 Things to think about for testing
    -animal
        -no methods so no tests needed
    -animalnode
        -no methods so no tests needed
    -aniamlqueue 
        -enqueue
        -dequeue
        -peek
     -shelter
        -empty shelter
        -enqueue
            -addeding to shelter
        -dequeue
            -removing from shelter
            -trying to remove from shelter when its empty
            -finding a match adoption
            -user's choice isn't in shelter
        -adding 2, removing 1, adding 2 (test integrity of queue order)
 * */
