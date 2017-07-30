﻿namespace _11.Inferno_Infinity.Entities.Weapons
{
    using Enums;

    public class Axe : Weapon
    {
        private const int AxeMinDamage = 5;
        private const int AxeMaxDamage = 10;
        private const int NumberOfSockets = 4;

        public Axe(string name, Rarity damageModifier) 
            : base(name, AxeMinDamage, AxeMaxDamage, NumberOfSockets, damageModifier)
        {
        }
    }
}