

using System;

namespace _02._Re_Volt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int countOfCommands = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size,size];
            int rowOfTarget = 0;
            int colOfTarget = 0;
            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                    if (input[col] == 'f')
                    {
                        rowOfTarget = row;
                        colOfTarget = col;
                    }
                }
                
            }

            for (int i = 0; i < countOfCommands; i++)
            {
                string cmdArgs = Console.ReadLine();
                switch (cmdArgs)
                {
                    case "up":

                        break;
                    case "down":
                        break;
                    case "right":
                        break;
                    case "left":
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
