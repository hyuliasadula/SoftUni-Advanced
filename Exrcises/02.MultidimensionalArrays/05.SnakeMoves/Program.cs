using System;

namespace _05.SnakeMoves
{
    internal class Program
    {

        /*
         
        Certainly! Here's a condensed and neater version of the problem description:

        Snake's Path Visualization

        You're in a park encountering a snake! As you run zig-zag, the snake follows. Your task is to visualize the snake's path in a square matrix. The snake, represented by a string, starts from the top-left corner and slithers down, filling each cell with its symbols. If the snake's length is shorter than the stairs, it wraps around.

        Input:

        Two lines from the console:
        Dimensions of the stairs: "N M" (N rows, M columns)
        The snake string


        Output:

        N lines representing each row of the matrix
        Constraints:

        Matrix dimensions: N, M ∈ [1, 12]
        Snake string length: ∈ [1, 20]

       Input             Output
        
        5 6             SoftUn 
        SoftUni         UtfoSi 
                        niSoft 
                        foSinU 
                        tUniSo
         */
        static void Main(string[] args)
        {
            
            string[] dimensions = Console.ReadLine().Split();
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            string snake = Console.ReadLine();

            char[,] matrix = new char[rows, cols];

            // Fill the matrix with the snake's path
            int snakeIndex = 0;
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0) // Even rows - left to right
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snake[snakeIndex];
                        snakeIndex = (snakeIndex + 1) % snake.Length;
                    }
                }
                else // Odd rows - right to left
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[snakeIndex];
                        snakeIndex = (snakeIndex + 1) % snake.Length;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
