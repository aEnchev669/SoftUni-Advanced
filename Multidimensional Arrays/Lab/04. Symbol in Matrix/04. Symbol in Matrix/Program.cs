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

            char[,] matrix = new char[size, size];


            for (int rows = 0; rows < size; rows++)
            {
                string numbers = Console.ReadLine();

                for (int cols = 0; cols < size; cols++)
                {
                    matrix[rows, cols] = numbers[cols];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    if (matrix[i, k] == symbol)
                    {
                        Console.WriteLine($"({i}, {k})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");

        }
    }
}
