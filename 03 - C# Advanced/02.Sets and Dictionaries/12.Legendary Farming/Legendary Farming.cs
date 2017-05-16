using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Legendary_Farming
{
    public class Legendary_Farming
    {
        public static void Main()
        {
            string[] usefulResources = { "shards", "motes", "fragments" };
            string[] items = { "Shadowmourne", "Dragonwrath", "Valanyr" };
            var mainResources = new Dictionary<string, int>();
            foreach (var item in usefulResources)
            {
                mainResources.Add(item, 0);
            }
            var junk = new SortedDictionary<string, int>();
            var quantity = 0;
            var index = -1;

            while (index == -1)
            {
                var resources = Console.ReadLine()
                .ToLower()
                .Split();
                for (int i = 0; i < resources.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        if (usefulResources.Contains(resources[i]))
                        {
                            if (mainResources.ContainsKey(resources[i]))
                            {
                                mainResources[resources[i]] += quantity;
                            }
                            
                            if (mainResources[resources[i]] >= 250)
                            {
                                index = Array.IndexOf(usefulResources, resources[i], 0);
                                mainResources[resources[i]] -= 250;
                                break;
                            }
                        }
                        else
                        {
                            if (junk.ContainsKey(resources[i]))
                            {
                                junk[resources[i]] += quantity;
                            }
                            else
                            {
                                junk[resources[i]] = quantity;
                            }
                        }
                    }
                    else
                    {
                        quantity = int.Parse(resources[i]);
                    }
                }
            }
            
            Console.WriteLine($"{items[index]} obtained!");

            mainResources = mainResources
                .OrderByDescending(resource => resource.Value)
                .ThenBy(resource => resource.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            
            foreach (var resource in mainResources)
            {
                Console.WriteLine($"{resource.Key}: {resource.Value}");
            }
            foreach (var resource in junk)
            {
                Console.WriteLine($"{resource.Key}: {resource.Value}");
            }
        }
    }
}
