using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumber
{
    public class MinNumber
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            double minNum = int.MaxValue;

            for (int i = 1; i <= count; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < minNum)
                {
                    minNum = num;
                }
            }

            Console.WriteLine(minNum);
        }
    }
}
