namespace _05.Card_CompareTo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Enums;

    public class Program
    {
        public static void Main(string[] args)
        {
            SortedSet<Card> allCards = new SortedSet<Card>();
            for (int i = 0; i < 2; i++)
            {
                CardRank cardsRank = (CardRank)Enum.Parse(typeof(CardRank), Console.ReadLine());
                CardSuit cardsSuit = (CardSuit)Enum.Parse(typeof(CardSuit), Console.ReadLine());
                allCards.Add(new Card(cardsRank, cardsSuit));
            }

            Console.WriteLine(allCards.Last());
        }
    }
}
