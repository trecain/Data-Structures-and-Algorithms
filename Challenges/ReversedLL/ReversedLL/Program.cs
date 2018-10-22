using System;
using Day06_LinkedList.Classes;

namespace ReversedLL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Coding Challenge: Reversed Linked List");

            ///<summary>
            /// Uses add function to create the nodes in the Linked List
            /// </summary>
            LList linkedList = new LList(new Node(3));
            linkedList.Add(new Node(9));
            linkedList.Add(new Node(4));
            linkedList.Add(new Node(2));

            ///<summary>
            /// Show the linked list before the reversal and one after.
            /// </summary>
            Console.WriteLine($"Pre Linked List Order:");
            linkedList.Print();

            Console.WriteLine($"Post Linked List Order:");
            LList reversedLinkedList = ReverseLL(linkedList);
            reversedLinkedList.Print();
        }


        /// <summary>
        /// setting the current and last node pointers in order to reverse the order of the linked list
        /// </summary>
        /// <param name="linkedList"></param>
        /// <returns></returns>
        public static LList ReverseLL( LList linkedList)
        {
            Node lastNode = null;
            Node currentNode = linkedList.Head;

            while (currentNode != null)
            {
                Node currentNodeNext = currentNode.Next;
                currentNode.Next = lastNode;
                lastNode = currentNode;
                currentNode = currentNodeNext;
            }
            linkedList.Head = lastNode;
            return linkedList;
        }
    }
}
