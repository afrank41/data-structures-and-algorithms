# Matching Bracket Validation

## Challenge
Create a method called MatchingBracketValidation that takes in a string and returns a boolean value. The method should return true if there are brackets in your input string that both open and close properly or if there is no brackets in the string at all. The method should return false otherwise. 

## Approach & Efficiency
Big O Time = O(n))<br>
	- This method needs to iterate the length of the input string to check if the use of brackets is valid

Big O Space = O(n)<br>
	- This method instantiates a new stack and nodes within it to keep track of open brackets within the input string

## Solution

![Queue With Stacks](../../assets/Challenge13.jpg)

