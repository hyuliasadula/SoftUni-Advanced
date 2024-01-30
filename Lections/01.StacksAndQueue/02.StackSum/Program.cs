using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    internal class Program
    {
        /*
         Create a program that:

        · Reads an input of integer numbers and adds them to a stack.

        · Reads and executes commands until "end" is received.

        · Process the following commands:

        o Add <n1> <n2>: pushes two numbers into the stack

        o Remove <n>: removes the n elements from the stack or does nothing if the stack holds fewer than n elements.

        · Prints the sum of the remaining elements of the stack.

        
        · Commands are case-insensitive, which means that “Add”, “add” and “aDD” are the same command.

        · A single space is used as a separator between commands and numbers.
         */
        static void Main(string[] args)
        {
            
            //· On the first line, you will receive an array of integers (space-separated).
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);

            string command = Console.ReadLine().ToLower();


            /*
             · On the next lines, until the "end" command is given, you will receive commands – a single command and one or two numbers after the command, depending on what command you are given.
             */
            while (command != "end")
            {
                var tokens = command.Split();
                var commandType = tokens[0].ToLower();


                /*
                 o If the command is "add", you will always be given exactly two numbers after the command, which you need to add to the stack.
                 */
                if (commandType == "add")
                {
                    int num1 = int.Parse(tokens[1]);
                    int num2 = int.Parse(tokens[2]);
                    stack.Push(num1);
                    stack.Push(num2);
                }


                /* o If the command is "remove", you will always be given exactly one number after the command, which represents the count of the numbers you need to remove from the stack. If there are not enough elements, skip the command.*/
                else if (commandType == "remove")
                {
                    var countOfRemovedNums = int.Parse(tokens[1]);
                    if (countOfRemovedNums <= stack.Count)
                    {
                        for (int i = 0; i < countOfRemovedNums; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
