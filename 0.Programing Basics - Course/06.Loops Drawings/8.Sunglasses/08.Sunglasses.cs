using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)//first,last line
                {
                    Console.Write(new string('*', n * 2));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', n * 2));
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write("*");

                    for (int col = 1; col <= n; col++)
                    {
                        double fr = Math.Ceiling((double)(n - 2) / 2);
                        if (i == fr + 1)
                        {
                            Console.Write("|");
                        }
                        else Console.Write(" ");
                    }

                    Console.Write("*");
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
