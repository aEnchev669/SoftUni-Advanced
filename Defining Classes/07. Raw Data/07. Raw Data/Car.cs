using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Raw_Data
{
    public class Car
    {
        public Car
            (
            string model,
            int speed,
            int power,
            int weight,
            string type,
            double tyre1Pressure,
             int tyre1Age,
             double tyre2Pressure,
             int tyre2Age,
             double tyre3Pressure,
             int tyre3Age,
            double tyre4Pressure,
            int tyre4Age
            )
        {
            Model = model;
            Engine = new Engine
            {
                Power = power,
                Speed = speed
            };
            Cargo = new Cargo
            {
                Type = type,
                Weight = weight
            };
         Tires = new Tire[4];
            Tires[0] = new Tire { Pressure = tyre1Pressure, Age = tyre1Age };
            Tires[1] = new Tire { Pressure = tyre2Pressure, Age = tyre2Age };
            Tires[2] = new Tire { Pressure = tyre3Pressure, Age = tyre3Age };
            Tires[3] = new Tire { Pressure = tyre4Pressure, Age = tyre4Age };

        }
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public  Cargo Cargo{ get; set; }

        public Tire[] Tires  { get; set; }
    }
}   
