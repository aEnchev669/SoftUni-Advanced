using System;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int k = 0; k < cols; k++)
                {
                    matrix[i, k] = rowData[k];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    sum += matrix[i,k];
                    
                }
            }
                Console.WriteLine(sum);

        }
    }
}
