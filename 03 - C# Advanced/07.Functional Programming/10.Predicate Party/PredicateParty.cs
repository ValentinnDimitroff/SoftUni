using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _10.Predicate_Party
{
    public static class PredicateParty
    {
        public static void Main()
        {
            var guests = Console.ReadLine()
                .Split(' ').ToList();

            var line = Console.ReadLine();
            while (line != "Party!")
            {
                var actionTokens = line
                    .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
                var action = actionTokens[0];
                var criteria = actionTokens[1];
                var criteriaParam = actionTokens[2];

                switch (criteria)
                {
                    case "StartsWith":
                        guests = guests.ApplyAction(action, str => str.StartsWith(criteriaParam));
                        break;
                    case "EndsWith":
                        guests = guests.ApplyAction(action, str => str.EndsWith(criteriaParam));
                        break;
                    case "Length":
                        guests = guests.ApplyAction(action, str => str.Length == int.Parse(criteriaParam));
                        break;
                }

                line = Console.ReadLine();
            }

            var output = String.Empty;
            if (guests.Count > 0)
                output = string.Join(", ", guests) + " are going to the party!";
            else
                output = "Nobody is going to the party!";

            Console.WriteLine(output);
        }

        public static List<string> ApplyAction(this List<string> guests, string action, Func<string, bool> filter)
        {
            var result = new List<string>(guests);
            foreach (var guest in guests)
            {
                if (filter(guest))
                {
                    if (action == "Double")
                    {
                        result.Insert(result.IndexOf(guest), guest);
                    }
                    else if (action == "Remove")
                    {
                        result.Remove(guest);
                    }
                }
            }
            
            return result;
        }
    }
}
