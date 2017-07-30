namespace _11.Inferno_Infinity.Entities.Gems
{
    using Enums;

    public class Emerald : Gem
    {
        private const int EmeraldStrength = 1;
        private const int EmeraldAgility = 4;
        private const int EmeraldVitality = 9;

        public Emerald(ClarityLevel clarity) 
            : base(EmeraldStrength, EmeraldAgility, EmeraldVitality, clarity)
        {
        }
    }
}