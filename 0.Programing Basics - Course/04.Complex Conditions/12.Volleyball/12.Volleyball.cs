using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double saturdays = (48 - h) * 3 / 4;
            double fests = p * 2 / 3;
            double sum = saturdays + h + fests;

            if (year == "leap")
            {
                Console.WriteLine("{0}", Math.Truncate((sum * 15 / 100) + sum));
            }
            else if (year == "normal")
            {
                Console.WriteLine("{0}", Math.Truncate(sum));
            }
        }
    }
}
