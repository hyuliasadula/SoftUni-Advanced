using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    /*
     First, you will be given the quantity of the food that you have for the day (an integer number).  Next, you will be given a sequence of integers, each representing the quantity of order. Keep the orders in a queue. Find the biggest order and print it. You will begin servicing your clients from the first one that came. Before each order, check if you have enough food left to complete it. If you have, remove the order from the queue and reduce the amount of food you have. If you succeeded in servicing all of your clients, print: 
        "Orders complete".
         If not – print:
        "Orders left: {order1} {order2} .... {orderN}".

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfTheFood = int.Parse(Console.ReadLine());
            int[] quantityOfOrder = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(quantityOfOrder);
            int biggestOrder = orders.Max();
            Console.WriteLine(biggestOrder);

            while (orders.Count > 0)
            {
                int currentOrder = orders.Peek(); 
                if (quantityOfTheFood >= currentOrder)
                {
                    quantityOfTheFood -= currentOrder;
                    orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    break;
                }
                
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            
           
        }
    }
}
