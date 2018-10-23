using System;
using StackAndQueue.Classes;
using Day06_LinkedList.Classes;

namespace queue_with_stacks
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void QueueWithStacks()
        {
            Queue queue = new Queue(new Node(9));
            queue.Enqueue(new Node(9));
            queue.Enqueue(new Node(8));
            queue.Enqueue(new Node(7));
            queue.Enqueue(new Node(6));

            Console.WriteLine("que " + queue.View());
        }
      
    }
}
