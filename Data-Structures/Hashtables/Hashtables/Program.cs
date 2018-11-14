using System;
using System.Collections.Generic;
using Hashtables.Classes;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I will attempt to save a list of the top ten NBA players currently in the 2018 season");
            Hashtable hashtable = new Hashtable(10);
            // Adding players
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("=================== Loading Players... =====================");
            hashtable.Add("Lebron", "James");
            hashtable.Add("Kevin", "Durant");
            hashtable.Add("Damian", "Lillard");
            hashtable.Add("Joel", "Embiid");
            hashtable.Add("Kawhi", "Leonard");
            hashtable.Add("Russell", "Westbrook");
            hashtable.Add("Anthony", "Davis");
            hashtable.Add("Giannis", "Antetokounmpo");
            hashtable.Add("James", "Harden");
            hashtable.Add("Stephen", "Curry");

            Console.WriteLine("=================== Lets Force A Collision =================");
            hashtable.Add("Russell", "Westbrook");
            hashtable.Add("Anthony", "Davis");
            hashtable.Add("Giannis", "Antetokounmpo");
            hashtable.Add("James", "Harden");
            hashtable.Add("Stephen", "Curry");

            Console.WriteLine("=================== Top 10 NBA Players In No Particular Order =================");
            List<string> players = new List<string>();
            players.Add("Lebron");
            players.Add("Kevin");
            players.Add("Damian");
            players.Add("Joel");
            players.Add("Kawhi");
            players.Add("Russell");
            players.Add("Anthony");
            players.Add("Giannis");
            players.Add("James");
            players.Add("Stephen");

            int index = 1;
            foreach (string player in players)
            {
                Console.WriteLine("Dun dun duuuun!!!");
                Console.WriteLine("");
                Console.WriteLine($"Baller {index}: {player}, {hashtable.Find(player)}");
                Console.WriteLine("");
                index++;
            }
        }
       
    }
}
