using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graph
    {
        //list of link list of graphnodes
        public List<GraphNode> AdjList = new List<GraphNode>();

        /// <summary>
        /// adds a node to the "graph"
        /// </summary>
        /// <param name="value">value of the new node</param>
        /// <returns>the new node</returns>
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

        /// <summary>
        /// adds an edge between 2 nodes
        /// </summary>
        /// <param name="node1">first node for edge connection</param>
        /// <param name="node2">second node for edge connection</param>
        /// <param name="node1Weight">option weight of the connection</param>
        /// <param name="node2Weight"></param>
        public void AddEdge(GraphNode node1, GraphNode node2, int? edgeWeight)
        {
            //add weights to nodes
            //I don't think this is right, I think it was supposed to be tuples...
            if (edgeWeight != null)
            {
                node1.EdgeWeight = edgeWeight;
                node2.EdgeWeight = edgeWeight;
            }

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

        /// <summary>
        /// gets the graph nodes
        /// </summary>
        /// <returns>all the nodes</returns>
        public List<GraphNode> GetNodes()
        {
            return AdjList;
        }

        /// <summary>
        /// gets the neighbors of a node
        /// </summary>
        /// <param name="node">which node you want to know it's neighbors</param>
        /// <returns>the neightbors of the given node (in linkedlist form)</returns>
        public GraphNode GetNeighbors(GraphNode node)
        {
            if (AdjList.Count == 0) //empty graph
            {
                return null;
            }
            else
            {
                //iterate list
                for (int i = 0; i < AdjList.Count; i++)
                {
                    //find node that matches
                    if (AdjList[i].Value == node.Value)
                    {
                        return AdjList[i]; //because it is a linked list I don't need to iterate
                    }
                }
                //went through graph and it isn't in it
                Console.WriteLine($"Node with value {node.Value} isn't in the graph");
                return null;
            }
        }

        /// <summary>
        /// finds how many nodes are in the graph
        /// </summary>
        /// <returns>the nuber of nodes in the graph</returns>
        public int Size()
        {
            return AdjList.Count;
        }

    }
}
