using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Srabsko_Unleashed
{
    public class SrabskoUnleashed
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var statistics = new Dictionary<string, Dictionary<string, int>>();

            while (line != "End")
            {
                string singer = "", venue = "";
                int ticketCount = 0, ticketPrice = 0;

                int atIndex = line.IndexOf('@');
                if (atIndex > -1 && line[atIndex - 1] == ' ')
                {
                    singer = line.Substring(0, atIndex).TrimEnd();
                }
                else
                {
                    line = Console.ReadLine();
                    continue;
                }
                atIndex++;
                var venueTickets = line
                    .Substring(atIndex, line.Length - atIndex)
                    .Split();

                try
                {
                    ticketPrice = int.Parse(venueTickets[venueTickets.Length - 1]);
                    ticketCount = int.Parse(venueTickets[venueTickets.Length - 2]);
                }
                catch (Exception e)
                {
                    line = Console.ReadLine();
                    continue;
                }

                var tempVenue = new StringBuilder();
                for (int i = 0; i < venueTickets.Length - 2; i++)
                {
                    tempVenue.Append(venueTickets[i]);
                    tempVenue.Append(" ");
                }
                venue = tempVenue.ToString().TrimEnd();

                if (venue != "")
                {
                    if (statistics.ContainsKey(venue))
                    {
                        if (statistics[venue].ContainsKey(singer))
                        {
                            statistics[venue][singer] += ticketCount * ticketPrice;
                        }
                        else statistics[venue].Add(singer, ticketCount * ticketPrice);
                    }
                    else
                    {
                        statistics[venue] = new Dictionary<string, int> { { singer, ticketCount * ticketPrice } };
                    }
                }

                line = Console.ReadLine();
            }

            PrintVenues(statistics);
        }

        private static void PrintVenues(Dictionary<string, Dictionary<string, int>> statistics)
        {
            foreach (var venue in statistics)
            {
                Console.WriteLine(venue.Key);
                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
