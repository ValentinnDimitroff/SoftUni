using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumDigits
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int digitsSum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                digitsSum += lastDigit;
                number /= 10;
            }

            Console.WriteLine(digitsSum);
        }
    }
}
