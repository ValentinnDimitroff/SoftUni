using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Population_Counter
{
    public class Population_Counter
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var countries = new Dictionary<string, Dictionary<string, long>>();

            while (line != "report")
            {
                var inputParams = line.Split('|');
                var city = inputParams[0];
                var country = inputParams[1];
                long population = long.Parse(inputParams[2]);

                if (countries.ContainsKey(country))
                {
                    countries[country].Add(city, population);
                }
                else
                {
                    countries[country] = new Dictionary<string, long>{ { city, population } };
                }

                line = Console.ReadLine();
            }

            var orderedCountries = countries.OrderByDescending(country => country.Value.Values.Sum());

            foreach (var country in orderedCountries)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                var cities = country.Value.OrderByDescending(city => city.Value);
                foreach (var city in cities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
