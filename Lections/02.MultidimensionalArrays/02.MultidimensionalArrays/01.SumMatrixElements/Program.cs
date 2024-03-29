﻿using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    /*
     Input                    Output
    3, 6                        3
    7, 1, 3, 3, 2, 1            6
    1, 3, 9, 8, 5, 6            76
    4, 6, 7, 9, 1, 0

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split(", ");
            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);

            int[,] matrix = new int[rows, cols];


            // 1 2 3
            // 2 3 4
            // 4 5 6
            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);

           // PrintMatrix(matrix);
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