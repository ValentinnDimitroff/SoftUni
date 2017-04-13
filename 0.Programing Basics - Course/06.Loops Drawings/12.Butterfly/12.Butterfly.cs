using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char wingChar = ' ';
            for (int i = 0; i < 2 * (n - 2) + 1; i++)
            {
                if (i == n - 2) wingChar =' ';
                else if (i % 2 == 0) wingChar = '*';
                else wingChar = '-';

                Console.Write(new string(wingChar, n-2));
                if (i < n-2) Console.Write("\\ /");
                else if (i == n - 2) Console.Write(" @ ");
                else Console.Write("/ \\");
                Console.WriteLine(new string(wingChar, n - 2));
            }
        }
    }
}
