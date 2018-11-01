using System;
using StackAndQueue.Classes;

namespace multi_bracket_validation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coding Challenge: Multi-Bracket Validation");
            Console.WriteLine("{{{{}}}} {0}", MultiBracketValidation("{}"));
            Console.WriteLine("{{}}(){{}} {0}", MultiBracketValidation("{}(){}"));
            Console.WriteLine("()[[E,g,e,g] {0}", MultiBracketValidation("()[[E,g,e,g]"));
            Console.WriteLine("(){{}}[[]] {0}", MultiBracketValidation("(){}[[]]"));
            Console.WriteLine("[({{}}] {0}", MultiBracketValidation("[({}]"));
            Console.WriteLine("(]( {0}", MultiBracketValidation("(]("));
            Console.WriteLine("{{(}}) {0}", MultiBracketValidation("{(})"));
        }


        /// <summary>
        /// performs a multi level bracket validation
        /// takes in a string and checks for three specific brakcets
        /// </summary>
        /// <param name="inputedString"></param>
        /// <returns></returns>
        public static bool MultiBracketValidation(string inputedString)
        {
            ///<summary>
            /// creates new stack and pops node off to empty
            /// </summary>
            Stack stack = new Stack(new Node("node to remove"));
            stack.Pop();

            foreach(char character in inputedString)
            {
                if ("[]{}()".Contains(character))
                {
                    if (character == '[' || character == '{' || character == '(')
                    {
                        stack.Push(new Node(character));
                    }
                    else
                    {
                        if (((char)stack.Pop().Value) != BracketPair(character))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }


        /// <summary>
        /// validates that a specific bracket is used and returns the pain
        /// </summary>
        /// <param name="character"></param>
        /// <returns>Returns the paired bracket</returns>
        public static char BracketPair(char character)
        {
            if (character == '[')
                return ']';
            if (character == ']')
                return '[';
            if (character == '{')
                return '}';
            if (character == '}')
                return '{';
            if (character == '(')
                return ')';
            if (character == ')')
                return '(';
            else
                return ' ';
        }
    }
}
