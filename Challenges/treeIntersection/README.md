# Tree Intersection

## Challenge
Create a method called TreeIntersection that takes in two binary trees as input. This method should utilize a hash table to determine if the two input binary trees have any duplicate values between them. After the method determines these duplicate values it should return a list of them.

## Approach & Efficiency
Big O Time = O(n)<br>
- This method needs to hit every node within the first binary tree and add them into a hash table.<br>
- This method needs to hit every node within the second binary tree and compare their values to keys in a hashtable.


Big O Space = O(n)<br>
- This method requires the instantiation of a new hash table and list to be returned.

## Solution

![Tree Intersection](../../assets/Challenge27.jpg)
