using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    internal class Program
    {
        /*
         Input         Output
        3, 6            12
        7 1 3 3 2 1     10
        1 3 9 8 5 6     19
        4 6 7 9 1 0     20
                        8
                        7

         
         */
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split(", ");
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

            //Sum by cols
            for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);
            }

            //PrintMatrix(matrix);
        }


        //IF WE WANT TO PRINT THE MATRIX

        //public static void PrintMatrix(int[,] matrix)
        //{
        //    Console.WriteLine("Printing matrix: ");
        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < matrix.GetLength(1); col++)
        //        {
        //            Console.Write(matrix[row, col] + " ");
        //        }

        //        Console.WriteLine();
        //    }
        //}
    }
}