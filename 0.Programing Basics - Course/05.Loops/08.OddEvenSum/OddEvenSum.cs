using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    public class OddEvenSum
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            double sumEven = 0, sumOdd = 0;

            for (int i = 1; i <= count; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (i % 2 == 0) //even
                {
                    sumEven = sumEven + num;
                }
                else if (i % 2 != 0) //odd
                {
                    sumOdd = sumOdd + num;
                }
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes \nSum = {0}", sumEven);
            }
            else
            {
                Console.WriteLine("No \nDiff = {0}", Math.Abs(sumEven - sumOdd));
            }
        }
    }
}
