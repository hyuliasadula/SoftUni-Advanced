using System;

namespace _02.SquaresInMatrix
{
    internal class Program
    {
        /*
        Find the count of 2 x 2 squares of equal chars in a matrix.

            Input

            · On the first line, you are given the integers rows and cols – the matrix's dimensions.

            · Matrix characters come at the next rows lines (space separated).

            Output

         · Print the number of all the squares matrixes you have found.



        Input            Output
        3 4                 2
        A B B D
        E B B B
        I J B B
         */
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split(" ");
            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);

            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] data = Console.ReadLine().Split(" ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col][0]; 
                }
            }

            // Find and print the positions of 2x2 squares of equal characters
            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    // Is 'B' equal to 'B' (next element in the same row)?
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        // Is 'E' equal to 'B' (element in the next row, same column)?
                        matrix[row + 1, col] == matrix[row + 1, col + 1] &&
                        // Is 'B' equal to 'E' (element in the next row, same column)?
                        matrix[row, col] == matrix[row + 1, col])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
