<!--
1-14-19 9:00-11:00

-->

# Singly Linked list Code Challenge

We were asked to start the code for linked lists. To create a linked list, and be cautious of a null list. A way to insert a new node in a linked list, a way to search the linked list for a particular value of a node, and a way to print the linked list.

## Approach and Efficiency

Approach was insterting a node at the beginning therefore keeing this at big O(1) for now. I think the Big O space is O(N) because we keep adding a node.
correct answer: 
it is Big O(1) when inserting at beginning, changes to big O(n) when inserting anywhere aside from beginning because worst case you could have to walk through whole list to add it at end
It is Big O(n) because it walks through all the nodes to print
space is O(1) because we aren't adding any new linkedlist (even if added 3 nodes, its a constant so still O(1) space)

## API

The current APIs of this class are: 
- Insert
- Includes
- Print

## Contributors

Amanda Iverson provided us with starter code

## Solution
![happyCase](../../../assets/CodeChall5Console.JPG)
![testsPass](../../../assets/CodeChall5test.JPG)
