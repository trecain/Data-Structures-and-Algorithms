using System;
using StackAndQueue.Classes;
using Day06_LinkedList.Classes;

namespace queue_with_stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Queue q = new Queue(new Node(10));
            q.addsNodeToEndOfTheQueue(new Node(15));
            q.addsNodeToEndOfTheQueue(new Node(20));
            q.addsNodeToEndOfTheQueue(new Node(5));

            Console.WriteLine("Last node added");
            Console.WriteLine(q.RemovesNodeFromFrontOfTheQueue().Value);
            Console.WriteLine(q.RemovesNodeFromFrontOfTheQueue().Value);
            Console.WriteLine(q.RemovesNodeFromFrontOfTheQueue().Value);
            Console.WriteLine(q.RemovesNodeFromFrontOfTheQueue().Value);

        }
    }
}
