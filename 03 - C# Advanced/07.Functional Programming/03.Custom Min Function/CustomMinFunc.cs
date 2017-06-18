using System;
using System.Linq;

public class CustomMinFunc
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new []{' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Func<int[], int> getSmallest = n =>
        {
            int min = int.MaxValue;
            foreach (var i in n)
            {
                if (min > i)
                {
                    min = i;
                }
            }
            return min;
        };
        Console.WriteLine(getSmallest(numbers));
    }
}