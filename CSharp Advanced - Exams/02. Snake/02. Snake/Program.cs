using System;

namespace _02._Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int snakeRow = 0;
            int snakeCol = 0;

            int firstBRow = 0;     int secondBRow = 0;
            int firstBCol = 0;     int secondBCol = 0;

            bool isThereB = true;
            int foodPoints = 0;
            for (int row = 0; row < size; row++)
            {
                string rowsInfo = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowsInfo[col];
                    if (matrix[row,col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                    else if (matrix[row,col] == 'B')
                    {
                        if (isThereB)
                        {
                            firstBRow = row;
                            firstBCol = col;
                            isThereB = false;
                        }
                        else
                        {
                            secondBRow = row;
                            secondBCol = col;
                        }
                    }
                }
            }
            bool gameOver = false;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    matrix[snakeRow, snakeCol] = '.';
                    if (snakeRow == 0)
                    {
                        gameOver = true;
                        break;
                    }
                    snakeRow--;
                    if (matrix[snakeRow, snakeCol] == 'B')
                    {
                        if (snakeRow == firstBRow && snakeCol == firstBCol)
                        {
                            matrix[firstBRow, firstBCol] = '.';
                            snakeRow = secondBRow;
                            snakeCol = secondBCol;
                        }
                        else if(snakeRow == secondBRow && snakeCol == secondBCol)
                        {
                            matrix[secondBRow, secondBCol] = '.';
                            snakeRow = firstBRow;
                            snakeCol = firstBCol;
                        }
                    }
                    else if (matrix[snakeRow,snakeCol] == '*')
                    {
                        foodPoints++;
                    }
                }
                else if (command == "down")
                {
                    matrix[snakeRow, snakeCol] = '.';
                    if (snakeRow == size - 1)
                    {
                        gameOver = true;
                        break;
                    }
                    snakeRow++;
                    if (matrix[snakeRow,snakeCol] == 'B')
                    {
                        if (snakeRow == firstBRow && snakeCol == firstBCol)
                        {
                            matrix[firstBRow, firstBCol] = '.';
                            snakeRow = secondBRow;
                            snakeCol = secondBCol;
                        }
                        else if (snakeRow == secondBRow && snakeCol == secondBCol)
                        {
                            matrix[secondBRow, secondBCol] = '.';
                            snakeRow = firstBRow;
                            snakeCol = firstBCol;
                        }
                    }
                    else if (matrix[snakeRow, snakeCol] == '*')
                    {
                        foodPoints++;
                    }
                }
                else if (command == "right")
                {
                    matrix[snakeRow, snakeCol] = '.';
                    if (snakeCol == size -1)
                    {
                        gameOver = true;
                        break;
                    }
                    snakeCol++;
                    if (matrix[snakeRow,snakeCol] == 'B')
                    {
                        if (snakeRow == firstBRow && snakeCol == firstBCol)
                        {
                            matrix[firstBRow, firstBCol] = '.';
                            snakeRow = secondBRow;
                            snakeCol = secondBCol;
                        }
                        else if (snakeRow == secondBRow && snakeCol == secondBCol)
                        {
                            matrix[secondBRow, secondBCol] = '.';
                            snakeRow = firstBRow;
                            snakeCol = firstBCol;
                        }
                    }
                    else if (matrix[snakeRow, snakeCol] == '*')
                    {
                        foodPoints++;
                    }
                }
                else if (command == "left")
                {
                    matrix[snakeRow,snakeCol] = '.';
                    if (snakeCol == 0)
                    {
                        gameOver = true;
                        break;
                    }
                    snakeCol--;
                    if (matrix[snakeRow,snakeCol] == 'B')
                    {
                        if (snakeRow == firstBRow && snakeCol == firstBCol)
                        {
                            matrix[firstBRow, firstBCol] = '.';
                            snakeRow = secondBRow;
                            snakeCol = secondBCol;
                        }
                        else if (snakeRow == secondBRow && snakeCol == secondBCol)
                        {
                            matrix[secondBRow, secondBCol] = '.';
                            snakeRow = firstBRow;
                            snakeCol = firstBCol;
                        }
                    }
                    else if (matrix[snakeRow, snakeCol] == '*')
                    {
                        foodPoints++;
                    }
                }
                matrix[snakeRow, snakeCol] = 'S';
                if (foodPoints >= 10)
                {
                    break;
                }
            }




            if (gameOver)
            {
                Console.WriteLine("Game over!");
            }
            else
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {foodPoints}");

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
