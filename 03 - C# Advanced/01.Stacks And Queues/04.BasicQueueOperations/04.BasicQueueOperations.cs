using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputParams = Console.ReadLine()
                   .Split(new[] { ' ' },
                   StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

            var count = inputParams[0];
            var dequeueTimes = inputParams[1];
            var valueToCheck = inputParams[2];

            var inputNumbers = Console.ReadLine()
                .Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>();

            foreach (var number in inputNumbers)
            {
                queue.Enqueue(number);
            }
            for (int i = 0; i < dequeueTimes; i++)
            {
                queue.Dequeue();
            }
            var result = queue.ToArray();

            if (result.Contains(valueToCheck))
                Console.WriteLine("true");
            else
            {
                if (result.Length > 0)
                    Console.WriteLine(result.Min());
                else Console.WriteLine("0");
            }
        }
    }
}
