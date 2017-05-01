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
            var stack = new Stack<int>();
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
                        stack.Push(query[1]);
                        if (query[1] > maxValue)
                            maxValue = query[1];
                        break;
                    case 2:
                        if (stack.Peek() == maxValue)
                        {
                            stack.Pop();
                            if (stack.Count != 0)
                            {
                                maxValue = stack.Max();
                            }
                            else
                            {
                                maxValue = int.MinValue;
                            }
                        }
                        else stack.Pop();
                        break;
                    case 3:
                        Console.WriteLine(maxValue);
                        break;
                }
            }
        }
    }
}
