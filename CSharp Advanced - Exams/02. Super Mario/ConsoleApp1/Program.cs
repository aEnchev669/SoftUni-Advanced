using System;
using System.Linq;

namespace _02._Super_Mario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int livesOfMario = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];

            int rowOfMario = 0;
            int colOfMario = 0;
            for (int row = 0; row < rows; row++)
            {
                char[] currRow = Console.ReadLine().ToCharArray();
                matrix[row] = currRow;
                if (currRow.Contains('M'))
                {
                    rowOfMario = row;
                    colOfMario = currRow.ToList().IndexOf('M');
                }
            }
            bool isSaved = false;

            while (true)
            {
                if (livesOfMario <= 0)
                {
                    matrix[rowOfMario][colOfMario] = 'X';
                    Console.WriteLine($"Mario died at {rowOfMario};{colOfMario}.");
                    break;
                }
                string[] input = Console.ReadLine().Split();
                char command = char.Parse(input[0]); // maybe failed
                int enemyRow = int.Parse(input[1]);
                int enemyCol = int.Parse(input[2]);

                matrix[enemyRow][enemyCol] = 'B';
                livesOfMario--;

                matrix[rowOfMario][colOfMario] = '-';
                if (command == 'W' && rowOfMario - 1 >= 0)
                {
                    rowOfMario--;
                }
                else if (command == 'S' && rowOfMario + 1 < rows)
                {
                    rowOfMario++;
                }
                else if (command == 'A' && colOfMario - 1 >= 0)
                {
                    colOfMario--;
                }
                else if (command == 'D' && colOfMario + 1 < matrix[0].Length)
                {
                    colOfMario++;
                }

                if (matrix[rowOfMario][colOfMario] == 'B')
                {
                    livesOfMario-= 2;
                }
                else if (matrix[rowOfMario][colOfMario] == 'P')
                {
                    matrix[rowOfMario][colOfMario] = '-';
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {livesOfMario}");
                    break;
                }
                matrix[rowOfMario][colOfMario] = 'M';
            }
           
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
