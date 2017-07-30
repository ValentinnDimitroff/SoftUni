namespace _03.Card_Power
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            CardRank cardsRank = (CardRank)Enum.Parse(typeof(CardRank), Console.ReadLine());
            CardSuit cardsSuit = (CardSuit)Enum.Parse(typeof(CardSuit), Console.ReadLine());

            Card myCard = new Card(cardsRank, cardsSuit);
            Console.WriteLine(myCard);
        }
    }
}
