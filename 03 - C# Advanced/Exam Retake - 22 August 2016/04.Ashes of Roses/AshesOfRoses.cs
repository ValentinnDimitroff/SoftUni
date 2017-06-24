using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class AshesOfRoses
{
    public static void Main()
    {
        var regionsInfo = new Dictionary<string, Dictionary<string, long>>();
        var rgx = new Regex(@"^Grow <([A-Z][a-z]+)> <([a-zA-Z\d]+)> (\d+)$");

        string input;
        while ((input = Console.ReadLine()) != "Icarus, Ignite!")
        {
            var currentRegion = rgx.Match(input);
            if (!currentRegion.Success)
            {
                continue;
            }
                
            var regionName = currentRegion.Groups[1].Value;
            var color = currentRegion.Groups[2].Value;
            var count = int.Parse(currentRegion.Groups[3].Value);

            if (!regionsInfo.ContainsKey(regionName))
            {
                regionsInfo[regionName] = new Dictionary<string, long>();
            }
            if (!regionsInfo[regionName].ContainsKey(color))
            {
                regionsInfo[regionName].Add(color, 0);
            }
            regionsInfo[regionName][color] += count;
        }

        var orderedRegions = regionsInfo.OrderByDescending(reg => reg.Value.Sum(col => col.Value));
        foreach (var region in orderedRegions)
        {
            Console.WriteLine(region.Key);
            foreach (var color in region.Value.OrderBy(type => type.Value))
            {
                Console.WriteLine($"*--{color.Key} | {color.Value}");
            }
        }
    }
}

