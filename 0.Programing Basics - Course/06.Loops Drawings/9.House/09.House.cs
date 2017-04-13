using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.House
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double roof = Math.Ceiling((double)n / 2);
            double body = Math.Floor((double)n / 2);
            int stars = 1;
            if (n % 2 == 0) stars++; 

            for (int i = 1; i <= n; i++)
            {                     
                if (i <= roof)
                {                    
                    Console.Write(new string('-', (n - stars)/2));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', (n - stars)/2));
                    stars = stars + 2;                          
                }
                else//body
                {
                    Console.Write("|");
                    Console.Write(new string('*', n-2));
                    Console.Write("|");
                }
                Console.WriteLine();
            }           
        }
    }
}
