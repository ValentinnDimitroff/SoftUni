using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CheckPrime
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;
            if (number < 2)
            {
                isPrime = false;
            }
            else
            {
                int upperBoundaryToCheck = (int)Math.Sqrt(number);

                for (int i = 2; i <= upperBoundaryToCheck; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
