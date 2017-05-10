using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MaximumElement
{
    public class Program
    {
        public static void Main()
        {
            var countQueries = int.Parse(Console.ReadLine());
            var numbers = new Stack<int>();
            var maxNumbers = new Stack<int>();
            var maxValue = int.MinValue;

            for (int i = 0; i < countQueries; i++)
            {
                var query = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                switch (query[0])
                {
                    case 1:
                        numbers.Push(query[1]);
                        if (query[1] > maxValue)
                        {
                            maxNumbers.Push(query[1]);
                            maxValue = query[1];
                        }                            
                        break;
                    case 2:
                        if (numbers.Pop() == maxValue)
                        {
                            maxNumbers.Pop();
                            if (maxNumbers.Count != 0)
                            {
                                maxValue = maxNumbers.Peek();
                            }
                            else
                            {
                                maxValue = int.MinValue;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine(maxValue);
                        break;
                }
            }
        }
    }
}
