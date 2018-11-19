# Hash Table

## Description/Challenge
Implement a hash table . The hash table should have a GetHash, Add, Find, and Contains method. The GetHash method will take in a key and hash it to return the index a new node will be placed in your hash table. The Add method will add a new node to the hash table utilizing the GetHash method. The Find method will search the hash table and return a value associated with the input key. The Contains table will utilize the Find method to return a boolean whether or not a key was found inside the hash table.

## Hash Table Methods

1. GetHash(string key)
    * This method hashes the given key and returns the hash divided by the size of the hash table to return an index of that table.

2. Add(string key, object value)
    * This method adds a new node to the hash table at the hashed index of the key given.

3. Find(string key)
    * This method searches a hash table for the given key and returns the value associated with that key.

4. Contains(string key)
    * This method utilizes the find method. If the key is found it will return true, otherwise if the key is not found it returns false.

## Visual Example Of Hash Table Methods
![](assets/hashTable.PNG)
