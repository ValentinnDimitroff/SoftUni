using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NumberPyramid
{
    public class Program
    {
        public static void Main()
        {
            int maximumNumberToPrint = int.Parse(Console.ReadLine());

            int currentNumberToPrint = 1;
            int numbersToPrintCount = 1;
            while (currentNumberToPrint <= maximumNumberToPrint)
            {
                for (int i = 0; i < numbersToPrintCount; i++)
                {
                    Console.Write("{0} ", currentNumberToPrint);
                    currentNumberToPrint++;
                    if (currentNumberToPrint > maximumNumberToPrint)
                    {
                        break;
                    }

                }
                numbersToPrintCount++;
                Console.WriteLine();
            }
        }
    }
}
