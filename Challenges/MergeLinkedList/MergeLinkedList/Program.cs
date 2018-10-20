using System;
using Day06_LinkedList.Classes;

namespace MergeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Where everything gets ran.
            /// </summary>
            /// <param name="args">Main method arguments</param>
            Console.WriteLine("Linked List Meged Zipper Style");

            /// <summary>
            /// Creates the first linked list to be merged.
            /// </summary>
            LList firstList = new LList(new Node(9));
            firstList.Add(new Node(8));
            firstList.Add(new Node(5));

            /// <summary>
            /// Creates the second linked list to be merged.
            /// </summary>
            LList secondList = new LList(new Node(3));
            secondList.Add(new Node(2));
            secondList.Add(new Node(4));

            /// <summary>
            /// Invokes the Merge methodo on the two list.
            /// </summary>
            LList zipperMerged = new LList(MergeLinkedList(firstList, secondList));
            zipperMerged.Print();
        }

        public static Node MergeLinkedList(LList firstList, LList secondList)
        {
            firstList.Current = firstList.Head;
            secondList.Current = secondList.Head;

            Node firstListNext = null;
            Node secondListNext = null; 
        }
    }
}
