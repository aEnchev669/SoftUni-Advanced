using System;
using System.Linq;

namespace _02._Wall_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            int vankoRow = 0;
            int vankoCol = 0;
            int counter = 0;
            int countOfRods = 0;

            for (int row = 0; row < size; row++)
            {
                string rowInfo = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row,col] = rowInfo[col];
                    if (matrix[row,col] == 'V')
                    {
                        vankoRow = row;
                        vankoCol = col;
                    }
                }
            }
            bool getElectrocuted = false;
            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                if (cmd == "up")
                {
                    if (vankoRow != 0)
                    {
                        matrix[vankoRow, vankoCol] = '*';
                        vankoRow--;
                        if (matrix[vankoRow,vankoCol] == 'R')
                        {
                            countOfRods++;
                            vankoRow++;
                        }
                        else if (matrix[vankoRow,vankoCol] == 'C')
                        {
                            matrix[vankoRow, vankoCol] = 'E';
                            counter+=2;
                            getElectrocuted = true;
                            break;
                        }
                        else if (matrix[vankoRow,vankoCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }
                else if (cmd == "down")
                {
                    if (vankoRow != size - 1)
                    {
                        matrix[vankoRow, vankoCol] = '*';
                        vankoRow++;
                        if (matrix[vankoRow,vankoCol] == 'R')
                        {
                            countOfRods++;
                            vankoRow--;
                        }
                        else if (matrix[vankoRow,vankoCol] == 'C')
                        {
                            matrix[vankoRow, vankoCol] = 'E';
                            counter+=2;
                            getElectrocuted = true;
                            break;
                        }
                        else if (matrix[vankoRow, vankoCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                        }
                        else
                        {
                            
                            counter++;
                        }
                    }
                }
                else if (cmd == "left")
                {
                    if (vankoCol != 0)
                    {
                        matrix[vankoRow, vankoCol] = '*';
                        vankoCol--;
                        if (matrix[vankoRow,vankoCol] == 'R')
                        {
                            countOfRods++;
                            vankoCol++;
                        }
                        else if (matrix[vankoRow,vankoCol] == 'C')
                        {
                            matrix[vankoRow, vankoCol] = 'E';
                            counter+=2;
                            getElectrocuted = true;
                            break;
                        }
                        else if (matrix[vankoRow, vankoCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }
                else if (cmd == "right")
                {
                    if (vankoCol != size - 1)
                    {
                        matrix[vankoRow, vankoCol] = '*';
                        vankoCol++;
                        if (matrix[vankoRow, vankoCol] == 'R')
                        {
                            countOfRods++;
                            vankoCol--;
                        }
                        else if (matrix[vankoRow,vankoCol] == 'C')
                        {
                            matrix[vankoRow, vankoCol] = 'E';
                            counter+=2;
                            getElectrocuted = true;
                            break;
                        }
                        else if (matrix[vankoRow,vankoCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }
                cmd = Console.ReadLine();
            }

            if (getElectrocuted)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {counter} hole(s).");
            }
            else
            {
                matrix[vankoRow, vankoCol] = 'V';
                Console.WriteLine($"Vanko managed to make {counter} hole(s) and he hit only {countOfRods} rod(s).");
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
