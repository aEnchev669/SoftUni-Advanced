using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int maxOrder = int.MinValue;
            int count = orders.Count;
            int num = 0;
            if (orders.Count == 0 )
            {
                Console.WriteLine("Orders complete");
                return;
            }
            if (orders.Peek() > quantity || quantity == 0)
            {
                Console.WriteLine($"Orders left: {String.Join(", ", orders)}");
                return;
            }
            
            for (int i = 0; i < count; i++)
            {
                num = orders.Peek();
                if (orders.Peek() > maxOrder)
                {
                    maxOrder = orders.Dequeue();
                    orders.Enqueue(num);
                }
                else
                {
                    orders.Dequeue();
                    orders.Enqueue(num);
                }
            }

            Console.WriteLine(maxOrder);

            while (orders.Count != 0 )
            {
                if (orders.Peek() <= quantity)
                {
                    quantity -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {String.Join(", ", orders)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");

        }
    }
}
