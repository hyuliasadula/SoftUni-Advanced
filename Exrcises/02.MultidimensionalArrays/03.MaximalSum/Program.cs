using System;
using System.Linq;

namespace _03.MaximalSum
{
    //      60/100
    internal class Program
    {
        /*
         Create a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has a maximal sum of its elements.

        Input
        · On the first line, you will receive the rows N and columns M. On the next N lines, you will receive each row with its columns.

        Output
        · Print the elements of the 3 x 3 square as a matrix, along with their sum.

        Examples

        Input                        Output

        4 5                         Sum = 14
        1 5 5 2 4                   1 4 14
        2 1 4 14 3                  7 11 2
        3 7 11 2 8                  8 12 16
        4 8 12 16 4


         */
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split(" ");
            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            // Find the 3x3 square with maximal sum
            int maxSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row <= rows - 3; row++)
            {
                for (int col = 0; col <= cols - 3; col++)
                {
                    int sum = CalculateSum(matrix, row, col);
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            // Print the 3x3 square with maximal sum
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static int CalculateSum(int[,] matrix, int startRow, int startCol)
        {
            int sum = 0;
            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {
                    sum += matrix[row, col];
                }
            }
            return sum;
        }
    }
}
