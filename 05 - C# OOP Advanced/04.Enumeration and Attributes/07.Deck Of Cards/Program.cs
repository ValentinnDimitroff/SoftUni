namespace _07.Deck_Of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Enums;

    public class Program
    {
        public static void Main()
        {
            IEnumerable<CardSuit> allSuits = Enum.GetValues(typeof(CardSuit)).Cast<CardSuit>();
            IEnumerable<CardRank> allRanks = Enum.GetValues(typeof(CardRank)).Cast<CardRank>();

            
        }
    }
}
