using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    internal class Program
    {
        /*
         You have an empty sequence and you will be given N queries. Each query is one of these three types:

            1 x – Push the element x into the stack.

            2 – Delete the element present at the top of the stack.

            3 – Print the maximum element in the stack.

            4 – Print the minimum element in the stack.

            After you go through all of the queries, print the stack in the following format:

            "{n}, {n1}, {n2} …, {nn}"


        Input Output

9

1 97

2

1 20

2

1 26

1 20

3

1 91

4
         
         */
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();
            Stack<int> minStack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (query[0])
                {
                    case 1:
                        int x = query[1];
                        stack.Push(x);

                        if (maxStack.Count == 0 || x >= maxStack.Peek())
                        {
                            maxStack.Push(x);
                        }

                        if (minStack.Count == 0 || x <= minStack.Peek())
                        {
                            minStack.Push(x);
                        }
                        break;

                    case 2:
                        if (stack.Count > 0)
                        {
                            int removed = stack.Pop();

                            if (removed == maxStack.Peek())
                            {
                                maxStack.Pop();
                            }

                            if (removed == minStack.Peek())
                            {
                                minStack.Pop();
                            }
                        }
                        break;

                    case 3:
                        if (maxStack.Count > 0)
                        {
                            Console.WriteLine(maxStack.Peek());
                        }
                        break;

                    case 4:
                        if (minStack.Count > 0)
                        {
                            Console.WriteLine(minStack.Peek());
                        }
                        break;
                }
            }

            // Print the stack in the required format
            Console.WriteLine(string.Join(", ", stack.Reverse()));
        }
    }
}