using System;
using StackAndQueue.Classes;
using queuesWithStacks.Classes;
using Day06_LinkedList.Classes;


namespace queuesWithStacks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lab 11: Queue with stacks");
            Queued();
        }

        static void Queued()
        {
            Classes.Queue queue = new Classes.Queue(new Node(1));
            queue.Enqueue(new Node(2));
            queue.Enqueue(new Node(3));
            queue.Enqueue(new Node(4));

            Console.WriteLine("================= Queue ================");
            Console.WriteLine($"Node dequeued: {queue.Dequeue().Value}");
            Console.WriteLine($"Node dequeued: {queue.Dequeue().Value}");
            Console.WriteLine($"Node dequeued: {queue.Dequeue().Value}");
            Console.WriteLine($"Node dequeued: {queue.Dequeue().Value}");
        }
    }
}
