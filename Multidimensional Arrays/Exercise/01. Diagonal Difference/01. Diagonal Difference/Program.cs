using System;
using System.Linq;


namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int firstSum = 0;
            int secondSum = 0; 

            for (int row = 0; row < size; row++)
            {
                for (int col = row; col <= row; col++)
                {
                    firstSum+=matrix[row, col];
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = size - row - 1; col >= size - row - 1 ; col--)
                {
                    secondSum+=matrix[row, col];
                }
            }
            int sum = firstSum - secondSum;
            Console.WriteLine($"{Math.Abs(sum)}");
        }
    }
}
