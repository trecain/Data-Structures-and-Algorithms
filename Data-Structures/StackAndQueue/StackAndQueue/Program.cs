using System;
using Day06_LinkedList.Classes;
using StackAndQueue.Classes;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ///<summary>
            ///
            /// </summary>
            Console.WriteLine("Data Structure: Stack and Queue");
            Stack();
            QueueStack();
        }

        public static Stack CreateNewStack(Node node)
        {
            Stack newStack = new Stack(new Node(3));
            return newStack;
        }

        public static Queue CreateNewQueue(Node node)
        {
            Queue createdQueue = new Queue(new Node(9));
            return createdQueue;
        }


        public static void Stack()
        {
            Stack createdStack = CreateNewStack(new Node(4));

            for (int i = 0; i < 10; i++)
            {
                createdStack.Push(new Node(i));
                Console.WriteLine($"{i} was pushed to the stack");
            }

            for (int j = 0; j < 10; j++)
            {
                Node poppedNode = createdStack.Pop();
                Console.WriteLine($"{poppedNode.Value} was popped from the stack");
            }
        }


        public static void QueueStack()
        {
            Queue createdQueue = CreateNewQueue(new Node(8));
            for (int i = 0; i < 10; i++)
            {
                createdQueue.addsNodeToEndOfTheQueue(new Node(i));
                Console.WriteLine($"{i} was Queued");
            }

            for (int j = 0; j < 10; j++)
            {
                Node removedNode = createdQueue.RemovesNodeFromFrontOfTheQueue();
                Console.WriteLine($"{removedNode.Value} was removed from the Queue");
            }
        }
        
    }
}
