namespace _08.Card_Game
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Enums;

    public class Program
    {
        private const int CardsPerPlayer = 5;

        public static void Main(string[] args)
        {
            Deck allCardsDeck = new Deck();
            Player firstPlayer = new Player(Console.ReadLine());
            Player secondPlayer = new Player(Console.ReadLine());

            int drawnCards = 0;
            while (drawnCards < CardsPerPlayer * 2)
            {
                string[] cardTokens = Console.ReadLine()
                    .Split(new[] {"of"}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => a.Trim())
                    .ToArray();
                try
                {
                    Card currentCard = new Card(cardTokens[0], cardTokens[1]);
                    allCardsDeck.PullCard(currentCard);

                    if (drawnCards < CardsPerPlayer)
                    {
                        firstPlayer.CollectCard(currentCard);
                        drawnCards++;
                    }
                    else
                    {
                        secondPlayer.CollectCard(currentCard);
                        drawnCards++;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Player winner;
            if (firstPlayer.GetHighestCard().CompareTo(secondPlayer.GetHighestCard()) > 0)
            {
                winner = firstPlayer;
            }
            else
            {
                winner = secondPlayer;
            }

            Console.WriteLine($"{winner.Name} wins with {winner.GetHighestCard()}.");
        }
    }
}