using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> parkingLot = new List<string>();

            while (input[0] != "END")
            {
                string cmd = input[0];
                string carNumber = input[1];
                if (cmd == "IN")
                {
                    if (!parkingLot.Contains(carNumber))
                    {
                        parkingLot.Add(carNumber);
                    }
                }
                else
                {
                    if (parkingLot.Contains(carNumber))
                    {
                        parkingLot.Remove(carNumber);
                    }
                }
                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (parkingLot.Count != 0)
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
