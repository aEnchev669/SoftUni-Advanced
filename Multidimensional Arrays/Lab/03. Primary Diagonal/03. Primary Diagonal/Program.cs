using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int space = 0;
            for (int rows = 0; rows < size; rows++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int cols = 0; cols < size; cols++)
                {
                    matrix[rows, cols] = numbers[cols];
                }
            }

            int numToAdd = 0;
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                for (int k = i; k < size; k++)
                {
                    sum += matrix[i, k];
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
