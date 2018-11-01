# Trees

## Challenge 
My implementation of a linked list.  The methods that are implemented are add, print, append, addbefore, and addafter. 

## Space/Time

### Binary Tree: PreOrder, InOrder, PostOrder
```
	Time: O(n) - Iterating through each nodes time is dependent on the amount of nodes in the tree.
	Space: O(n) - New nodes aren't created, just a list win N number of elements.

```
### Binary Search Tree Add Method
```
	Time: O(log n) - You have to cut the tree in halves to make comparisons.
	Space: O(1) - Nothing new is created, a new element is added to the tree.
```

### Binary Search Tree Search Method
```
	Time: O(1) - Tree is divided in half to compare.
	Space: O(1) - An element is added and not created.
```

## Implementation 
The console application was implemented with the use of a node class that has a left and right property that points to null or the next node in the tree.

## Uses
A binary search tree can be used for keeping data sorted in a efficient and limited time consuming manner.

## Visual
![](https://github.com/trecain/Data-Structures-and-Algorithms/blob/master/assets/bst.PNG)

