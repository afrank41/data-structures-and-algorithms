# Repeated Word

## Challenge
Create a method called RepeatedWord that takes in a long string as input. This method should utilize a hash table to determine if any words in the input string are repeated. After the method determines the first repeated word it should return that word as a string.

## Approach & Efficiency
Big O Time = O(n)<br>
- This method needs to iterate over an array of strings to check if the strings exist in a hash table and add them to the hash table if they do not exist.

Big O Space = O(n)<br>
- This method requires the instantiation of a new hash table and a string array.

## Solution
![Tree Intersection](../../assets/Challenge28.jpg)
