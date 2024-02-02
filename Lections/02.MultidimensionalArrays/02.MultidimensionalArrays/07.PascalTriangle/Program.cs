using System;

namespace _07.PascalTriangle
{
    // 66 / 100 on judge

    /*
     * The Pascal’s triangle may be constructed in the following manner: in row 0 (the topmost row), there is a unique nonzero entry 1. Each entry of each subsequent row is constructed by adding the number above and to the left with the number above and to the right, treating blank entries as 0:
     * 
     Input	Output
        4	1 
            1 1 
            1 2 1 
            1 3 3 1

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            PrintPascalsTriangle(rows);
        }

        static void PrintPascalsTriangle(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                int number = 1;

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number = number * (i - j) / (j + 1);
                }

                Console.WriteLine();
            }
        }
    }
}
