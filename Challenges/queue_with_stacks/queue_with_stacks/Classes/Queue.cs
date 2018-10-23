using System;
using System.Collections.Generic;
using System.Text;
using StackAndQueue.Classes;
using Day06_LinkedList.Classes;

namespace queue_with_stacks.Classes
{
    class Queue
    {
        private Stack stackNewestOnTop { get; set; }
        private Stack stackOldestOnTop { get; set; }
   
       public void Enqueue (Node node)
        {
            stackNewestOnTop.Push(node);
        }

        public Queue(Node node)
        {
            stackNewestOnTop = new Stack(node);
            stackOldestOnTop = new Stack(node);
            stackOldestOnTop.Pop();
        }

        public Node Peek()
        {
            return stackNewestOnTop.View();
        }

        private void shiftStacks()
        {
            if (stackOldestOnTop. 0)
            {

            }
        }
    }
}
