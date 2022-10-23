using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerArchitecture
{
    public class CPU
    {
        public CPU(string brand, int cores, double frequency)
        {
            brand = brand;
            Cores = cores;
            Frequency = frequency;
        }

        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private int cores;

        public int Cores
        {
            get { return cores; }
            set { cores = value; }
        }

        private double frequency;

        public double Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }
//        "{brand} CPU:
//Cores: {cores}
//    Frequency: {frequency} GHz "

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{brand} CPU:");
            result.AppendLine($"Cores: {cores}");
            result.AppendLine($"Frequency: {frequency:f1} GHz");

            return result.ToString().Trim();
       }

    }
}
