using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Find_Even_or_Odds
{
    public class FindEvensOrOdds
    {
        public static void Main()
        {
            var range = Console.ReadLine()
                .Split(new[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var command = Console.ReadLine();

            //List<int> numbers;
            //if (command == "odd")
            //    numbers = Enumerable.Range(range[0], range[1] - range[0] + 1).Where(n => n % 2 != 0).ToList();
            //else
            //    numbers = Enumerable.Range(range[0], range[1] - range[0] + 1).Where(n => n % 2 == 0).ToList();

            //Console.WriteLine(string.Join(" ", numbers));

            Predicate<int> isEven = n => n % 2 == 0;
            var numbers = Enumerable.Range(range[0], range[1] - range[0] + 1).ToList();
            PrintNumbers(command, numbers, isEven);
        }

        private static void PrintNumbers(string command, List<int> numbers, Predicate<int> isEven)
        {
            var result = new List<int>();
            foreach (var number in numbers)
                if (isEven(number) && command == "even")
                    result.Add(number);
                else if (!isEven(number) && command == "odd")
                    result.Add(number);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}