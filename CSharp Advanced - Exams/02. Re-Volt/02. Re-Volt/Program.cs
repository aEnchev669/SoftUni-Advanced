

using System;

namespace _02._Re_Volt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int countOfCmd = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            int rowOfP = 0;
            int colOfP = 0;

            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row,col] == 'f')
                    {
                        rowOfP = row;
                        colOfP = col;
                    }
                }
            }
            matrix[rowOfP, colOfP] = '-';
            for (int cmd = 0; cmd < countOfCmd; cmd++)
            {
                string cmdTokens = Console.ReadLine();

                if (cmdTokens == "up")
                {
                    
                    if (rowOfP == 0)
                    { 
                        rowOfP = size - 1;
                    }
                    else
                    {
                        rowOfP--;
                    }
                    if (matrix[rowOfP, colOfP] == 'B')
                    {
                        if (rowOfP == 0)
                        {
                            rowOfP = size - 1;
                        }
                        else
                        {
                            rowOfP--;
                        }
                    }
                    else if (matrix[rowOfP, colOfP] == 'T')
                    {
                        if (rowOfP == size - 1)
                        {
                            rowOfP = 0;
                        }
                        else
                        {
                            rowOfP++;
                        }
                    }
                    else if (matrix[rowOfP,colOfP] == 'F')
                    {
                        matrix[rowOfP, colOfP] = 'f';
                        Console.WriteLine("Player won!");
                        break;
                    }
                }
                else if (cmdTokens == "down")
                {
                    if (rowOfP == size - 1)
                    {
                        rowOfP = 0;
                    }
                    else
                    {
                        rowOfP++;
                    }
                    if (matrix[rowOfP, colOfP] == 'B')
                    {
                        if (rowOfP == size - 1)
                        {
                            rowOfP = 0;
                        }
                        else
                        {
                            rowOfP++;
                        }
                    }
                    else if (matrix[rowOfP,colOfP] == 'T')
                    {
                        if (rowOfP == 0)
                        {
                            rowOfP = size - 1;
                        }
                        else
                        {
                            rowOfP--;
                        }
                    }
                    else if (matrix[rowOfP,colOfP] == 'F')
                    {
                        matrix[rowOfP, colOfP] = 'f';
                        Console.WriteLine("Player won!");
                        break;
                    }
                }
                else if (cmdTokens == "right")
                {
                    if (colOfP == size - 1)
                    {
                        colOfP = 0;
                    }
                    else
                    {
                        colOfP++;
                    }
                    if (matrix[rowOfP,colOfP] == 'B')
                    {
                        if (colOfP == size - 1)
                        {
                            colOfP = 0;
                        }
                        else
                        {
                            colOfP++;
                        }
                    }
                    else if (matrix[rowOfP,colOfP] == 'T')
                    {
                        if (colOfP == 0)
                        {
                            colOfP = size - 1;
                        }
                        else
                        {
                            colOfP--;
                        }
                    }
                    else if (matrix[rowOfP,colOfP] == 'F')
                    {
                        matrix[rowOfP, colOfP] = 'f';
                        Console.WriteLine("Player won!");
                        break;
                    }
                }
                else if (cmdTokens == "left")
                {
                    if (matrix[rowOfP,colOfP] == 0)
                    {
                        colOfP = size - 1;
                    }
                    else
                    {
                        colOfP--;
                    }
                    if (matrix[rowOfP,colOfP] == 'B')
                    {
                        if (colOfP == 0)
                        {
                            colOfP = size - 1;
                        }
                        else
                        {
                            colOfP--;
                        }
                    }
                    else if (matrix[rowOfP,colOfP] == 'T')
                    {
                        if (colOfP == size - 1)
                        {
                            colOfP = 0;
                        }
                        else
                        {   
                            colOfP++;
                        }
                    }
                    else if (matrix[rowOfP,colOfP] == 'F')
                    {
                        matrix[rowOfP, colOfP] = 'f';
                        Console.WriteLine("PLayer won!");
                        break;
                    }
                }
                if (cmd == countOfCmd - 1)
                {
                    matrix[rowOfP, colOfP] = 'f';
                    Console.WriteLine("Player lost!");
                }
            }
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
