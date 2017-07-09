namespace Paws_Inc.Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, int intelligenceCoefficient, string adoptionCenterName)
            : base(name, age, adoptionCenterName)
        {
            this.IntelligenceCoefficient = intelligenceCoefficient;
        }

        public int IntelligenceCoefficient { get; set; }
    }
}
