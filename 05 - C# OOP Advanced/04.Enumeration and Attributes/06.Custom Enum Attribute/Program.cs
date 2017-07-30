namespace _06.Custom_Enum_Attribute
{
    using System;
    using Enums;

    public class Program
    {
        public static void Main()
        {
            string enumTypeStr = Console.ReadLine();

            Type enumType = null;
            if (enumTypeStr == "Rank")
            {
                enumType = typeof(CardRank);
            }
            else if (enumTypeStr == "Suit")
            {
                enumType = typeof(CardSuit);
            }

            var customAttributes = enumType.GetCustomAttributes(false);

            foreach (TypeAttribute customAttribute in customAttributes)
            {
                Console.WriteLine($"Type = {customAttribute.Type}, Description = {customAttribute.Description}");
            }
        }
    }
}
