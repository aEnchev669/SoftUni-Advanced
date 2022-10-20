using System;

namespace _05._Date_Modifier
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();    

           int difference =  DateModifier.DateDifference(start, end);

            Console.WriteLine(Math.Abs(difference));
        }
    }
}
