using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // N: number of elements to push into the stack
            // S: number of elements to pop from the stack
            // X: an element that you should look for in the stack
            int[] n_s_x_numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numOfElementsToPush = n_s_x_numbers[0];
            int numOfElementstoPop = n_s_x_numbers[1];
            int elementToLookFor = n_s_x_numbers[2];

            // Read N elements to push into the stack
            int[] numbersInArray = Console.ReadLine().Split().Take(numOfElementsToPush).Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(numbersInArray);

            // Pop S elements from the stack
            for (int i = 0; i < numOfElementstoPop; i++)
            {
                if (numbers.Count > 0)
                {
                    numbers.Pop();
                }
            }

            // Check if X is in the stack
            if (numbers.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                // Print the smallest element in the stack or 0 if the stack is empty
                Console.WriteLine(numbers.Count > 0 ? numbers.Min().ToString() : "0");
            }
        }
    }
}
