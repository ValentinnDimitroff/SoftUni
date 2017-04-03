using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxNumber
{
    public class MaxNumber
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            double maxNum = int.MinValue;

            for (int i = 1; i <= count; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            Console.WriteLine(maxNum);
        }
    }
}
