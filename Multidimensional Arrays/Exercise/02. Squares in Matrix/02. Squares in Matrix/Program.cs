using System;
using System.Linq;

namespace _02._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsNCols = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            int rows = rowsNCols[0];
            int cols = rowsNCols[1];

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] data = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            int equalSquares = 0;
            
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row, col] == matrix[row + 1, col] 
                        && matrix[row,col] == matrix[row + 1, col + 1])
                    {
                        equalSquares ++;
                    }
                }
            }
            Console.WriteLine(equalSquares);
        }
    }
}
