using System;
using System.Linq;


namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int subMatrixRows = 3;
            int subMatrixCols = 3;
            int[] size = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int maxSum = int.MinValue;

            int squareStartRow = 0;
            int squareStartCol = 0;
            if (matrix.GetLength(0) > 2 && matrix.GetLength(1) > 2)
            {
                for (int row = 0; row < rows - 2; row++)
                {

                    for (int col = 0; col < cols - 2; col++)
                    {
                        int sum =
                        matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + 
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        if (sum > maxSum)
                        {

                            squareStartRow = row;
                            squareStartCol = col;
                            maxSum = sum;
                        }
                    }

                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = squareStartRow ; row < squareStartRow + 3; row++)
            {
                for (int col = squareStartCol; col < squareStartCol + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
