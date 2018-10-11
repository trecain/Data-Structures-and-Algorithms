# Binary Search 

## Challenge 
Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. 
Without utilizing any of the built-in methods available to your language, return the index of the array’s 
element that is equal to the search key, or -1 if the element does not exist.

To create a BinarySearch function that takes in two parameters.  Parameter one is a sorted array, and parameter two is the
search key that you want to find the index for in the array.  This challenge is to be done without using any of the built-in 
methods of an array.  When the searchkey value is found the program should return the index of the array or -1 if vice versa.

## Approach and Efficiency

- Time: O(log n)
- Space: O(1)

I will create a method that takes in a sorted array and target integer to get the index from.  When the target integer is found
the index of the value will be returned.  If the targeted value is never found then a negative one will be returned.  This will
be made possible by reducting the size of the array by the middle value.
## Solution
![binary search whiteboard](https://github.com/trecain/Data-Structures-and-Algorithms/blob/master/assets/wb02.jpg.jpeg)
