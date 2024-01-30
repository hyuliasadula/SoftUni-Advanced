using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    internal class Program
    {
        /*
         We are given an arithmetic expression with brackets. Scan through the string and extract each sub-expression.

        Print the result back at the terminal.
        1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5

        output
        (2 + 3) 
        (3 + 1) 
        (2 - (2 + 3) * 4 / (3 + 1))
         */
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<int> bracketIndexes = new Stack<int>();
            

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    bracketIndexes.Push(i);
                }

                if (input[i] == ')')
                {
                    int startIndex = bracketIndexes.Pop();
                    Console.WriteLine(input.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}