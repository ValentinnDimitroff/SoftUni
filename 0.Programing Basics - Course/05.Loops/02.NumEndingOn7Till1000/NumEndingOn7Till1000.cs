using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumEndingOn7Till1000
{
    public class NumEndingOn7Till1000
    {
        public static void Main()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i == 7 || (i - 7) % 10 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
