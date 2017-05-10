using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RecursiveFibonacci
{
    public class Program
    {
        public static void Main()
        {
            var nthNumber = int.Parse(Console.ReadLine());
            var fibNumbers = new long[nthNumber];
            Console.WriteLine(GetFibonacci(nthNumber, fibNumbers));
        }

        public static long GetFibonacci(int nthNumber, long[] fibNumbers)
        {
            if (nthNumber <= 2) return 1;
            else if (fibNumbers[nthNumber - 1] != 0)
            {
                return fibNumbers[nthNumber - 1];
            }
            else
            {
                return fibNumbers[nthNumber - 1] = GetFibonacci(nthNumber - 1, fibNumbers) + GetFibonacci(nthNumber - 2, fibNumbers);
            }
        }
    }
}
