using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Journey
{
    public class Program
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string destination = "";
            string vacation = "";
            double spentMoney = 0;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    spentMoney = budget * 30 / 100;
                }
                else if (season == "winter")
                {
                    spentMoney = budget * 70 / 100;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spentMoney = budget * 40 / 100;
                }
                else if (season == "winter")
                {
                    spentMoney = budget * 80 / 100;
                }
            }
            else
            {
                destination = "Europe";
                spentMoney = budget * 90 / 100;
            }

            if (season == "summer" && budget <= 1000)
            {
                vacation = "Camp";
            }
            else
            {
                vacation = "Hotel";
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:f2}", vacation, spentMoney);
        }
    }
}
