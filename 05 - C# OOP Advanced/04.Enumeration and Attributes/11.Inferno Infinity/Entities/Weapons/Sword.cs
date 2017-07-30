namespace _11.Inferno_Infinity.Entities.Weapons
{
    using Enums;

    public class Sword : Weapon
    {
        private const int SwordMinDamage = 4;
        private const int SwordMaxDamage = 6;
        private const int NumberOfSockets = 3;

        public Sword(string name, Rarity damageModifier) 
            : base(name, SwordMinDamage, SwordMaxDamage, NumberOfSockets, damageModifier)
        {
        }
    }
}