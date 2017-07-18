namespace _05.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var entrants = new List<IIdentifiable>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var tokens = inputLine.Split(' ');
                if (tokens.Length == 2)
                {
                    entrants.Add(new Robot(tokens[0], tokens[1]));
                }
                else
                {
                    entrants.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
            }

            var lastDigits = Console.ReadLine();

            foreach (var entry in entrants.Where(e => e.Id.EndsWith(lastDigits)))
            {
                Console.WriteLine(entry.Id);
            }
        }
    }
}
