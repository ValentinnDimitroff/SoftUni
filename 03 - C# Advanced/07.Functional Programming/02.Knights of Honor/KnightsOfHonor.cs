using System;
using System.Linq;
using System.Runtime.InteropServices;

public class KnightsOfHonor
{
    public static void Main()
    {
        Action<string, string> print = (pref, s) => Console.WriteLine(pref + " " + s);
        var names = Console.ReadLine().Split();
        PrintNamesWithPrep(names, "Sir", print);
    }

    private static void PrintNamesWithPrep(string[] names, string prefix, Action<string, string> action)
    {
        foreach (var name in names)
        {
            action(prefix,name);
        }
    }
}
