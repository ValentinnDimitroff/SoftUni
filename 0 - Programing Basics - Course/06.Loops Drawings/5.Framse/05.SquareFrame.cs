using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Framse
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {    
                if (i == 1 || i == n)
                {
                    Console.Write("+");
                    for (int col = 0; col <= n-3; col++)
                        Console.Write(" -");
                    Console.Write(" +");
                }
                else
                {
                    Console.Write("|");
                    for (int col = 0; col <= n - 3; col++)
                        Console.Write(" -");
                    Console.Write(" |");
                }
                Console.WriteLine();
            }
        }
    }
}
