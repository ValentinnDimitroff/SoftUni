namespace _11.Inferno_Infinity.Interfaces
{
    using Enums;

    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        IGem[] Sockets { get; }

        Rarity DamageModifier { get; }

        void InsertGem(IGem gem, int index);

        void RemoveGem(int index);

        void Print();
    }
}