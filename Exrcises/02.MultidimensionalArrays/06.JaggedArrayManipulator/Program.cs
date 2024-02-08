using System;

namespace _06.JaggedArrayManipulator
{
    internal class Program
    {

        /*
         * 
        Receive an integer N, the number of rows in the matrix.
        Receive N rows of integers, each separated by a space.
        Analyze the matrix:
        If a row and the one below it have equal length, multiply each element in both by 2. Otherwise, divide by 2.
        Receive commands:
        "Add {row} {column} {value}": Add {value} to the element at the given indexes if they are valid.
        "Subtract {row} {column} {value}": Subtract {value} from the element at the given indexes if they are valid.
        "End": Print the final state of the matrix (all elements separated by a space) and stop the program.

        Input:

        First line: Integer N, the number of rows.
        Next N lines: Each row of integers separated by a space.
        Followed by commands until "End" is read.

        Output:

        Print N lines, each representing a row of the final matrix with elements separated by a space.
        Constraints:

        N (number of rows) is an integer in the range [2…12].
        Values in the matrix and commands are integers.
        Input follows the specified format. 


        Input                       Output

        5                           20 40 60
        10 20 30                    1 2 3
        1 2 3                       2
        2                           2
        2                           5 5
        10 10
        End
         */
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[][] matrix = new int[N][];

            // Populate the matrix
            for (int i = 0; i < N; i++)
            {
                string[] rowValues = Console.ReadLine().Split();
                matrix[i] = new int[rowValues.Length];
                for (int j = 0; j < rowValues.Length; j++)
                {
                    matrix[i][j] = int.Parse(rowValues[j]);
                }
            }

            // Analyze and manipulate the matrix
            for (int i = 0; i < N - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] *= 2;
                        matrix[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] /= 2;
                    }

                    for (int j = 0; j < matrix[i + 1].Length; j++)
                    {
                        matrix[i + 1][j] /= 2;
                    }
                }
            }

            // Process commands
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                    break;

                string[] parts = command.Split();
                string action = parts[0];
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);

                if (IsValidIndex(matrix, row, col))
                {
                    if (action == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (action == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
            }

            // Print the final matrix
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        static bool IsValidIndex(int[][] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
        }
    }
}
