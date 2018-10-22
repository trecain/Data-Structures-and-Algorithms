using System;
using Day06_LinkedList.Classes;

namespace ReversedLL
{
    class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine($"Initial Linked List Order: {linkedList.Print()}");


        }
    }
}
