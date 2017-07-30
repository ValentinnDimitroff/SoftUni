namespace _02.Card_Rank
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Card Ranks:");
            foreach (var cardValue in Enum.GetValues(typeof(CardRank)))
            {
                Console.WriteLine($"Ordinal value: {(int)cardValue}; Name value: {cardValue}");
            }
        }
    }
}
