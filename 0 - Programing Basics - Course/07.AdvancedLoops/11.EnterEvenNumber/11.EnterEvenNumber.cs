using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    public class Program
    {
        public static void Main()
        {
            int number = 0;
            bool isInvalidNumber = false;
            do
            {
                try
                {
                    isInvalidNumber = false;
                    Console.Write("Enter even number: ");
                    number = int.Parse(Console.ReadLine());

                    if (Math.Abs(number % 2) == 1)
                    {
                        Console.WriteLine("The number is not even");
                        isInvalidNumber = true;
                    }
                }
                catch (Exception)
                {
                    isInvalidNumber = true;
                    Console.WriteLine("Invalid number!");
                }
            }
            while (isInvalidNumber);

            Console.WriteLine("Even number entered: {0}", number);
        }
    }
}
