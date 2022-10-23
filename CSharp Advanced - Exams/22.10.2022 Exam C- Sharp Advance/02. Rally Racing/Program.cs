using System;
using System.Linq;

namespace _02._Rally_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string carRacingNumber = Console.ReadLine();

            char[,] matrix = new char[size,size];

            int rowOfTunel1 = 0;
            int colOfTunel1 = 0;

            int rowOfTunel2 = 0;
            int colOfTunel2 = 0;


            int carRow = 0;
            int carCol = 0;
            int kmOfCar = 0;

            bool isSecondTunel = false;
            for (int row = 0; row < size; row++)
            {
                char[] info = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = info[col];
                    if (matrix[row,col] == 'T')
                    {
                        matrix[carRow, carCol] = '.';

                        if (!isSecondTunel)
                        {
                           rowOfTunel1 = row;
                            colOfTunel1 = col;
                            isSecondTunel = true;
                        }
                        else
                        {
                            rowOfTunel2 = row;
                            colOfTunel2 = col;
                        }
                    }
                }
            }

            matrix[0, 0] = 'C';

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "End")
                {
                    Console.WriteLine($"Racing car {carRacingNumber} DNF.");
                    break;
                }

                if (cmd == "up")
                {
                    kmOfCar += 10;
                    matrix[carRow, carCol] = '.';
                    carRow--;

                    if (matrix[carRow,carCol] == 'T')
                    {
                        matrix[carRow, carCol] = '.';

                        kmOfCar += 20;
                        if (carRow == rowOfTunel1 && carCol == colOfTunel1)
                        {
                            carRow = rowOfTunel2;
                            carCol = colOfTunel2;
                        }
                        else
                        {
                            carRow = rowOfTunel1;
                            carCol = colOfTunel1;
                        }
                    }
                    else if (matrix[carRow,carCol] == 'F')
                    {
                        Console.WriteLine($"Racing car {carRacingNumber} finished the stage!");
                        break;
                    }
                }
                else if (cmd == "down")
                {
                    kmOfCar += 10;
                    matrix[carRow, carCol] = '.';
                    carRow++;

                    if (matrix[carRow,carCol] == 'T')
                    {
                        matrix[carRow, carCol] = '.';

                        kmOfCar += 20;
                        if (carRow == rowOfTunel1 && carCol == colOfTunel1)
                        {
                            carRow = rowOfTunel2;
                            carCol = colOfTunel2;
                        }
                        else
                        {
                            carRow = rowOfTunel1;
                            carCol = colOfTunel1;
                        }
                    }
                    else if (matrix[carRow, carCol] == 'F')
                    {
                        Console.WriteLine($"Racing car {carRacingNumber} finished the stage!");
                        break;
                    }
                }
                else if (cmd == "left")
                {
                    kmOfCar += 10;
                    matrix[carRow,carCol] = '.';
                    carCol--;
                    if (matrix[carRow, carCol] == 'T')
                    {
                        matrix[carRow, carCol] = '.';

                        kmOfCar += 20;
                        if (carRow == rowOfTunel1 && carCol == colOfTunel1)
                        {
                            carRow = rowOfTunel2;
                            carCol = colOfTunel2;
                        }
                        else
                        {
                            carRow = rowOfTunel1;
                            carCol = colOfTunel1;
                        }
                    }
                    else if (matrix[carRow, carCol] == 'F')
                    {
                        Console.WriteLine($"Racing car {carRacingNumber} finished the stage!");
                        break;
                    }

                }
                else if (cmd == "right")
                {
                    kmOfCar += 10;
                    matrix[carRow, carCol] = '.';
                    carCol++;
                    if (matrix[carRow, carCol] == 'T')
                    {
                        matrix[carRow, carCol] = '.';
                        kmOfCar += 20;
                        if (carRow == rowOfTunel1 && carCol == colOfTunel1)
                        {
                            carRow = rowOfTunel2;
                            carCol = colOfTunel2;
                        }
                        else
                        {
                            carRow = rowOfTunel1;
                            carCol = colOfTunel1;
                        }
                    }
                    else if (matrix[carRow, carCol] == 'F')
                    {
                        Console.WriteLine($"Racing car {carRacingNumber} finished the stage!");
                        break;
                    }
                }
            }
            
            matrix[carRow, carCol] = 'C';
            Console.WriteLine($"Distance covered {kmOfCar} km.");

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
