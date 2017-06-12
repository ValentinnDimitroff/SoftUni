using System;
using System.Collections.Generic;
using System.Linq;

public class ReverseAndExclude
    {
        public static void Main()
        {
            var numbers = ReadNumbersSequence().ToList();
            var divider = int.Parse(Console.ReadLine());
            numbers = ReverseExclude(numbers, n => n % divider == 0);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> ReverseExclude(List<int> numbers, Func<int, bool> isForExclusion)
        {
            var result = new List<int>();
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (!isForExclusion(numbers[i]))
                {
                    result.Add(numbers[i]);
                }
            }

            return result;
        }

        private static IEnumerable<int> ReadNumbersSequence()
        {
            var range = Console.ReadLine()
                .Split(new[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);

            return range;
        }
    }

