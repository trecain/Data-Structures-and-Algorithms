using System;
using Day06_LinkedList.Classes;

namespace Day06_LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(7);
            Node node2 = new Node("turtle");

            LList myAwesomeList = new LList(node1);
            myAwesomeList.Append(node2);

            myAwesomeList.Print();

        }
    }
}