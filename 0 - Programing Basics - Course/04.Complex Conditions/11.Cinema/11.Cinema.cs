using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string price = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            switch (price)
            {
                case "Premiere":
                    Console.WriteLine("{0:f2} leva", row * col * 12);
                    break;
                case "Normal":
                    Console.WriteLine("{0:f2} leva", row * col * 7.5);
                    break;
                case "Discount":
                    Console.WriteLine("{0:f2} leva", row * col * 5);
                    break;
            }
        }
    }
}
