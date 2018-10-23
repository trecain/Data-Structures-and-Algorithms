using System;
using Day06_LinkedList.Classes;

namespace Day07_LinkedList_Kth
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to my coding challenge.");
            
                LList list = new LList(new Node(1));
                list.Add(new Node(3));
                list.Add(new Node(8));
                list.Add(new Node(2));

                list.Print();

                Console.WriteLine("Second element from the end is " + ReturnKthToLastNode(list, 6).Value);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
        
        //Looks through link list and returns kth element from the end of the list
        public static Node ReturnKthToLastNode(LList list, int k)
        {
            try
            {
                // if kth value is zero add 1 to get the value of the node next to null
                if (k == 0)
                {
                    k++;
                }

                Node currentNode = list.Head;
                Node followingNode = list.Head;

                //Iterate throuh ll by k value.  If reach end of list it's shorter than k.
                for (int i = 0; i < k; i++)
                {
                    if (currentNode == null) return null;
                    currentNode = currentNode.Next;
                }

                //If length is equal to n then the nth value is null
                if (currentNode == null) return null; 

                //move both nodes forward until current node hits the end and is points to null.
                while (currentNode != null)
                {
                    currentNode = currentNode.Next;
                    followingNode = followingNode.Next;
                }
                //return the following node.
                return followingNode;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
