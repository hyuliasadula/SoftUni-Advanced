using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    internal class Program
    {
        /* Sum of elements from the matrix’s primary diagonal
         * 
        Input       Output          Comment
        3           15              Primary diagonal: sum = 11 + 5 + (-12) = 4
        11 2 4                      Secondary diagonal: sum = 4 + 5 + 10 = 19
        4 5 6                       Difference: |4 - 19| = 15
        10 8 -12
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

            int primaryResult = CalculatePrimaryDiagonalSum(matrix, sizeOfSquareMatrix);
            int secondaryResult = CalculateSecondaryDiagonalSum(matrix, sizeOfSquareMatrix);

            int absoluteDifference = Math.Abs(primaryResult - secondaryResult);

            Console.WriteLine(absoluteDifference);
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

        static int CalculateSecondaryDiagonalSum(int[,] matrix, int sizeOfSquareMatrix)
        {
            int sum = 0;

            for (int i = 0; i < sizeOfSquareMatrix; i++)
            {
                sum += matrix[i, sizeOfSquareMatrix - 1 - i];
            }

            return sum;
        }
    }
}
