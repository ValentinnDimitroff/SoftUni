namespace _11.Inferno_Infinity.Factories
{
    using System;
    using Entities.Weapons;
    using Enums;
    using Interfaces;

    public class WeaponFactory
    {
        public IWeapon ProduceWeapon(string typeAndRarity, string name)
        {
            string[] typeAndRaritySplit = typeAndRarity.Split();
            Rarity rarity = (Rarity)Enum.Parse(typeof(Rarity), typeAndRaritySplit[0]);

            switch (typeAndRaritySplit[1])
            {
                case "Axe":
                    return new Axe(name, rarity);
                case "Sword":
                    return new Sword(name, rarity);
                case "Knife":
                    return new Knife(name, rarity);
                default:
                    return null;
            }
        }
    }
}