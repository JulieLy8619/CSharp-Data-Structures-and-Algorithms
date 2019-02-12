# 

## Challenge

## Approach & Efficiency
I added my dll from BreadthFirstTraversal to ustilize the nodes/queues previously written.
We put each level into a queue. We compared each "root" node and dequeued it, and enqueued it's children
For time, it was Big O(n) because we would walk through all the nodes.
For space, it was Big O(w) where W is width, the width of the tree.

## Solution
WhiteBoard: 
![SnowdayIsAncestorWhiteBoard](../../../assets/SnowDayCCIsAncestorWB.jpg)
Console: 
![SnowdayIsAncestorConsole](../../../assets/SnowDayCCIsAncestorConsole.JPG)
Tests:
![SnowdayIsAncestorTests](../../../assets/SnowDayCCIsAncestorTests.JPG)