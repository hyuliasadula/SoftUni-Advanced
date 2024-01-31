using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInABox = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> itemsInBoxes = new Stack<int>(clothesInABox);
            int capacityOfARack = int.Parse(Console.ReadLine());

        }
    }
}
