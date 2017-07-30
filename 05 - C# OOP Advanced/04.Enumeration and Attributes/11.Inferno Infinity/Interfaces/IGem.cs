namespace _11.Inferno_Infinity.Interfaces
{
    using Enums;

    public interface IGem
    {
        int Strength { get; }

        int Agility { get; }

        int Vitality { get; }

        ClarityLevel Clarity { get; }
    }
}