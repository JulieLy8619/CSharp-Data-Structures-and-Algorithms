using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graph
    {
        public List<GraphNode> AdjList = new List<GraphNode>();

        public GraphNode AddNode(int value)
        {
            GraphNode newNode = new GraphNode(value);
            AdjList.Add(newNode);
            return newNode;
        }

        public void AddEdge(GraphNode node1, GraphNode node2)
        {
            for (int i = 0; i < AdjList.Count; i++)
            {

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
