namespace CatLady
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            var cats = new List<Cat>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var tokens = inputLine.Split(' ');

                switch (tokens[0])
                {
                    case "Siamese":
                        cats.Add(new Siamese(tokens[1], int.Parse(tokens[2])));
                        break;
                    case "Cymric":
                        cats.Add(new Cymric(tokens[1], double.Parse(tokens[2])));
                        break;
                    case "StreetExtraordinaire":
                        cats.Add(new StreetExtraordinaire(tokens[1], int.Parse(tokens[2])));
                        break;
                }
            }

            var catsNameToShow = Console.ReadLine();
            Console.WriteLine(cats.FirstOrDefault(c => c.Name == catsNameToShow));
        }
    }
}
