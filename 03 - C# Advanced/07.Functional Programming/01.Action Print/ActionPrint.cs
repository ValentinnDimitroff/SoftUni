﻿using System;

public class ActionPrint
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split();
        PrintAction(names, x => Console.WriteLine(x));
    }

    static void PrintAction(string[] names, Action<string> action)
    {
        foreach (var name in names)
        {
            action(name);
        }
    }
}