using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _09.StackFibonacci
{
    public class Program
    {
        public static void Main()
        {
            var nthNumber = long.Parse(Console.ReadLine());

            var fibonacciNumbers = new Stack<ulong>();
            fibonacciNumbers.Push(0);
            if(nthNumber > 0) fibonacciNumbers.Push(1);

            if (nthNumber >= 2)
            {
                for (long i = 1; i < nthNumber; i++)
                {
                    var firstNumber = fibonacciNumbers.Pop();
                    var secondNumber = fibonacciNumbers.Pop();
                    fibonacciNumbers.Push(firstNumber);
                    fibonacciNumbers.Push(firstNumber + secondNumber);
                }
            }           

            Console.WriteLine(fibonacciNumbers.Peek());
        }
    }
}
