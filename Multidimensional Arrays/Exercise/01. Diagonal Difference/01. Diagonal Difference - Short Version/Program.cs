using System;
using System.Linq;

namespace _02._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int k = 0; k < size; k++)
                {
                    matrix[i, k] = rowData[k];
                }
            }

            int rightLeftSum = 0;
            int leftRightSum = 0;

            for (int i = 0, j = size - 1; i < size; i++, j--)
            {
                rightLeftSum += matrix[i, i];
                leftRightSum += matrix[i, j];
            }

            int sum = Math.Abs(rightLeftSum - leftRightSum);
            Console.WriteLine(sum);
        }
    }
}
