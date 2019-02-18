# Hashtables
Hashtables are called dictionaries in C#, and what it does is that it will take in a key and do some calculation that will give it a consistent index number to store the key and value.

## Challenge
We were asked to create a hashtable class that can add, delete, read, and contain.

## Approach & Efficiency
I chose to create a new node class, and linked list class that could take in a key and value. 
Once I had those then I created a hashtable class that created an array of key value node linked lists.
The time Big O to add/look up is a Big O(1) for this particular case because I only hash or look up one. (look up just goes to the index instead of iterate through the array looking for it, that is why it is O(1). However it would be Big O(n) if I had an array or list of items to hash because it would need to iterate through all of them to add them. 
The space Big O is O(1) because at worst I would be adding a node when there is a collision.

## API
The avaliable methods for HashTable are:
- AddToHashTable, which takes in a key and value, and hashes the key, then adds the key and value pair to the table, handling collisions as needed.
- GetFromHashTable,  takes in the key and returns the value from the table.
- HashTableContain, takes in the key and returns a boolean, indicating if the key exists in the table already.
- Hash, takes in a key, and returns an index number.
