namespace _08.Card_Game
{
    using System;
    using Enums;

    public class Card : IComparable<Card>
    {
        public Card(string rank, string suit)
        {
            this.InitilzeSuitAndRank(rank, suit);
            this.Power = (int) this.Suit + (int) this.Rank;
        }

        public CardSuit Suit { get; set; }

        public CardRank Rank { get; set; }

        public int Power { get; set; }

        private void InitilzeSuitAndRank(string rank, string suit)
        {
            bool rankIsValid = Enum.TryParse(rank, true, out CardRank cardRank);
            bool suitIsValid = Enum.TryParse(suit, true, out CardSuit cardSuit);

            if (!suitIsValid || !rankIsValid)
            {
                throw new ArgumentException("No such card exists.");
            }

            this.Rank = cardRank;
            this.Suit = cardSuit;
        }

        public int CompareTo(Card other)
        {
            return this.Power.CompareTo(other.Power);
        }

        public override int GetHashCode()
        {
            return (int)this.Rank + (int)this.Suit;
        }

        public override bool Equals(object obj)
        {
            Card other = obj as Card;
            if (this.Suit != other.Suit)
            {
                return false;
            }

            if (this.Rank != other.Rank)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return $"{this.Rank} of {this.Suit}";
        }
    }
}