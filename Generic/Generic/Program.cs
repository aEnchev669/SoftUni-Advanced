using System;
using System.IO;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            Console.WriteLine(list.Get(0));
            Console.WriteLine(list.Get(1));
            Console.WriteLine(list.Get(2));
        }
        
    }
}
