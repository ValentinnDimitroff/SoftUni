using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double oldSum = 0, maxDiff = 0;

            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double sum = a + b;

                if (oldSum > 0)
                {
                    double diff = Math.Abs(sum - oldSum);
                    if (maxDiff < diff)
                    {
                        maxDiff = diff;
                    }
                }

                oldSum = sum;
            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value={0}", oldSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
