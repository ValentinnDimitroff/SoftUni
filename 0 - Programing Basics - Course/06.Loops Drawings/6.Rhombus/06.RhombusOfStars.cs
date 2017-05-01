using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rhombus
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write("*");
                for (int star = 1; star < i; star++)
                {
                    Console.Write(" *");
                }               
                Console.WriteLine();
            }

            for (int i = n-1; i >= 1; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.Write("*");
                for (int star = 1; star < i; star++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
