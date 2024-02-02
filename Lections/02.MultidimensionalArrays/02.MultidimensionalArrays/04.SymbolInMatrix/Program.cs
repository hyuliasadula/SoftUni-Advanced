using System;

namespace _04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            char symbolToFind = char.Parse(Console.ReadLine());

            bool found = false;
            int foundRow = -1;
            int foundCol = -1;


            // Search for the symbol in the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == symbolToFind)
                    {
                        found = true;
                        foundRow = i;
                        foundCol = j;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }
            
            if (found)
            {
                Console.WriteLine($"({foundRow}, {foundCol})");
            }
            else
            {
                Console.WriteLine($"{symbolToFind} does not occur in the matrix");
            }
        }
    }
}