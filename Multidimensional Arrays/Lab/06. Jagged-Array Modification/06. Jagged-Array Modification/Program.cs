using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int rows = int.Parse(Console.ReadLine());
            
            int[][] jaggedArray = new int[rows][];

            for ( int row = 0; row < rows; row++)
            {
                int[] cols = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new int[cols.Length];
                for (int col = 0; col < cols.Length; col++)
                {
                    jaggedArray[row][col] = cols[col];
                }
            }

            string[] cmd = Console.ReadLine().Split();
            while (cmd[0] != "END")
            {
                int row = int.Parse(cmd[1]);
                int col = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);
                if (row >= 0 && col >= 0)
                {
                    if (rows > row && jaggedArray[row].Length > col )
                    {
                        if (cmd[0] == "Add")
                        {
                            jaggedArray[row][col] += value;
                        }
                        else if (cmd[0] == "Subtract")
                        {
                            jaggedArray[row][col] -= value;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                cmd = Console.ReadLine().Split();
            }

            for (int row = 0; row < jaggedArray.Length; row++)
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
