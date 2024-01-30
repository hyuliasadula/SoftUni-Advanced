using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

namespace _06.Supermarket
{
    internal class Program
    {
        /*
         You are given a sequence of input strings, each staying on a separate line. Each input string holds either a customer name, or the command “Paid” or the command “End”. Your task is to read and process the input:

· When you receive a customer name, add it to the queue.

· When you receive the "Paid" command, print the customer names from the queue (each at separate line), then empty the queue.

· When you receive the "End" command, print the count of the remaining customers from the queue in the format: "{count} people remaining." and stop processing the commands (see the examples below).


         Input                Output

        Liam
        Noah                Liam
        James               Noah
        Paid                James
        Oliver              4 people remaining.
        Lucas
        Logan
        Tiana
        End                
         */
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToLower();
            Queue<string> customers = new Queue<string>();

            while (command != "end")
            {
                if (command == "paid")
                {
                    while (customers.Count > 0)
                    {
                        string customerName = customers.Dequeue();
                        string capitalized = CapitalizeFirstLetter(customerName);
                        Console.WriteLine(capitalized);
                    }
                }
                else
                {
                    customers.Enqueue(command);
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
        static string CapitalizeFirstLetter(string input)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(input);
        }
    }
}
   