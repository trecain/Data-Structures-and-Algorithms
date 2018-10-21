using System;
using Day06_LinkedList.Classes;

namespace MergeLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
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
                Console.WriteLine("Linked List One: ", firstList.Print());

                /// <summary>
                /// Creates the second linked list to be merged.
                /// </summary>
                LList secondList = new LList(new Node(3));
                secondList.Add(new Node(2));
                secondList.Add(new Node(4));
                Console.WriteLine("Linked List Two: ", secondList.Print());
                /// <summary>
                /// Invokes the Merge methodo on the two list.
                /// </summary>
                LList zipperMerged = new LList(MergeLinkedList(firstList, secondList));
                zipperMerged.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }


        public static Node MergeLinkedList(LList firstList, LList secondList)
        {
            try
            {
                /// <summary>
                /// set the current node to traverse through to the first node in the linkedlist
                /// </summary>
                firstList.Current = firstList.Head;
                secondList.Current = secondList.Head;

                Node firstListNext = null;
                Node secondListNext = null;
                /// <summary>
                /// Make sure both list aren't at the end of the list
                /// link through setting point next of first to current prop of second.
                /// </summary>
                while (firstList.Current.Next != null && secondList.Current.Next != null)
                {
                    firstListNext = firstList.Current.Next;
                    secondListNext = secondList.Current.Next;

                    firstList.Current.Next = secondList.Current;
                    secondList.Current.Next = firstListNext;

                    firstList.Current = firstListNext;
                    secondList.Current = secondListNext;
                }

                // check to see if we're at the end of the first linked list
                if (firstList.Current.Next == null)
                {
                    firstList.Current.Next = secondList.Current;
                }
                // check to see if we're at the end of the second linked list
                else if (secondList.Current.Next == null)
                {
                    secondList.Current.Next = firstList.Current.Next;
                    firstList.Current.Next = secondList.Current;
                }
                return firstList.Head;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
