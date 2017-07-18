namespace _06.Birthday_Celebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var celebrators = new List<IBirthable>();
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var tokens = inputLine.Split(' ');
                if (tokens[0] == "Pet")
                {
                    celebrators.Add(new Pet(tokens[1], tokens[2]));
                }
                else if (tokens[0] == "Citizen")
                {
                        celebrators.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
                }
            }

            var yearToFilter = Console.ReadLine();
            foreach (var celebartor in celebrators.Where(c => c.Birthdate.EndsWith(yearToFilter)))
            {
                Console.WriteLine(celebartor.Birthdate);
            }
        }
    }
}
