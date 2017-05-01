using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumNumbers
{
    public class SumNumbers
    {
        public static void Main()
        {
            double count = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= count; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
