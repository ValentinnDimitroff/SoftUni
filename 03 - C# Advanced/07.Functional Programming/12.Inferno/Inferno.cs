using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

public class Inferno
{
    public static List<int> gems;
    public static void Main()
    {
        gems = Console.ReadLine()
            .Split(' ')
            .Select(Int32.Parse)
            .ToList();
        var predicates = new Dictionary<string, Dictionary<int, Func<int, bool>>>();

        var nextCommand = Console.ReadLine();
        while (nextCommand != "Forge")
        {
            var commandTokens = nextCommand.Split(';');
            var command = commandTokens[0];
            var filterType = commandTokens[1];
            var filterParam = Int32.Parse(commandTokens[2]);

            Func<int, bool> predicate = GetFunc(filterType, filterParam);
            if (command == "Exclude")
            {
                if (!predicates.ContainsKey(filterType))
                {
                    predicates[filterType] = new Dictionary<int, Func<int, bool>>();
                }
                predicates[filterType].Add(filterParam, predicate);
            }
            else
            {
                predicates[filterType].Remove(filterParam);
            }
            nextCommand = Console.ReadLine();
        }
        gems = Filter(gems, predicates);
        Console.WriteLine(String.Join(" ", gems));
    }

    public static List<int> Filter(List<int> gems,
        Dictionary<string, Dictionary<int, Func<int, bool>>> predicates)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < gems.Count; i++)
        {
            bool filtered = false;
            foreach (var filter in predicates)
            {
                foreach (var func in filter.Value)
                {
                    if (func.Value(i))
                    {
                        filtered = true;
                        break;
                    }
                }
            }
            if (!filtered)
            {
                result.Add(gems[i]);
            }
        }
        return result;
    }

    public static Func<int, bool> GetFunc(string filterType, int filterParam)
    {
        switch (filterType)
        {
            case "Sum Left":
                return x => (x - 1 < 0 ? 0 : gems[x - 1]) + gems[x] == filterParam;
            case "Sum Right":
                return x => gems[x] + (x + 1 >= gems.Count ? 0 : gems[x + 1]) == filterParam;
            case "Sum Left Right":
                return x => (x - 1 < 0 ? 0 : gems[x - 1]) + gems[x] + (x + 1 >= gems.Count ? 0 : gems[x + 1]) == filterParam;
            default:
                return null;
        }
    }
}

