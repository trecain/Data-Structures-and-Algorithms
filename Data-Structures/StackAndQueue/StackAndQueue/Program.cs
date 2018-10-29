using System;
using StackAndQueue.Classes;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ///<summary>
            /// Queues and Stack methods are invoked
            /// </summary>
            Console.WriteLine("Data Structure: Stack and Queue");
            Stack();
            QueueStack();
        }


        /// <summary>
        ///  Creates stack with one node
        /// </summary>
        /// <param name="node"></param>
        /// <returns>The newly created stack</returns>
        public static Stack CreateNewStack()
        {
            Stack newStack = new Stack(new Node(3));
            return newStack;
        }


        /// <summary>
        /// Creates a queue with one node
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static Queue CreateNewQueue()
        {
            Queue createdQueue = new Queue(new Node(9));
            return createdQueue;
        }


        /// <summary>
        /// Adds and pops nodes off the stack and logs them to the console
        /// </summary>
        public static void Stack()
        {
            Stack createdStack = CreateNewStack();

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

        
        /// <summary>
        /// Adds and pops nodes off the queue and logs to the Console
        /// </summary>
        public static void QueueStack()
        {
            Queue createdQueue = CreateNewQueue();
            for (int i = 0; i < 10; i++)
            {
                createdQueue.Enqueue(new Node(i));
                Console.WriteLine($"{i} was Queued");
            }

            for (int j = 0; j < 10; j++)
            {
                Node removedNode = createdQueue.Dequeue();
                Console.WriteLine($"{removedNode.Value} was removed from the Queue");
            }
        }
        
    }
}
