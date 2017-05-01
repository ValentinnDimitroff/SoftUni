using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    public class HalfSumElement
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            double maxNum = int.MinValue, sum = 0;

            for (int i = 1; i <= count; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (maxNum < num)
                {
                    maxNum = num;
                }
                sum += num;
            }

            if (maxNum == sum - maxNum)
            {
                Console.WriteLine("Yes \nSum = {0}", maxNum);
            }
            else
            {
                Console.WriteLine("No \nDiff = {0}", Math.Abs(maxNum - (sum - maxNum)));
            }
        }
    }
}
