using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    /*
     {[()]} - This is a balanced parenthesis.
     {[(])} - This is not a balanced parenthesis.

  	 For each test case, print on a new line "YES", if the parentheses are balanced. 
     Otherwise, print "NO". Do not print the quotes.

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();

            bool isBalanced = IsBalancedParentheses(sequence);

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static bool IsBalancedParentheses(string sequence)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char parenthesis in sequence)
            {
                if (parenthesis == '(' || parenthesis == '{' || parenthesis == '[')
                {
                    stack.Push(parenthesis);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false; // Unmatched closing parenthesis
                    }

                    char openParenthesis = stack.Pop();

                    /*
                        If parenthesis is ')' but openParenthesis is not '(', or
                        If parenthesis is '}' but openParenthesis is not '{', or
                        If parenthesis is ']' but openParenthesis is not '['
                     */
                    if ((parenthesis == ')' && openParenthesis != '(') ||
                        (parenthesis == '}' && openParenthesis != '{') ||
                        (parenthesis == ']' && openParenthesis != '['))
                    {
                        return false; // Mismatched closing parenthesis
                    }
                }
            }

            return stack.Count == 0; // The sequence is balanced if the stack is empty
        }
    }
}
