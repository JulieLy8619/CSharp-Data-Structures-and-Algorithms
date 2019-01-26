using System;
using Xunit;
using fifoAnimalShelter.Classes;


namespace fifoAnimalShelter_unittesting
{
    public class UnitTest1
    {
        //animal queue testing
        //enqueue
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

        //shelter testing
        //enqueue
        [Fact]
        public void TestShelterEnQ1()
        {
            Animal animal1 = new Animal(AnimalOption.Dog);
            Animal animal1A = new Animal(AnimalOption.Dog);
            AnimalShelter shelter1 = new AnimalShelter(animal1);
            shelter1.ShelterEnqueue(animal1A);
            AnimalNode shelterAnimalNode1 = shelter1.AnimalQueue1.Rear;
            AnimalOption type6 = shelterAnimalNode1.AnimalValue.AnimalProp;
            Assert.Equal(AnimalOption.Dog, type6);


        }
        [Fact]
        public void TestShelterEnQ2()
        {
            Animal animal2 = new Animal(AnimalOption.Dog);
            Animal animal3 = new Animal(AnimalOption.Cat);
            Animal animal4 = new Animal(AnimalOption.Cat);
            AnimalShelter shelter2 = new AnimalShelter(animal2);
            shelter2.ShelterEnqueue(animal3);
            shelter2.ShelterEnqueue(animal4);
            AnimalNode shelterAnimalNode2 = shelter2.AnimalQueue1.Rear;
            AnimalOption type7 = shelterAnimalNode2.AnimalValue.AnimalProp;
            Assert.Equal(AnimalOption.Cat, type7);

        }
        [Fact]
        public void TestShelterEnQ3()
        {
            Animal animal5 = new Animal(AnimalOption.Dog);
            Animal animal6 = new Animal(AnimalOption.Cat);
            Animal animal7 = new Animal(AnimalOption.Dog);
            Animal animal8 = new Animal(AnimalOption.Dog);
            AnimalShelter shelter3 = new AnimalShelter(animal5);
            shelter3.ShelterEnqueue(animal6);
            shelter3.ShelterEnqueue(animal7);
            shelter3.ShelterEnqueue(animal8);
            AnimalNode shelterAnimalNode3 = shelter3.AnimalQueue1.Rear;
            AnimalOption type8 = shelterAnimalNode3.AnimalValue.AnimalProp;
            Assert.Equal(AnimalOption.Dog, type8);

        }

        //dequeue
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
