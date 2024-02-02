using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    internal class Program
    {
        /*
         Create a program that reads a matrix from the console. Then find the biggest sum of the 2x2 submatrix and print it to the console.
            On the first line, you will get matrix sizes in format rows, columns.
            On the next rows lines, you will get elements for each column, separated with a comma and a space.
            Print the biggest top-left square, which you find, and the sum of its elements.

         
        Input                      Output
        3, 6                        9 8
        7, 1, 3, 3, 2, 1            7 9
        1, 3, 9, 8, 5, 6            33
        4, 6, 7, 9, 1, 0

         */
        static void Main(string[] args)
        {
            int[,] matrix = ReadMatrixWithCommas();

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] +
                                     matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            PrintSquare(matrix, maxRow, maxCol);
            Console.WriteLine(maxSum);
        }

        public static int[,] ReadMatrixWithCommas()
        {
            string[] sizes = Console.ReadLine().Split(", ");
            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            return matrix;
        }

        public static void PrintSquare(int[,] matrix, int startRow, int startCol)
        {
            for (int row = startRow; row < startRow + 2; row++)
            {
                for (int col = startCol; col < startCol + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
