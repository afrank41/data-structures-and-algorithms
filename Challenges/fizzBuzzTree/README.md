# FizzBuzz Tree

## Challenge
Create a method called FizzBuzzTree that takes in a root node from a binary tree and returns a list of strings full of FizzBuzzes. If the node's value is divisible by 5 and 3 add "FizzBuzz" to the list, if it is divisible 3 add "Fizz", if it is divisible by 5 add "Buzz".

## Approach & Efficiency
Big O Time = O(n)<br>
	- This method needs to hit every node within a binary tree to check values and add the string to a list.

Big O Space = O(h)<br>
	- This method utilizes a preorder binary tree method that traverses our binary tree recursively for the height of the tree.

## Solution

![FizzBuzz Tree Output](../../assets/Challenge16.jpg)
