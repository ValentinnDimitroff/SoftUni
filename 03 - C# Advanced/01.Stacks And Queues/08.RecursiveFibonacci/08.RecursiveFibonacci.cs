using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RecursiveFibonacci
{
    public class Program
    {
        private static long[] fibNumbers;
        public static void Main()
        {
            var nthNumber = int.Parse(Console.ReadLine());
            fibNumbers = new long[nthNumber];
            Console.WriteLine(GetFibonacci(nthNumber));
        }

        public static long GetFibonacci(int nthNumber)
        {
            if (nthNumber <= 2) return 1;
            if (fibNumbers[nthNumber - 1] != 0)
            {
                return fibNumbers[nthNumber - 1];
            }

            return fibNumbers[nthNumber - 1] = GetFibonacci(nthNumber - 1) + GetFibonacci(nthNumber - 2);
        }
    }
}
