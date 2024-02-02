using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    internal class Program
    {
        /*
         Create a program that reads a matrix from the console. On the first line, you will get matrix rows. On the next rows lines, you will get elements for each column separated with space. You will be receiving commands in the following format:
        •	Add {row} {col} {value} – Increase the number at the given coordinates with the value.
        •	Subtract {row} {col} {value} – Decrease the number at the given coordinates by the value.
        Coordinates might be invalid. In this case, you should print "Invalid coordinates". When you receive "END" 

        Input               Output
        3                   Invalid coordinates
        1 2 3               6 2 3
        4 5 6 7             4 5 4 7
        8 9 10              8 9 10
        Add 0 0 5
        Subtract 1 2 2
        Subtract 1 4 7
        END


         
         */
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, rows];
            for (int i = 0; i < rows; i++)
            {
                int[] rowValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < rows; j++)
                {
                    matrix[i, j] = rowValues[j];
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandArgs = command.Split(' ');

                if (commandArgs[0] == "Add" || commandArgs[0] == "Subtract")
                {
                    int row = int.Parse(commandArgs[1]);
                    int col = int.Parse(commandArgs[2]);
                    int value = int.Parse(commandArgs[3]);

                    if (IsValidCoordinates(matrix, row, col))
                    {
                        ProcessCommand(matrix, row, col, value, commandArgs[0]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }

            PrintMatrix(matrix);
        }

        static void ProcessCommand(int[,] matrix, int row, int col, int value, string operation)
        {
            if (operation == "Add")
            {
                matrix[row, col] += value;
            }
            else if (operation == "Subtract")
            {
                matrix[row, col] -= value;
            }
        }

        static bool IsValidCoordinates(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
