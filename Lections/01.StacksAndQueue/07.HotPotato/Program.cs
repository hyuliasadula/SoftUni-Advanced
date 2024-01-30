using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.HotPotato
{
    /*
     Hot potato is a game in which children form a circle and start passing a hot potato. The counting starts with the first kid. Every nth toss the child left with the potato leaves the game. When a kid leaves the game, it passes the potato along to its next neighbor. This continues until there is only one kid left.


    input                               output
    Alva James William              Removed Jame
    2                               Removed Alva
                                    Last is William
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            Queue<string> potatoQueue = new Queue<string>(children);

            int potatoTosses = 0;

            while (potatoQueue.Count > 1)
            {
                potatoTosses++;

                string kid = potatoQueue.Dequeue();
                if (potatoTosses == n)
                {
                    potatoTosses = 0;
                    Console.WriteLine("Removed " + kid);
                }
                else
                {
                    potatoQueue.Enqueue(kid);
                }
            }

            Console.WriteLine("Last is " + potatoQueue.Dequeue());
        }
    }
}