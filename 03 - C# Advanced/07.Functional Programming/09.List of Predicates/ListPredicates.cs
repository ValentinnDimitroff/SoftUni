using System;
using System.Collections.Generic;
using System.Linq;

public class ListPredicates
{
    public static void Main()
    {
        int rangeBorder = int.Parse(Console.ReadLine());
        var dividers = ReadNumbersSequence().ToArray();

        if (rangeBorder < 0)
            return;

        var numbers = Enumerable.Range(1, rangeBorder).ToArray();
        var filteredNumbers = FilterNumbers(numbers, dividers, (x, n) => x % n == 0);

        Console.WriteLine(string.Join(" ", filteredNumbers));
    }

    private static List<int> FilterNumbers(int[] numbers, int[] dividers, Func<int, int, bool> filter)
    {
        var filteredNumbers = new List<int>();
        foreach (var number in numbers)
        {
            var isValid = true;
            foreach (var divider in dividers)
            {
                if (!filter(number, divider))
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid) filteredNumbers.Add(number);
        }

        return filteredNumbers;
    }

    private static IEnumerable<int> ReadNumbersSequence()
    {
        var range = Console.ReadLine()
            .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);

        return range;
    }
}