using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());

            int numberToAdd = 0;
            int numOfRacks = 0;
            int sum = 0;

            if (numbers.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            if (capacity == 0)
            {
                return;
            }
            

            while (numbers.Count != 0 )
            {
                numberToAdd = numbers.Pop();
                if (numbers.Count == 0)
                {
                    numOfRacks++;
                    break;
                }
                sum = numbers.Peek() + numberToAdd;
                if (sum == capacity)
                {
                    numbers.Pop();
                    numOfRacks++;
                    sum = 0;
                }
                else if(sum > capacity)
                {
                    numOfRacks++;
                    sum = 0;
                }
                else if(sum < capacity)
                {
                    numbers.Pop();
                    if (numbers.Count == 0)
                    {
                        numOfRacks++;
                    }
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum +=numbers.Peek();
                        if (sum == capacity)
                        {
                            numbers.Pop();
                            numOfRacks++;
                            break;
                        }
                        else if (sum > capacity)
                        {
                            
                            numOfRacks++;
                            break;
                        }
                        else if (sum < capacity)
                        {
                            numbers.Pop();
                        }
                    }
                    
                }
            }
            Console.WriteLine(numOfRacks);
        }
    }
}
