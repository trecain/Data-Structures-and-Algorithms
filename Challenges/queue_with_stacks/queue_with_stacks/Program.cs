using System;
using StackAndQueue.Classes;
using Day06_LinkedList.Classes;

namespace queue_with_stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                QueueWithStacks();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }   
        }

        static void QueueWithStacks()
        {
            Classes.Queue myQueue = new Classes.Queue(new Node(1));
            myQueue.Enqueue(new Node(2));
            myQueue.Enqueue(new Node(3));
            myQueue.Enqueue(new Node(4));
            myQueue.Enqueue(new Node(5));

            Console.WriteLine("====================Stack in Queue=========================");
            Console.WriteLine($"1. Node: {myQueue.Peek().Value}");
            //myQueue.Dequeue();
            Console.WriteLine($"2. Node: {myQueue.Peek().Value}");
            //myQueue.Dequeue();
            Console.WriteLine($"3. Node: {myQueue.Peek().Value}");
            //myQueue.Dequeue();
            Console.WriteLine($"4. Node: {myQueue.Peek().Value}");
            //myQueue.Dequeue();
            Console.WriteLine($"5. Node: {myQueue.Peek().Value}");
            //myQueue.Dequeue();          
        }
    }
}
