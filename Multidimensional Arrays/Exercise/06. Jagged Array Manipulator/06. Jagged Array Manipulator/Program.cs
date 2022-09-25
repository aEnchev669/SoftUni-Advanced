using System;
using System.Linq;

namespace _06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[rows][];

            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                double[] cols = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                jaggedArray[row] = cols;
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                        
                    }
                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }
            string[] cmdArgs = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            while (cmdArgs[0] != "End")
            {
                int row = int.Parse(cmdArgs[1]);
                int column = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                if (row >= 0 && row <= rows && column < jaggedArray[row].Length && column >= 0)
                {
                    if (cmdArgs[0] == "Add")
                    {
                        jaggedArray[row][column] += value;
                    }
                    else if (cmdArgs[0] == "Subtract")
                    {
                        jaggedArray[row][column] -= value;
                    }
                }
                cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
