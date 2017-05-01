using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] workDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            string[] weekEnd = { "Saturday", "Sunday" };

            string produce = Console.ReadLine();
            string weekDay = Console.ReadLine();
            var quant = double.Parse(Console.ReadLine());

            if (workDays.Contains(weekDay))
            {
                if (produce == "banana")
                {
                    var sum = Math.Round(quant * 2.5, 2);
                    Console.WriteLine(sum);
                }
                else if (produce == "apple")
                {
                    var sum = Math.Round(quant * 1.2, 2);
                    Console.WriteLine(sum);
                }
                else if (produce == "orange")
                {
                    var sum = Math.Round(quant * 0.85, 2);
                    Console.WriteLine(sum);
                }
                else if (produce == "grapefruit")
                {
                    var sum = Math.Round(quant * 1.45, 2);
                    Console.WriteLine(sum);
                }
                else if (produce == "kiwi")
                {
                    var sum = Math.Round(quant * 2.7, 2);
                    Console.WriteLine(sum);
                }
                else if (produce == "pineapple")
                {
                    var sum = Math.Round(quant * 5.5, 2);
                    Console.WriteLine(sum);
                }
                else if (produce == "grapes")
                {
                    var sum = Math.Round(quant * 3.85, 2);
                    Console.WriteLine(sum);
                }
                else Console.WriteLine("error");
            }
            else if (weekEnd.Contains(weekDay))
            {
                if (produce == "banana")
                {
                    var sum = Math.Round(quant * 2.7, 2);
                    Console.WriteLine(sum);
                }
                else if (produce == "apple")
                {
                    var sum = Math.Round(quant * 1.25, 2);
                    Console.WriteLine(sum);
                }
                else if (produce == "orange")
                {
                    var sum = Math.Round(quant * 0.9, 2);
                    Console.WriteLine(sum);
                }
                else if (produce == "grapefruit")
                {
                    var sum = Math.Round(quant * 1.6, 2);
                    Console.WriteLine(sum);
                }
                else if (produce == "kiwi")
                {
                    var sum = Math.Round(quant * 3, 2);
                    Console.WriteLine(sum);
                }
                else if (produce == "pineapple")
                {
                    var sum = Math.Round(quant * 5.6, 2);
                    Console.WriteLine(sum);
                }
                else if (produce == "grapes")
                {
                    var sum = Math.Round(quant * 4.2, 2);
                    Console.WriteLine(sum);
                }
                else Console.WriteLine("error");
            }
            else Console.WriteLine("error");
        }
    }
}
