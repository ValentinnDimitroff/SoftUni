namespace _08.Card_Game
{
    using System.Collections.Generic;
    using System.Linq;

    public class Player
    {
        private readonly SortedSet<Card> hand;

        public Player(string name)
        {
            this.Name = name;
            this.hand = new SortedSet<Card>();
        }

        public string Name { get; set; }

        public void CollectCard(Card card)
        {
            this.hand.Add(card);
        }

        public Card GetHighestCard()
        {
            return this.hand.Last();
        }
    }
}
