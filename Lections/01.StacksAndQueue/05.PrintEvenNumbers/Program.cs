using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        /*
         Create a program that:

            · Reads an array of integers and adds them to a queue.

            · Prints the even numbers separated by ", ".

            Examples

            Input                                Output

            1 2 3 4 5 6                         2, 4, 6

            11 13 18 95 2 112 81 46             18, 2, 112, 46

            Hints

            · Parse the input and enqueue all the numbers in a Queue<int>.

            · Dequeue the elements one by one and print all even values.
         */
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);

            bool firstEvenPrinted = false;

            foreach (var item in queue)
            {
                if (item % 2 == 0)
                {
                    // Print a comma and space before the number (except for the first even number)
                    if (firstEvenPrinted)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(item);

                    firstEvenPrinted = true;
                }
            }

            Console.WriteLine(); 
        }
    }
}
