using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DrawFort
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int bridgeSize = 2 * n - 2 * (n/2) - 4;
            string upperTower = "/" + new string('^', n / 2) + "\\";
            Console.Write(upperTower);
            Console.Write(new string('_', bridgeSize));
            Console.WriteLine(upperTower);

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|");
                if (i == n - 3) {
                    Console.Write(new string(' ',  n/2 + 1));
                    Console.Write(new string('_', bridgeSize));
                    Console.Write(new string(' ', n / 2 + 1));
                }
                else Console.Write(new string(' ', 2 * n - 2));
                Console.WriteLine("|");
            }

            string lowerTower = "\\" + new string('_', n / 2) + "/";
            Console.Write(lowerTower);
            Console.Write(new string(' ', bridgeSize));
            Console.WriteLine(lowerTower);
        }
    }
}
