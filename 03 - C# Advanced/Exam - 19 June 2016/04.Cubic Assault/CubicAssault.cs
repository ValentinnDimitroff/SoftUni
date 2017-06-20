using System;
using System.Collections.Generic;
using System.Linq;

public class CubicAssault
{
    public static List<string> meteorTypes = new List<string>() { "Green", "Red", "Black" };
    public const int ConvertTreshold = 1_000_000;
    public static void Main()
    {
        var meteors = new Dictionary<string, Dictionary<string, long>>();
        var meteorInfo = Console.ReadLine();
        while (meteorInfo != "Count em all")
        {
            var regionTokens = meteorInfo.Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
            var regionName = regionTokens[0];
            var meteorType = regionTokens[1];
            var meteorCount = int.Parse(regionTokens[2]);

            if (!meteors.ContainsKey(regionName))
            {
                meteors[regionName] = new Dictionary<string, long>() {{"Green", 0}, {"Red", 0}, {"Black", 0}};
            }

            meteors[regionName][meteorType] += meteorCount;
           
            for (int i = 0; i < meteorTypes.Count - 1; i++)
            {
                var nextTypeCount = meteors[regionName][meteorTypes[i]] / ConvertTreshold;
                if (nextTypeCount > 0)
                {
                    meteors[regionName][meteorTypes[i]] %= ConvertTreshold;
                    meteors[regionName][meteorTypes[i + 1]] += nextTypeCount;
                }
            }

            meteorInfo = Console.ReadLine();
        }

        var orderedMeteors = meteors
            .OrderByDescending(m => m.Value["Black"])
            .ThenBy(m => m.Key.Length)
            .ThenBy(m => m.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        PrintMeteors(orderedMeteors);
    }

    private static void PrintMeteors(Dictionary<string, Dictionary<string, long>> meteors)
    {
        foreach (var region in meteors)
        {
            Console.WriteLine(region.Key);
            foreach (var meteor in region.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($" -> {meteor.Key} : {meteor.Value}");
            }
        }
    }
}