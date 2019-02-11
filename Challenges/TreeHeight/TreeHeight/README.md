# Find Height of a Binary Tree
We were asked to write a method that determines the height of a binary tree

## Challenge
I chose breadth first over depth first because I worried with the recursion of the depth first method woudl reset variables.
Breadth first is reading nodes in a tree from top to bottom left to right (on each level) 

## Approach & Efficiency
I added my dll from BreadthFirstTraversal to utilize the nodes/queues previously written.
I put each level into a queue, then added to the height counter if the root had children otherwise I was counting all the nodes instead of each "roots", and enqueued it's children
For time, it was Big O(n) because we would walk through all the nodes.
For space, it was Big O(w) where W is width, the width of the tree.

## Solution
WhiteBoard: 
![CC18WhiteBoard](../../../assets/SnowDayCCTreeHeightWB.jpg)
Console: 
![CC18Console](../../../assets/SnowDayCCTreeHeightConsole.JPG)
Tests:
![CC18Tests](../../../assets/SnowDayCCTreeHeightTests.JPG)