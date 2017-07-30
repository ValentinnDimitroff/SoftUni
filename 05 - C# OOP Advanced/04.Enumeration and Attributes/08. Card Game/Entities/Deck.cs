namespace _08.Card_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Enums;

    public class Deck
    {
        private readonly ICollection<Card> cards;

        public Deck()
        {
            this.cards = new List<Card>();

            IEnumerable<CardSuit> allSuits = Enum.GetValues(typeof(CardSuit)).Cast<CardSuit>();
            IEnumerable<CardRank> allRanks = Enum.GetValues(typeof(CardRank)).Cast<CardRank>();

            foreach (var cardSuit in allSuits)
            {
                foreach (var cardRank in allRanks)
                {
                    this.cards.Add(new Card(cardRank.ToString(), cardSuit.ToString()));
                }
            }
        }

        public void PullCard(Card wantedCard)
        {
            if (this.cards.Contains(wantedCard))
            {
                this.cards.Remove(wantedCard);
                return;
            }

            throw new ArgumentException("Card is not in the deck.");
        }
    }
}
