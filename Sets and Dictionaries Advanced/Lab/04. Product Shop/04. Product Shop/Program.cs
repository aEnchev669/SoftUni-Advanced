
using System;
using System.Collections.Generic;

namespace _04._Product_Shop
{
   
    internal class Program
    {
        public class ProductAndPrice
        {
            public List<string> Name { get; set; }
            public List<double> Price { get; set; }
        }
        static void Main(string[] args)
        {
            SortedDictionary<string, ProductAndPrice> shopsInfo = new SortedDictionary<string, ProductAndPrice>();

            string[] cmdArgs = Console.ReadLine().Split(", ");
            while (cmdArgs[0] != "Revision")
            {
                string nameOfShop = cmdArgs[0];
                string product = cmdArgs[1];
                double priceOfProduct = double.Parse(cmdArgs[2]);

                if (!shopsInfo.ContainsKey(nameOfShop))
                {
                    shopsInfo.Add(nameOfShop, new ProductAndPrice());
                    shopsInfo[nameOfShop].Name = new List<string>();
                    shopsInfo[nameOfShop].Price = new List<double>();
                }

                shopsInfo[nameOfShop].Price.Add(priceOfProduct);
                shopsInfo[nameOfShop].Name.Add(product);

                cmdArgs = Console.ReadLine().Split(", ");
            }

            foreach (var shop in shopsInfo)
            {
                string nameOfShop = shop.Key;
                var price = shop.Value.Price;
                var name = shop.Value.Name;

                Console.WriteLine($"{nameOfShop}->");

                for (int i = 0; i < name.Count; i++)
                {
                    Console.WriteLine($"Product: {name[i]}, Price: {price[i]}");
                }
            }
        }
    }
}
