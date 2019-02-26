using System;
using Xunit;
using Graph.Classes;

namespace graph_unittesting
{
    public class UnitTest1
    {
        //Node can be successfully added to the graph
        [Fact]
        public void TestAddNode()
        {
            Graph.Classes.Graph testGraph1 = new Graph.Classes.Graph();
            //GraphNode testNode1 = new GraphNode(5);
            testGraph1.AddNode(5);
            Assert.Equal(5,testGraph1.AdjList[0].Value);

        }

        //An edge can be successfully added to the graph


        //A collection of all nodes can be properly retrieved from the graph


        //All appropriate neighbors can be retrieved from the graph


        //Neighbors are returned with the weight between nodes included


        //The proper size is returned, representing the number of nodes in the graph


        //A graph with only one node and edge can be properly returned


        //An empty graph properly returns null

        //test breadthfirsttraversal
        }
}


//Write tests to prove the following functionality:

//Node can be successfully added to the graph
//An edge can be successfully added to the graph
//A collection of all nodes can be properly retrieved from the graph
//All appropriate neighbors can be retrieved from the graph
//Neighbors are returned with the weight between nodes included
//The proper size is returned, representing the number of nodes in the graph
//A graph with only one node and edge can be properly returned
//An empty graph properly returns null