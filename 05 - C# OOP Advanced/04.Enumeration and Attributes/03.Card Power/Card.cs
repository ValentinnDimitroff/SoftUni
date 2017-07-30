namespace _03.Card_Power
{
    using System;

    public class Card 
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

        public override string ToString()
        {
            return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.Power}";
        }
    }
}
