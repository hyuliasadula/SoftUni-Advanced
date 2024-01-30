using System;
using System.Collections.Generic;

namespace _01.ReverseAString
{
    internal class Program
    {
        /*
                 Input                   Output

                 I Love C#               #C evoL I

                 Stacks and Queues       seueuQ dna skcatS*/
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> newStack = new Stack<char>();

            // Each character is Pushed onto the stack
            foreach (var item in input)
            {
                newStack.Push(item);
            }

            // Pop and print each character LIFO
            while (newStack.Count > 0)
            {
                Console.Write(newStack.Pop());
            }

            Console.WriteLine();

        }
    }
}
