using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.InvalidNumber
{
    public class Program
    {
        public static void Main()
        {
            double num = double.Parse(Console.ReadLine());

            if ((num < 100 || num > 200) && num != 0)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
