using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double FuelQuantity { get => fuelQuantity; set => fuelQuantity = value; }
        public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }

        private Engine engine;
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        private Tire[] tires;
        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }


        public void Drive(int distance)
        {
            if (fuelQuantity - distance * fuelConsumption >= 0)
            {
                fuelQuantity -= distance * fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public void WhoAmI()
        {
            Console.WriteLine($"Make: {make}\nModel: {model}\nYear: {year}\nFuelQuantity: {fuelQuantity:f2}");
        }
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year)
            :this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car( string make, string model, int year, double fuelQuantity, double fuelConsumption)
            :this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
           : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }
    }
}
