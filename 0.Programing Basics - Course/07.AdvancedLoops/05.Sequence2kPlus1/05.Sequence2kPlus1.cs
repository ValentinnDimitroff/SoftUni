using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence2kPlus1
{
    public class Program
    {
        public static void Main()
        {
            int sequenceUpperBound = int.Parse(Console.ReadLine());

            int currentNumber = 1;
            while (currentNumber <= sequenceUpperBound)
            {
                Console.WriteLine(currentNumber);
                currentNumber = currentNumber * 2
                    + 1;
            }
        }
    }
}
