namespace _01.Card_Suit
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Card Suits:");
            foreach (var cardValue in Enum.GetValues(typeof(Card)))
            {
                Console.WriteLine($"Ordinal value: {(int)cardValue}; Name value: {cardValue}");
            }
        }
    }
}
