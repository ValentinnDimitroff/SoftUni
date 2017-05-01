using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreatestCommonDivider
{
    public class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(
                Console.ReadLine());
            int secondNumber = int.Parse(
                Console.ReadLine());

            while (secondNumber > 0)
            {
                int temp = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = temp;
            }

            Console.WriteLine(firstNumber);
        }
    }
}
