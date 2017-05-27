using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Hands_of_Cards
{
    public class Program
    {
        public static int CalculateCardScore(HashSet<string> cards)
        {
            var totalScore = 0;
            foreach (var card in cards)
            {
                var score = 0;
                var power = card.Substring(0, card.Length - 1);               
                var type = card[card.Length - 1];

                var powerIsDigit = int.TryParse(power, out score);
                if (!powerIsDigit)
                {
                    switch (power)
                    {
                        case "J": score = 11;
                            break;
                        case "Q": score = 12;
                            break;
                        case "K": score = 13;
                            break;
                        case "A": score = 14;
                            break;
                    }
                }
                switch (type)
                {
                    case 'S':
                        score *= 4;
                        break;
                    case 'H':
                        score *= 3;
                        break;
                    case 'D':
                        score *= 2;
                        break;
                    case 'c':
                        score *= 1;
                        break;
                }
                totalScore += score;
            }
            return totalScore;
        }
        public static void Main()
        {
            var playersDecks = new Dictionary<string, HashSet<string>>();
            var handout = Console.ReadLine();

            while (handout != "JOKER")
            {
                var handoutParams = handout
                    .Split(':');
                var person = handoutParams[0];
                var cards = handoutParams[1]
                    .Split(',')
                    .Select(a => a.Trim())
                    .ToArray();

                if (playersDecks.ContainsKey(person))
                {
                    playersDecks[person].UnionWith(cards);
                }
                else
                {
                    playersDecks[person] = new HashSet<string>(cards);
                }

                handout = Console.ReadLine();
            }

            foreach (var player in playersDecks)
            {
                var score = CalculateCardScore(player.Value);
                Console.WriteLine($"{player.Key}: {score}");
            }
        }
    }
}
