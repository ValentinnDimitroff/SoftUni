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

        Func<int[], int> getSmallest = n => n.Min();
        Console.WriteLine(getSmallest(numbers));
    }
}