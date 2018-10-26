# Implement a Queue with Two Stacks

## Challenge 

Write a method that uses two stacks to imitate a queue.

Methods:
Dequeue - Remove node from queue
Enqueue - Insert node in queue

## Approach and Efficiency
```
	Enqueue:
	- Create two stacks.
	- Add nodes to one of the stacks. 
	- Push all nodes into the empty stack.

	Big O: 
	Enqueue: 
	Time: O(n)
	Space: O(n)
```

```
	Dequeue: 
	- Pop to nodes off the newly populated stack.
	- Peek and nodes that are popped off stack.
	Dequeue: 
	Time: O(1)
	Space: O(1)
```

## Solution
![Queue with Two Stacks whiteboard](https://github.com/trecain/Data-Structures-and-Algorithms/blob/master/assets/queueWithStacks.PNG)
