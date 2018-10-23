# Queue With Stacks

## Challenge
Create a new Queue class that has two properties that hold two stacks. The class needs an enqueue method that will add a new node to the queue and a dequeue method that will remove a node from the bottom of a stack. This class should effectively use the two stacks to create a qeueue.

## Approach & Efficiency

Enqueue: <br>
1. Big O Time = O(1)
	- This method only needs to push a new node to the top of a stack

2. Big O Space = O(1)
	- There isn't any additional memory that needs to be allocated to push a node to the top of a stack

Dequeue:<br>
1. Big O Time = O(n)
	- This method needs to iterate through each node in a stack to pop them off the stack and push them into an empty stack

2. Big O Space = O(1)
	- There isn't any additional memory that needs to be allocated to pop and push nodes into a stack

## Solution

![Queue With Stacks](../../assets/Challenge11.jpg)

