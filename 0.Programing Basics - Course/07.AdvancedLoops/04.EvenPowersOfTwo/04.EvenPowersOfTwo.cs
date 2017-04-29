using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EvenPowersOfTwo
{
    public class Program
    {
        public static void Main()
        {

            int number = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 0; i <= number; i += 2)
            {
                Console.WriteLine(result);
                result *= 4;
            }
        }
    }
}
