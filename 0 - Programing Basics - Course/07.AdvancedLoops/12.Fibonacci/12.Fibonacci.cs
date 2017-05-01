using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    public class Program
    {
        public static void Main()
        {
            int fibonacciNumberPosition = int.Parse(Console.ReadLine());

            switch (fibonacciNumberPosition)
            {
                case 0:
                case 1:
                    Console.WriteLine(1);
                    break;
                default:
                    int firstFibonacciNumber = 1;
                    int secondFibonacciNumber = 1;
                    int nextFibonacciNumber = 0;
                    for (int i = 2; i <= fibonacciNumberPosition; i++)
                    {
                        nextFibonacciNumber = firstFibonacciNumber + secondFibonacciNumber;

                        firstFibonacciNumber = secondFibonacciNumber;
                        secondFibonacciNumber = nextFibonacciNumber;
                    }
                    Console.WriteLine(nextFibonacciNumber);
                    break;
            }
        }
    }
}
