using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            double sumTemp = 0, sumLast = 0, maxDiff = 0;

            for (int i = 1; i <= count*2; i++)
            {
                var num = double.Parse(Console.ReadLine());
                sumTemp = sumTemp + num;

                if (i % 2 == 0)
                {
                    if (maxDiff < Math.Abs(sumTemp - sumLast) && i >= 4)
                    {
                        maxDiff = Math.Abs(sumTemp - sumLast);
                    }
                    sumLast = sumTemp;
                    sumTemp = 0;
                }
            }
            if (maxDiff == 0)//all the same
            {
                Console.WriteLine("Yes, value={0}",sumLast);
            }
            else//diff
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
