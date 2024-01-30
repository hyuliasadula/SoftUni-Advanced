using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        /*
         Create a simple calculator that can evaluate simple expressions with only addition and subtraction. There will not be any parentheses. Numbers and operations are space-separated.

        Solve the problem using a Stack.
        2 + 5 + 10 - 2 - 1 -> 14
         */
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            Stack<string> expression = new Stack<string>(new Stack<string>(input));


            while (expression.Count > 1)
            {
                int leftNumber = int.Parse(expression.Pop());
                string sign = expression.Pop();
                int rightNumber = int.Parse(expression.Pop());

                if (sign == "+")
                {
                    expression.Push((leftNumber + rightNumber).ToString());
                }
                else if (sign == "-")
                {
                    expression.Push((leftNumber - rightNumber).ToString());
                }
            }

            Console.WriteLine(expression.Pop());
        }
    }
}