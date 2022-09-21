using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currParantheses = Console.ReadLine();
            List<char> parantheses = new List<char>();
            foreach (char item in currParantheses)
            {
                parantheses.Add(item);
            }
            int count = currParantheses.Length / 2;
            Queue<char> queuePar = new Queue<char>();
            for (int i = 0; i < parantheses.Count / 2 ; i++)
            {
                queuePar.Enqueue(parantheses[i]);
            }
            Stack<char> balancedParantheses = new Stack<char>();
            for (int i = parantheses.Count - 1 ; i > parantheses.Count / 2 - 1; i--)
            {
                balancedParantheses.Push(parantheses[i]);
            }
            for (int i = 0; i < parantheses.Count / 2; i++)
            {
                if (balancedParantheses.Count <= queuePar.Count)
                {
                    if (balancedParantheses.Peek() == '}')
                    {
                        queuePar.Dequeue();
                        balancedParantheses.Pop();
                    }
                    else if (balancedParantheses.Peek() == ']')
                    {
                        queuePar.Dequeue();
                        balancedParantheses.Pop();

                    }
                    else if (balancedParantheses.Peek() == ')')
                    {
                        queuePar.Dequeue();
                        balancedParantheses.Pop();
                    }
                }
            
            }
            if (queuePar.Any() || balancedParantheses.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            
            
            
            //for (int i = 0; i < parantheses.Count; i++)
            //{
            //    if (parantheses[i] == '{' || parantheses[i] == '['|| parantheses[i] == '(')
            //    {
            //        balancedParantheses.Push(parantheses[i]);
            //    }
            //    else
            //    {
            //        balancedParantheses.Pop();
            //    }
            //}
            //if (balancedParantheses.Any())
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

        }
    }
}
