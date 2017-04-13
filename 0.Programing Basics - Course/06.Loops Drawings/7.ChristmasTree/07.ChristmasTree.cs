using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ChristmasTree
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));                
                Console.Write(new string('*', i));                
                Console.Write(" | ");
                Console.Write(new string('*', i));
                Console.WriteLine();
            }
        }
    }
}
