using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    public class Program
    {
        public static void Main()
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quant = double.Parse(Console.ReadLine());

            double price = 0;

            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    price = quant * 0.5;
                }
                else if (city == "Varna")
                {
                    price = quant * 0.45;
                }
                else if (city == "Plovdiv")
                {
                    price = quant * 0.4;
                }
            }
            else if (product == "water")
            {
                if (city == "Sofia")
                {
                    price = quant * 0.8;
                }
                else if (city == "Varna")
                {
                    price = quant * 0.7;
                }
                else if (city == "Plovdiv")
                {
                    price = quant * 0.7;
                }
            }
            else if (product == "beer")
            {
                if (city == "Sofia")
                {
                    price = quant * 1.2;
                }
                else if (city == "Varna")
                {
                    price = quant * 1.10;
                }
                else if (city == "Plovdiv")
                {
                    price = quant * 1.15;
                }
            }
            else if (product == "sweets")
            {
                if (city == "Sofia")
                {
                    price = quant * 1.45;
                }
                else if (city == "Varna")
                {
                    price = quant * 1.35;
                }
                else if (city == "Plovdiv")
                {
                    price = quant * 1.30;
                }
            }
            else if (product == "peanuts")
            {
                if (city == "Sofia")
                {
                    price = quant * 1.6;
                }
                else if (city == "Varna")
                {
                    price = quant * 1.55;
                }
                else if (city == "Plovdiv")
                {
                    price = quant * 1.5;
                }
            }

            Console.WriteLine(price);
        }
    }
}
