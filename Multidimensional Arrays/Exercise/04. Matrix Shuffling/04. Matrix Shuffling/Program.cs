using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
            int rows = demensions[0];
            int cols = demensions[1];
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] data = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];  
                }
            }
            string[] cmdArgs = Console.ReadLine().Split();
            while (cmdArgs[0] != "END")
            {
                if (cmdArgs.Length == 5)
                {
                    string token = cmdArgs[0];
                    int firtsRow = int.Parse(cmdArgs[1]);
                    int firtsCol = int.Parse(cmdArgs[2]);
                    int secondRow = int.Parse(cmdArgs[3]);
                    int secondCol = int.Parse(cmdArgs[4]);
                    string replacemant = string.Empty;
                    if (token == "swap")
                    {
                        if (firtsRow >= 0 && firtsCol >= 0 && secondRow >= 0 && secondCol >= 0
                            && firtsRow < matrix.GetLength(0) && firtsCol < matrix.GetLength(1)
                            && secondRow < matrix.GetLength(0) && secondCol < matrix.GetLength(1))
                        {
                            replacemant = matrix[firtsRow, firtsCol];
                            matrix[firtsRow, firtsCol] = matrix[secondRow, secondCol];
                            matrix[secondRow, secondCol] = replacemant;

                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    Console.Write(matrix[row,col] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                cmdArgs = Console.ReadLine().Split();
            }
        }
    }
}
