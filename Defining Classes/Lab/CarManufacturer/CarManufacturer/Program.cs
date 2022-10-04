using System;

namespace CarManufacturer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 0.9;
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");

            Console.WriteLine($"WHere to go?");

            car.Drive(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Left fuel: {car.FuelQuantity}");
        }
    }
}
