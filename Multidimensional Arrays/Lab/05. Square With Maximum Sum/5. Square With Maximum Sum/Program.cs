﻿using System;
using System.Linq;


namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int subMatrixRows = 2;
            int subMatrixCols = 2;
            int[] size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(", ")
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

            for (int row = 0; row < rows - subMatrixRows + 1; row++)
            {

                for (int col = 0; col < cols - subMatrixCols + 1; col++)
                {
                    int sum = 0;
                    sum += matrix[row, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row + 1, col];
                    sum += matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        squareStartRow = row;
                        squareStartCol = col;
                        maxSum = sum;
                    }
                }

            }
            Console.WriteLine($"{matrix[squareStartRow, squareStartCol]} {matrix[squareStartRow, squareStartCol + 1]}");
            Console.WriteLine($"{matrix[squareStartRow + 1, squareStartCol]} {matrix[squareStartRow + 1, squareStartCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
