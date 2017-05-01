using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddEvenPosition
{
    public class OddEvenPosition
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            double maxEven = double.MinValue, maxOdd = double.MinValue,
                   minEven = double.MaxValue, minOdd = double.MaxValue, 
                   sumEven = 0, sumOdd = 0;

            for (int i = 1; i <= count; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)//even
                {
                    if (maxEven < num)
                    {
                        maxEven = num;
                    }
                    else if (minEven > num)
                    {
                        minEven = num;
                    }

                    sumEven += num;
                }
                else //odd
                {
                    if (maxOdd < num)
                    {
                        maxOdd = num;
                    }
                    else if (minOdd > num)
                    {
                        minOdd = num;
                    }

                    sumOdd += num;
                }
            }

            Console.WriteLine("OddSum={0},", sumOdd);
            /*  if (sumOdd != 0)
             {
                 Console.WriteLine("OddMin={0},", minOdd);
                 Console.WriteLine("OddMax={0},", maxOdd);
             }
             else
             {
                 Console.WriteLine("OddMin=No,");
                 Console.WriteLine("OddMax=No");
             }*/

            if (minOdd != double.MaxValue)
             {
                 Console.WriteLine("OddMin={0},", minOdd);
             }
             else
             {
                 Console.WriteLine("OddMin=No,");
             }
             if (maxOdd != double.MinValue)
             {
                 Console.WriteLine("OddMax={0},", maxOdd);
             }
             else
             {
                 Console.WriteLine("OddMax=No,");
             }
             

            Console.WriteLine("EvenSum={0},", sumEven);
            if (minEven != 1000000000.0)
            {
                Console.WriteLine("EvenMin={0},", minEven);
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
            }
            if (maxEven != -1000000000.0)
            {
                Console.WriteLine("EvenMax={0}", maxEven);
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
