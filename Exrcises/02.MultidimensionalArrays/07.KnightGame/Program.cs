using System;

namespace _07.KnightGame
{
    internal class Program
    {
        /* 
         
        Chess is the oldest game, but it is still popular these days. For this task we will use only one chess piece – the Knight. The knight moves to the nearest square, but not on the same row, column or diagonal. (This can be thought of as moving two squares horizontally, then one square vertically, or moving one square horizontally, then two squares vertically— i.e. in an "L" pattern.)

        The knight game is played on a board with dimensions N x N and a lot of chess knights 0 <= K <= N2.

        You will receive a board with K for knights and '0' for empty cells. Your task is to remove a minimum of the knights, so there will be no knights left that can attack another knight.

        Input

        · On the first line, you will receive the N side of the board.

        · On the next N lines, you will receive strings with Ks and 0s.

        Output

        · Print a single integer with the minimum number of knights that needs to be removed.

        Constraints

        · Size of the board will be 0 < N < 30
        · Time limit: 0.3 sec. Memory limit: 16 MB



 Input          Output
5               1
0K0K0
K000K
00K00
K000K
0K0K0


Input            Output
8               12
0K0KKK00
0K00KKKK
00K0000K
KKKKKK0K
K0K0000K
KK00000K
00K0K000
000K00KK
         */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] board = new char[n][];

            for (int i = 0; i < n; i++)
            {
                board[i] = Console.ReadLine().ToCharArray();
            }

            int removedKnights = RemoveAttackingKnights(board);
            Console.WriteLine(removedKnights);
        }

        static int RemoveAttackingKnights(char[][] board)
        {
            int removedKnights = 0;

            do
            {
                int maxAttacks = 0;
                int maxI = -1;
                int maxJ = -1;

                for (int i = 0; i < board.Length; i++)
                {
                    for (int j = 0; j < board[i].Length; j++)
                    {
                        if (board[i][j] == 'K')
                        {
                            int attacks = CountAttacks(board, i, j);
                            if (attacks > maxAttacks)
                            {
                                maxAttacks = attacks;
                                maxI = i;
                                maxJ = j;
                            }
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    board[maxI][maxJ] = '0';
                    removedKnights++;
                }
                else
                {
                    break; // No more knights to remove
                }

            } while (true);

            return removedKnights;
        }

        static int CountAttacks(char[][] board, int x, int y)
        {
            int attacks = 0;
            int[][] moves = {
            new int[] { -2, -1 },
            new int[] { -2, 1 },
            new int[] { -1, -2 },
            new int[] { -1, 2 },
            new int[] { 1, -2 },
            new int[] { 1, 2 },
            new int[] { 2, -1 },
            new int[] { 2, 1 }
        };

            foreach (var move in moves)
            {
                int newX = x + move[0];
                int newY = y + move[1];

                if (IsValidMove(board, newX, newY) && board[newX][newY] == 'K')
                {
                    attacks++;
                }
            }

            return attacks;
        }

        static bool IsValidMove(char[][] board, int x, int y)
        {
            return x >= 0 && x < board.Length && y >= 0 && y < board[0].Length;
        }
    }
}
