using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfOperations = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> memory = new Stack<string>();
            memory.Push(string.Empty);

            for (int i = 0; i < numbersOfOperations; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string cmdType = cmdArgs[0];
                if (cmdType == "1")
                {
                    text.Append(cmdArgs[1]);
                    memory.Push(text.ToString());
                }
                else if (cmdType == "2")
                {
                    int charactersToRemove = int.Parse(cmdArgs[1]);
                    text.Remove(text.Length - charactersToRemove, charactersToRemove);
                    memory.Push(text.ToString());
                }
                else if (cmdType == "3")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index >= 0 && index <= text.Length)
                    {
                        Console.WriteLine(text[index - 1]);
                    }
                }
                else if (cmdType == "4")
                {
                    memory.Pop();
                    string currVersion = memory.Peek();
                    text = new StringBuilder(currVersion);
                }
            }
        }
    }
}
