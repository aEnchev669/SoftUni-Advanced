using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] groups = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rows = groups[0];
            int cols = groups[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                {

                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
