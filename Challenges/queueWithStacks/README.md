# Merge Linked Lists

## Challenge
Write a method that takes in two linked lists and returns the head of a merged linked list. The method should merge the two linked lists as if they are being zippered together. After "zippering" the linked lists, return the head of the merged linked list to be a reference. <br> 
Ex. (LL1.Head) --> (LL2.Head) --> (LL1.Node1) --> (LL2.Node1) --> (LL1.Node2) --> (LL2.Node2) --> NULL

## Approach & Efficiency

1. Big O Time = O(n)
	- This solution traverses a linked list to zipper nodes inside it

2. Big O Space = O(1)
	- This solution does not need to allocate more memory such as instantiating a new linked list to function

## Solution

![Nth Node From End](../../assets/Challenge6.jpg)

