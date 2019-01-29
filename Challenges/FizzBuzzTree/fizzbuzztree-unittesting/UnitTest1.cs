using System;
using Xunit;
using FizzBuzzTree.Classes;
using FizzBuzzTree;

namespace fizzbuzztree_unittesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            FBObjectForNode nodeObj1 = new FBObjectForNode(3); //fizz
            FBObjectForNode nodeObj2 = new FBObjectForNode(11); //nothing
            FBObjectForNode nodeObj3 = new FBObjectForNode(21); // fizz
            FBObjectForNode nodeObj4 = new FBObjectForNode(30); //fizzbuzz
            FBObjectForNode nodeObj5 = new FBObjectForNode(25); //buzz

            FBNode treeRoot = new FBNode(nodeObj1);
            treeRoot.LeftChild = new FBNode(nodeObj2);
            treeRoot.RightChild = new FBNode(nodeObj3);
            treeRoot.LeftChild.LeftChild = new FBNode(nodeObj4);
            treeRoot.LeftChild.RightChild = new FBNode(nodeObj5);

            FBNode returnedTree1 = Program.FizzBuzzTree(treeRoot);

            Assert.Equal("Buzz", returnedTree1.LeftChild.RightChild.Value.StringValue);
        }
        [Fact]
        public void Test2()
        {
            FBObjectForNode nodeObj6 = new FBObjectForNode(3); //fizz
            FBObjectForNode nodeObj7 = new FBObjectForNode(11); //nothing
            FBObjectForNode nodeObj8 = new FBObjectForNode(21); // fizz
            FBObjectForNode nodeObj9 = new FBObjectForNode(30); //fizzbuzz
            FBObjectForNode nodeObj10 = new FBObjectForNode(25); //buzz

            FBNode treeRoot = new FBNode(nodeObj6);
            treeRoot.LeftChild = new FBNode(nodeObj7);
            treeRoot.RightChild = new FBNode(nodeObj8);
            treeRoot.LeftChild.LeftChild = new FBNode(nodeObj9);
            treeRoot.LeftChild.RightChild = new FBNode(nodeObj10);

            FBNode returnedTree2 = Program.FizzBuzzTree(treeRoot);

            Assert.Equal("FizzBuzz", returnedTree2.LeftChild.LeftChild.Value.StringValue);
        }
        [Fact]
        public void Test3()
        {
            FBObjectForNode nodeObj11 = new FBObjectForNode(3); //fizz
            FBObjectForNode nodeObj12 = new FBObjectForNode(11); //nothing
            FBObjectForNode nodeObj13 = new FBObjectForNode(21); // fizz
            FBObjectForNode nodeObj14 = new FBObjectForNode(30); //fizzbuzz
            FBObjectForNode nodeObj15 = new FBObjectForNode(25); //buzz

            FBNode treeRoot = new FBNode(nodeObj11);
            treeRoot.LeftChild = new FBNode(nodeObj12);
            treeRoot.RightChild = new FBNode(nodeObj13);
            treeRoot.LeftChild.LeftChild = new FBNode(nodeObj14);
            treeRoot.LeftChild.RightChild = new FBNode(nodeObj15);

            FBNode returnedTree3 = Program.FizzBuzzTree(treeRoot);

            Assert.Equal("11", returnedTree3.LeftChild.Value.StringValue);
        }
    }
}
