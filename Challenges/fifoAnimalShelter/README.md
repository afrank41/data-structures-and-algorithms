# FIFO Animal Shelter

## Challenge
Create an AnimalShelter class that acts as a queue for animals. The class needs an enqueue method that will add a new Animal to the queue and a dequeue method that will remove an Animal from the rear of the animal shelter queue. An Animal class should also be created to serve as a Node to be placed in the AnimalShelter queue. OOP principals should be demonstrated by having derived classes from the Animal class.

## Approach & Efficiency

Enqueue: <br>
1. Big O Time = O(1)
	- This method only needs to add a new animal to the rear of the queue

2. Big O Space = O(1)
	- There isn't any additional memory that needs to be allocated to add a node to the rear

Dequeue:<br>
1. Big O Time = O(n)
	- This method needs to iterate through the queue of animals and only dequeue specific animal types. It also needs to iterate through the queue again to ensure the queue order remains intact.

2. Big O Space = O(1)
	- There isn't any additional memory that needs to be allocated to remove an animal from the queue

## Solution

![Queue With Stacks](../../assets/Challenge12.jpg)

