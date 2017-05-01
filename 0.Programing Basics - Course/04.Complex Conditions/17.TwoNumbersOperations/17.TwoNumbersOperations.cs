using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.TwoNumbersOperations
{
    public class Program
    {
        public static void Main()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();

            double result = 0;

            if ((action == "+") || (action == "-") || (action == "*"))
            {
                if (action == "+")
                {
                    result = n1 + n2;
                }
                else if (action == "-")
                {
                    result = n1 - n2;
                }
                else if (action == "*")
                {
                    result = n1 * n2;
                }

                if (result % 2 != 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, action, n2, result, "odd");
                }
                else Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, action, n2, result, "even");
            }
            else if (n2 != 0)
            {
                if (action == "/")
                {
                    Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, n1 / n2);
                }
                else if (action == "%")
                {
                    Console.WriteLine("{0} % {1} = {2}", n1, n2, n1 % n2);
                }
            }
            else
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
        }
    }
}
