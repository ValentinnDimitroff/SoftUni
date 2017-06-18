using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class FilterStudentsByPhone
{
    public static void Main()
    {
        var group = new List<string[]>();
        string student;

        while ((student = Console.ReadLine()) != "END")
            group.Add(student.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

        group
            .Where(s => s[2].StartsWith("02") || s[2].StartsWith("+3592"))
            .Select(s => $"{s[0]} {s[1]}")
            .ToList()
            .ForEach(s => Console.WriteLine(s));
    }
}