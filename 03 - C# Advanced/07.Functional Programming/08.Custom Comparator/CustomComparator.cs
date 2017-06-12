using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CustomComparator
{
    public static void Main()
    {
        var numbers = ReadNumbersSequence().ToArray();

        //Array.Sort(numbers, new Comparator());
        Array.Sort(numbers,(x, y) => {
            if (x % 2 == 0 && y % 2 != 0)
            {
                return -1;
            }
            if (x % 2 != 0 && y % 2 == 0)
            {
                return 1;
            }
            if (x < y)
            {
                return -1;
            }
            if (x > y)
            {
                return 1;
            }

            return 0;
        });
        Console.WriteLine(string.Join(" ", numbers));
    }
    private static IEnumerable<int> ReadNumbersSequence()
    {
        var range = Console.ReadLine()
            .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);

        return range;
    }
}

public class Comparator :IComparer<int>
{
    public int Compare(int x, int y)
    {
        if (x % 2 == 0 && y % 2 != 0)
        {
            return -1;
        }
        else if (x % 2 != 0 && y % 2 == 0)
        {
            return 1;
        }
        else
        {
            if (x < y)
            {
                return -1;
            }
            else if (x > y)
            {
                return 1;
            }

            return 0;
        }
    }
}