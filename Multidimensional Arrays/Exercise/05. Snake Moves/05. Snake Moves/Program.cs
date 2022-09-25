using System;
using System.Linq;

namespace _05._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();
            string word = Console.ReadLine();
            char[,] matrix = new char[demensions[0], demensions[1]];

            int currIndex = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (currIndex == word.Length)
                        {
                            currIndex = 0;
                        }
                        matrix[row, col] = word[currIndex];
                        currIndex++;
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0 ; col--)
                    {
                        if (currIndex == word.Length)
                        {
                            currIndex = 0;
                        }
                        matrix[row, col] = word[currIndex]; 
                        currIndex++;
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
