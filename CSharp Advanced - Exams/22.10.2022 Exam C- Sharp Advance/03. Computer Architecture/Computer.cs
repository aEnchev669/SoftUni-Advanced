using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        private List<CPU> cpuList;

        public Computer(string model, int )
        {
            cpuList = new List<CPU>();
        }
        public Computer(string model, int )
        {
            cpuList = new List<CPU>();
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        private List<CPU> multiprocessor ;

        public List<CPU> Multiprocessor
        {
            get { return multiprocessor ; }
            set { multiprocessor  = value; }
        }




    }
}
