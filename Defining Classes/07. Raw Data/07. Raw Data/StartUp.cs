    using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Raw_Data
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] infoForCar = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                // string model,  int speed, int power
                Car car = new Car(
                    infoForCar[0],
                    int.Parse(infoForCar[1]),
                    int.Parse(infoForCar[2]),
                    int.Parse(infoForCar[3]),
                    infoForCar[4],
                    double.Parse(infoForCar[5]),
                    int.Parse(infoForCar[6]),
                    double.Parse(infoForCar[7]),
                    int.Parse(infoForCar[8]),
                    double.Parse(infoForCar[9]),
                    int.Parse(infoForCar[10]),
                    double.Parse(infoForCar[11]),
                    int.Parse(infoForCar[12])
                    );

                cars.Add(car);
            }
            string cmd = Console.ReadLine();

             string[] filtredCars = new ;

            if (cmd == "fragile")
            {
                filtredCars = cars
                    .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(c => c.Pressure < 1))
                    .Select(c => c.Model)
                    .ToArray();
            }
            else if (cmd == "flammable")
            {
                filtredCars = cars
                    .Where(c => c.Cargo.Type == "flammble" && c.Engine.Power > 250)
                    .Select(c => c.Model)
                    .ToArray();
            }

            foreach (var carModel in filtredCars)
            {
                Console.WriteLine(carModel);
            }
        }
    }
}
