using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Party_Reservation_Filter
{
    public class ReservationFilter
    {
        public static void Main()
        {
            var invitations = Console.ReadLine()
                .Split(' ')
                .ToList();
            var line = Console.ReadLine();
            var filters = new Dictionary<string, Dictionary<string, Func<string, bool>>>();
            while (line != "Print")
            {
                var filterTokens = line.Split(';');
                var action = filterTokens[0];
                var filterType = filterTokens[1];
                var filterParam = filterTokens[2];

                Func<string, bool> predicate = Functions.BuildPredicate(filterType, filterParam);
                if (action == "Add filter")
                {
                    if (!filters.ContainsKey(filterType))
                    {
                        filters.Add(filterType, new Dictionary<string, Func<string, bool>>());
                    }

                    if (!filters[filterType].ContainsKey(filterParam))
                    {
                        filters[filterType].Add(filterParam, predicate);
                    }
                }
                else
                {
                    filters[filterType].Remove(filterParam);
                }
                line = Console.ReadLine();
            }

            invitations = Functions.Filter(invitations, filters);
            Console.WriteLine(string.Join(" ", invitations));
        }

        public class Functions
        {
            public static List<string> Filter(List<string> collection,
                Dictionary<string, Dictionary<string, Func<string, bool>>> filters)
            {
                foreach (var filter in filters) //Types
                {
                    foreach (var func in filter.Value) //Params
                    {
                        if (!collection.Any())
                            break;
                        for (int i = collection.Count - 1; i >= 0; i--)
                        {
                            if (func.Value(collection[i]))
                            {
                                collection.Remove(collection[i]);
                            }
                        }
                    }
                }

                return collection;
            }

            public static Func<string, bool> BuildPredicate(string modifier, string variable)
            {
                switch (modifier)
                {
                    case "Starts with":
                        return x => x.StartsWith(variable);
                    case "Ends with":
                        return x => x.EndsWith(variable);
                    case "Length":
                        return x => x.Length == int.Parse(variable);
                    case "Contains":
                        return x => x.Contains(variable);
                    default:
                        return null;
                }
            }
        }
    }
}