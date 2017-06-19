using System;
using System.Collections.Generic;
using System.Linq;

public class CubicsRube
{
    public static void Main()
    {
        var dimension = int.Parse(Console.ReadLine());
        
        long sumOfParticles = 0;
        var cellsChanged = 0;

        var line = Console.ReadLine();
        while (line != "Analyze")
        {
            var tokens = line
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
            var pointsInside = tokens
                .Take(3)
                .Where(pt => pt < dimension && pt >= 0)
                .ToList();
            if (pointsInside.Count == 3 && tokens[3] != 0)
            {
                sumOfParticles += tokens[3];
                cellsChanged++;
            }

            line = Console.ReadLine();
        }

        Console.WriteLine(sumOfParticles);
        var res = Math.Pow(dimension, 3) - cellsChanged;
        Console.WriteLine(res);
    }
}