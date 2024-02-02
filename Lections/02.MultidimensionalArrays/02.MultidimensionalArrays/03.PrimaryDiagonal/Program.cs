using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    internal class Program
    {
        /* Sum of elements from the matrix’s primary diagonal
         * 
         1 2 3   => 1 + 5 + 9 = 15
         4 5 6
         7 8 9
         */
        static void Main(string[] args)
        {
            int sizeOfSquareMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeOfSquareMatrix, sizeOfSquareMatrix];

            for (int row = 0; row < sizeOfSquareMatrix; row++)
            {
                int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < sizeOfSquareMatrix; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            int sum = CalculatePrimaryDiagonalSum(matrix, sizeOfSquareMatrix);
            Console.WriteLine(sum);
        }

        static int CalculatePrimaryDiagonalSum(int[,] matrix, int sizeOfSquareMatrix)
        {
            int sum = 0;

            for (int i = 0; i < sizeOfSquareMatrix; i++)
            {
                sum += matrix[i, i];
            }

            return sum;
        }
    }
}
