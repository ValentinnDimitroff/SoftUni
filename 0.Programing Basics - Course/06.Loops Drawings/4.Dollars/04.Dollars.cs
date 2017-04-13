using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Dollars
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("$");
                for (int row = 1; row < i; row++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine("");
            }
        }
    }
}
