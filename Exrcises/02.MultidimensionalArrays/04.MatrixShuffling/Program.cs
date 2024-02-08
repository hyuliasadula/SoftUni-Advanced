using System;

namespace _04.MatrixShuffling
{
    internal class Program
    {

        /*
         Write a program that reads a string matrix from the console and performs certain operations with its elements. User input is provided in a similar way as in the problems above – first, you read the dimensions and then the data.

        Your program should then receive commands in the format: "swap row1 col1 row2 col2" where row1, col1, row2, col2 are coordinates in the matrix. For a command to be valid, it should start with the "swap" keyword along with four valid coordinates (no more, no less). You should swap the values at the given coordinates (cell [row1, col1] with cell [row2, col2]) and print the matrix at each step (thus you'll be able to check if the operation was performed correctly)

        If the command is not valid (doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist), print "Invalid input!" and move on to the next command. Your program should finish when the string "END" is entered.


        Input                       Output

        2 3                         5 2 3
        1 2 3                       4 1 6
        4 5 6                       Invalid input!
        swap 0 0 1 1                5 4 3
        swap 10 9 8 7               2 1 6
        swap 0 1 1 0
        END




        1 2                         Invalid input!
        Hello World                 World Hello
        0 0 0 1                     Hello World
        swap 0 0 0 1
        swap 0 1 0 0
        END
         
         
         */
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split();
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);

            // Createing the matrix
            string[,] matrix = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] rowValues = Console.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowValues[j];
                }
            }

            //commands
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                    break;

                //Validateing command
                string[] commandParts = command.Split();
                if (commandParts.Length != 5 || commandParts[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                // Parsing coordinates
                bool isValid = true;
                int[] coordinates = new int[4];
                for (int i = 1; i <= 4; i++)
                {
                    if (!int.TryParse(commandParts[i], out coordinates[i - 1]) || coordinates[i - 1] < 0 || coordinates[i - 1] >= rows)
                    {
                        isValid = false;
                        break;
                    }
                }

                if (!isValid)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                // Swap values
                int row1 = coordinates[0], col1 = coordinates[1], row2 = coordinates[2], col2 = coordinates[3];
                string temp = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = temp;

                PrintMatrix(matrix);
            }
        }

        static void PrintMatrix(string[,] matrix)
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

