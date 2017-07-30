namespace _11.Inferno_Infinity.Entities
{
    using Enums;
    using Interfaces;

    public class Gem : IGem
    {
        private int strength;
        private int agility;
        private int vitality;

        public Gem(int strength, int agility, int vitality, ClarityLevel clarity)
        {
            this.Strength = strength;
            this.Agility = agility;
            this.Vitality = vitality;
            this.Clarity = clarity;
        }

        public int Strength
        {
            get => this.strength + (int) this.Clarity;
            set => this.strength = value;
        }

        public int Agility
        {
            get => this.agility + (int)this.Clarity;
            set => this.agility = value;
        }

        public int Vitality
        {
            get => this.vitality + (int)this.Clarity;
            set => this.vitality = value;
        }

        public ClarityLevel Clarity { get; }
    }
}