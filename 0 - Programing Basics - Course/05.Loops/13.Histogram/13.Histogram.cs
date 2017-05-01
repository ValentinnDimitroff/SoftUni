using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Histogram
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200) p1++;
                else if (number < 400) p2++;
                else if (number < 600) p3++;
                else if (number < 800) p4++;
                else p5++;
            }

            Console.WriteLine("{0:f2}%", p1 * 100.00 / n);
            Console.WriteLine("{0:f2}%", p2 * 100.00 / n);
            Console.WriteLine("{0:f2}%", p3 * 100.00 / n);
            Console.WriteLine("{0:f2}%", p4 * 100.00 / n);
            Console.WriteLine("{0:f2}%", p5 * 100.00 / n);
        }
    }
}
