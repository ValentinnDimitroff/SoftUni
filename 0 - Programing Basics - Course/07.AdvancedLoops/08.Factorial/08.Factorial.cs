using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
