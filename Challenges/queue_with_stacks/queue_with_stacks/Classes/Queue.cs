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

        public Node Peek()
        {
            shiftStacks();
            return stackOldestOnTop.View();
        }

        private void shiftStacks()
        {
            if (stackOldestOnTop.TopNode == null)
            {
                while (stackNewestOnTop.TopNode != null)
                {
                    stackOldestOnTop.Push(stackOldestOnTop.Pop());
                }
            }
        }

        public Node Dequeue()
        {
            shiftStacks();
            return stackOldestOnTop.Pop();
        }
    }
}
