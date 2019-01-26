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
            AnimalOption type1 = georgeNode.AnimalValue.AnimalProp;
            Assert.Equal(AnimalOption.Dog, type1);

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

        //dequeue

        [Fact]
        public void TestAnimalQDeQ1()
        {
            Animal dog1 = new Animal(AnimalOption.Dog);
            AnimalQueue dog1Q = new AnimalQueue();
            dog1Q.Enqueue(dog1);
            AnimalNode dog1Node = dog1Q.Dequeue();
            AnimalOption type2 = dog1Node.AnimalValue.AnimalProp;
            Assert.Equal(AnimalOption.Dog, type2);
        }
        [Fact]
        public void TestAnimalQDeQ2()
        {
            Animal dog2 = new Animal(AnimalOption.Dog);
            AnimalQueue dog2Q = new AnimalQueue();
            dog2Q.Enqueue(dog2);
            AnimalNode dog1Node = dog2Q.Dequeue();
            Assert.Null(dog2Q.Front);
        }
        [Fact]
        public void TestAnimalQDeQ3()
        {
            Animal dog3 = new Animal(AnimalOption.Dog);
            Animal cat1 = new Animal(AnimalOption.Cat);
            Animal cat2 = new Animal(AnimalOption.Cat);
            AnimalNode puppyNode = new AnimalNode(dog3);
            AnimalQueue animal1Q = new AnimalQueue(puppyNode);
            animal1Q.Enqueue(cat1);
            animal1Q.Enqueue(cat2);
            AnimalNode junk1Node = animal1Q.Dequeue();
            AnimalNode checkNode = animal1Q.Dequeue();
            AnimalOption type3 = checkNode.AnimalValue.AnimalProp;
            Assert.Equal(AnimalOption.Cat, type3);
        }

        //peek
        [Fact]
        public void TestAnimalQPeek1()
        {
            Animal dogPeek1 = new Animal(AnimalOption.Dog);
            AnimalQueue dogPeek1Q = new AnimalQueue();
            dogPeek1Q.Enqueue(dogPeek1);
            AnimalNode dog1Node = dogPeek1Q.Peek();
            AnimalOption type4 = dog1Node.AnimalValue.AnimalProp;
            Assert.Equal(AnimalOption.Dog, type4);
        }

        [Fact]
        public void TestAnimalQPeek2()
        {
            Animal dogPeek2 = new Animal(AnimalOption.Dog);
            AnimalQueue dogPeek2Q = new AnimalQueue();
            dogPeek2Q.Enqueue(dogPeek2);
            dogPeek2Q.Dequeue();
            AnimalNode dog2Node = dogPeek2Q.Peek();
            Assert.Null(dog2Node);
        }
        [Fact]
        public void TestAnimalQPeek3()
        {
            Animal dogPeek3 = new Animal(AnimalOption.Dog);
            Animal catPeek1 = new Animal(AnimalOption.Cat);
            AnimalNode puppyNode2 = new AnimalNode(dogPeek3);
            AnimalQueue animalPeek3Q = new AnimalQueue(puppyNode2);
            animalPeek3Q.Enqueue(dogPeek3);
            animalPeek3Q.Dequeue();
            animalPeek3Q.Dequeue();
            animalPeek3Q.Enqueue(catPeek1);
            AnimalNode animal3Node = animalPeek3Q.Peek();
            AnimalOption type5 = animal3Node.AnimalValue.AnimalProp;
            Assert.Equal(AnimalOption.Cat, type5);
        }


    }
}

/*
        //[Fact]
        //public void Test1()
        //{

        //}
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
