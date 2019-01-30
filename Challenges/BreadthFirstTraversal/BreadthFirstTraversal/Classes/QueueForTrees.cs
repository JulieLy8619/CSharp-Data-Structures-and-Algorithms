using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal.Classes
{
    class QueueForTrees
    {
        //properties
        public TreeNode Front { get; set; }
        public TreeNode Rear { get; set; }

        //instantiate
        //queue with nothing given
        public QueueForTrees()
        {
            Front = null;
            Rear = null;
        }

        //queue with a given node
        public QueueForTrees(TreeNode node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// adding a node to the queue
        /// </summary>
        /// <param name="value">value of new node</param>
        public void Enqueue(int value)
        {
            if (Front == null) //if queue was empty and I add one
            {
                TreeNode newNode = new TreeNode(value);
                Rear = newNode;
                Front = newNode;
            }
            else
            {
                TreeNode newNode = new TreeNode(value);
                Rear.Next = newNode;
                Rear = newNode;
            }
        }

        /// <summary>
        /// removes a node from the queue
        /// </summary>
        /// <returns>the first node in the queue</returns>
        public TreeNode Dequeue()
        {
            //should add check if trying to dequeue from an empty queue
            if (Front == null)
            {
                return null;
            }
            else
            {
                TreeNode temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }
        }

        /// <summary>
        /// looks to see whos in front of the queue
        /// </summary>
        /// <returns>information on the first node in the queue</returns>
        public TreeNode Peek()
        {
            return Front;
        }
    }
}
