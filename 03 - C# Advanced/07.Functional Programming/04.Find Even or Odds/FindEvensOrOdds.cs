using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Find_Even_or_Odds
{
    public class FindEvensOrOdds
    {
        public static void Main()
        {
            var range = Console.ReadLine()
                .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var command = Console.ReadLine();

            IEnumerable<int> numbers;
            if (command == "odd")
            {
                numbers = Enumerable.Range(range[0], range[1] - range[0] + 1).Where(n => n % 2 != 0);
            }
            else
            {
                numbers = Enumerable.Range(range[0], range[1] - range[0] + 1).Where(n => n % 2 == 0);
            }

            Console.WriteLine(string.Join(" ", numbers));
            
            //Func<int, bool> isEven = n => n % 2 == 0;
            //var numbers = Enumerable.Range(range[0], range[1] - range[0] + 1);
            //PrintNumbers(command, numbers, isEven);
        }

        private static void PrintNumbers(string command, IEnumerable<int> numbers, Func<int, bool> isEven)
        {
            var result = new List<int>();
            switch (command)
            {
                case "even":
                    foreach (var number in numbers)
                    {
                        if (isEven(number))
                        {
                            result.Add(number);
                        }
                    }
                    break;
                case "odd":
                    foreach (var number in numbers)
                    {
                        if (!isEven(number))
                        {
                            result.Add(number);
                        }
                    }
                    break;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
