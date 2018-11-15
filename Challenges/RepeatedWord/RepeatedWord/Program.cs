using System;
using Hashtables.Classes;

namespace RepeatedWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Coding Challenge: Repeated Word");

            string input = "Humpty dumpty fell off the wall to get off";
            string repeatedWord = RepeatedWord(input);

            Console.WriteLine("The following phrase for repeats");
            Console.WriteLine("=================================");
            Console.WriteLine("Humpty dumpty fell off the wall to get off");
            Console.WriteLine("=================================");

            Console.WriteLine("Reapeated word is: " + repeatedWord);
        }

        public static string RepeatedWord(string input)
        {
            Hashtable ht = new Hashtable(29);

            string[] words = input.Split(' ');

            foreach(string word in words)
            {
                string lowerWord = word.ToLower();
                if (ht.Contains(lowerWord))
                {
                    return lowerWord;
                }
                else
                {
                    ht.Add(lowerWord, word);
                }
            }
            return null;
        }
    }
}
