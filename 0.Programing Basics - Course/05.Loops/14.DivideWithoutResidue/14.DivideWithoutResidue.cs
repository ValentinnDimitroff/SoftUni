using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DivideWithoutResidue
{
    public class Program
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            int p1 = 0, p2 = 0, p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0) p1++;
                if (number % 3 == 0) p2++;
                if (number % 4 == 0) p3++;
            }

            Console.WriteLine("{0:f2}%", p1 * 100.00 / n);
            Console.WriteLine("{0:f2}%", p2 * 100.00 / n);
            Console.WriteLine("{0:f2}%", p3 * 100.00 / n);
        }
    }
}
