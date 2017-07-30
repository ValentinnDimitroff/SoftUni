namespace _06.Custom_Enum_Attribute.Enums
{
    [TypeAttribute(Type = "Enumeration", Category = "Suit", Description = "Provides suit constants for a Card class.")]
    public enum CardSuit
    {
        Clubs = 0,
        Diamonds = 13,
        Hearts = 26,
        Spades = 39
    }
}
