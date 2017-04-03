using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    public class LeftAndRightSum
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            double sumLeft = 0, sumRight = 0;

            for (int i = 1; i <= 2 * count; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i <= count)
                {
                    sumLeft += num;
                }
                else
                {
                    sumRight += num;
                }                
            }
            
            if (sumLeft == sumRight)
            {
                Console.WriteLine("Yes, sum = {0}", sumLeft);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sumLeft - sumRight));
            }
        }
    }
}
