using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graph
    {
        //list of link list of graphnodes
        public List<GraphNode> AdjList = new List<GraphNode>();

        public GraphNode AddNode(int value)
        {
            GraphNode newNode = new GraphNode(value);
            //check if it is already in the graph
            if (AdjList.Contains(newNode) == true) //it is in the table
            {
                Console.WriteLine($"Node with value {newNode.Value} is already in the graph");
                return null; //since nothing new added, return null
            }
            else
            {
                AdjList.Add(newNode);
                return newNode;
            }
        }

        public void AddEdge(GraphNode node1, GraphNode node2)
        {
            if (AdjList.Contains(node1) == false) //it isn't in the table
            {
                Console.WriteLine($"Node with value {node1.Value} isn't in the graph");
                return; //just to exit method
            }
            if (AdjList.Contains(node2) == false) //it isn't in the table
            {
                Console.WriteLine($"Node with value {node2.Value} isn't in the graph");
                return; //just to exit method
            }
            //if got to here, both are in the graph
            for (int i = 0; i < AdjList.Count; i++)
            {
                if (AdjList[i].Value == node1.Value)
                {
                    //add node 2
                    if (AdjList[i].Next == null)
                    {
                        AdjList[i].Next = node2;
                    }
                    else
                    {
                        GraphNode current = AdjList[i].Next;
                        while (AdjList[i].Next != null)
                        {
                            current = AdjList[i].Next;
                        }
                        current.Next = node2;
                    }
                }
                if (AdjList[i].Value == node2.Value)
                {
                    //add node 1
                    if (AdjList[i].Next == null)
                    {
                        AdjList[i].Next = node1;
                    }
                    else
                    {
                        GraphNode current = AdjList[i].Next;
                        while (AdjList[i].Next != null)
                        {
                            current = AdjList[i].Next;
                        }
                        current.Next = node1;
                    }
                }
            }
        }

        public List<GraphNode> GetNodes()
        {
            return AdjList;
        }

        public List<GraphNode> GetNeighbors(GraphNode node)
        {
            //iterate list
            for (int i = 0; i < AdjList.Count; i++)
            {
                //find node that matches
                //return it's list
            }
        }

        public int Size()
        {
            return AdjList.Count;
        }

    }
}
