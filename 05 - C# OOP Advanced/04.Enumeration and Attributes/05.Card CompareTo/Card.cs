namespace _05.Card_CompareTo
{
    using System;
    using Enums;

    public class Card : IComparable<Card>
    {
        public Card(CardRank rank, CardSuit suit)
        {
            this.Suit = suit;
            this.Rank = rank;
            this.Power = (int)suit + (int)rank;
        }

        public CardSuit Suit { get; set; }

        public CardRank Rank { get; set; }

        public int Power { get; set; }

        public int CompareTo(Card other)
        {
            return this.Power.CompareTo(other.Power);
        }

        public override string ToString()
        {
            return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.Power}";
        }
    }
}
