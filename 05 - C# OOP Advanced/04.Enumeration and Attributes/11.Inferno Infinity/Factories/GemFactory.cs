namespace _11.Inferno_Infinity.Factories
{
    using System;
    using Entities.Gems;
    using Enums;
    using Interfaces;

    public class GemFactory
    {
        public IGem ProduceGem(string typeAndClarity)
        {
            string[] gemTokens = typeAndClarity.Split();
            ClarityLevel clarity = (ClarityLevel)Enum.Parse(typeof(ClarityLevel), gemTokens[0]);

            switch (gemTokens[1])
            {
                case "Ruby":
                    return new Ruby(clarity);
                case "Emerald":
                    return new Emerald(clarity);
                case "Amethyst":
                    return new Amethyst(clarity);
                default:
                    return null;
            }
        }
    }
}