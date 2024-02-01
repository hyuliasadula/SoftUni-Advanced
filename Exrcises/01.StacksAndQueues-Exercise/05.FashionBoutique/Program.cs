using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    /*
     Input
    •	On the first line, you will be given a sequence of integers, representing the clothes in the box, separated by a single space.
    •	On the second line, you will be given an integer, representing the capacity of a rack.


    Output
    •	Print the number of racks, needed to hang all of the clothes from the box

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInABox = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> itemsInBoxes = new Stack<int>(clothesInABox);
            int capacityOfARack = int.Parse(Console.ReadLine());

            int racks = 0;
            int currentRackSum = 0;

            while (itemsInBoxes.Count > 0)
            {
                int currentClothing = itemsInBoxes.Pop();

                if (currentRackSum + currentClothing <= capacityOfARack)
                {
                    currentRackSum += currentClothing;
                }
                else
                {
                    racks++;
                    currentRackSum = currentClothing;
                }
            }

            if (currentRackSum > 0)
            {
                racks++;
            }

            Console.WriteLine(racks);
        }
    }
}
