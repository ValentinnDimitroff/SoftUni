using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumbersInRangeOf1To100
{
    public class Program
    {
        public static void Main()
        {
            int number = 0;
            bool isInvalidNumber = false;
            do
            {
                Console.Write("Enter a number in the range [1...100]: ");
                number = int.Parse(Console.ReadLine());
                isInvalidNumber = number < 1 || number > 100;
            }
            while (isInvalidNumber);

            Console.WriteLine("The number is: {0}",number);
        }
    }
}
