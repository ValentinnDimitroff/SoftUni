using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BasicStackOperation
{
    public class Program
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine()
                .Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var count = inputParams[0];
            var popTimes = inputParams[1];
            var valueToCheck = inputParams[2];

            var inputNumbers = Console.ReadLine()
                .Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();
            foreach (var number in inputNumbers)
            {
                stack.Push(number);
            }

            for (int i = 0; i < popTimes; i++)
            {
                stack.Pop();
            }
            var result = stack.ToArray();

            if (result.Contains(valueToCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (result.Length != 0)
                {
                    Console.WriteLine(result.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
