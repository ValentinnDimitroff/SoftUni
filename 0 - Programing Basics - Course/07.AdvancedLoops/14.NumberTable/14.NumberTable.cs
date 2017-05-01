using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.NumberTable
{
    public class Program
    {
        public static void Main()
        {
            int tableSize = int.Parse(Console.ReadLine());

            for (int tableRow = 1;  tableRow <= tableSize; tableRow++)
            {
                int numberToPrint = tableRow;
                bool isMaxNumberPrinted = false;
                for (int tableColumn = 1; tableColumn <= tableSize; tableColumn++)
                {
                    Console.Write("{0} ", numberToPrint);
                    if (numberToPrint == tableSize)
                    {
                        isMaxNumberPrinted = true;
                    }
                    if (isMaxNumberPrinted)
                    {
                        numberToPrint--;
                    }
                    else
                    {
                        numberToPrint++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
