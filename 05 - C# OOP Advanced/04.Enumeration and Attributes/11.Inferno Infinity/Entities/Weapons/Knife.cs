namespace _11.Inferno_Infinity.Entities.Weapons
{
    using Enums;

    public class Knife : Weapon
    {
        private const int KnifeMinDamage = 3;
        private const int KnifeMaxDamage = 4;
        private const int NumberOfSockets = 2;

        public Knife(string name, Rarity damageModifier) 
            : base(name, KnifeMinDamage, KnifeMaxDamage, NumberOfSockets, damageModifier)
        {
        }
    }
}