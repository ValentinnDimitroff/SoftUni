namespace _11.Inferno_Infinity.Entities
{
    using System;
    using System.Linq;
    using Enums;
    using Interfaces;

    public abstract class Weapon : IWeapon
    {
        private int minDamage;
        private int maxDamage;
        private int strength;
        private int agility;
        private int vitality;
        
        protected Weapon(string name, int minDamage, int maxDamage, int numberOfSockets, Rarity damageModifier)
        {
            this.Name = name;
            this.Sockets = new IGem[numberOfSockets];
            this.DamageModifier = damageModifier;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
        }

        public string Name { get; }

        public int MaxDamage
        {
            get => this.maxDamage * (int) this.DamageModifier + 3 * this.Sockets.Where(x => x != null).Sum(g => g.Strength) + 4 * this.Sockets.Where(x => x != null).Sum(g => g.Agility);
            set => this.maxDamage = value;
        }

        public int MinDamage
        {
            get => this.minDamage * (int) this.DamageModifier + 2 * this.Sockets.Where(x => x != null).Sum(g => g.Strength) + this.Sockets.Where(x => x != null).Sum(g => g.Agility);
            set => this.minDamage = value;
        }

        public IGem[] Sockets { get; }

        public Rarity DamageModifier { get; }

        public int Vitality => this.Sockets.Where(x => x != null).Sum(g => g.Vitality);
        

        public int Agility
        {
            get => this.Sockets.Where(x => x != null).Sum(g => g.Agility);
            set => this.agility = value; 
        }

        public int Strength
        {
            get => this.Sockets.Where(x => x != null).Sum(g => g.Strength);
            set => this.strength = value; 
        }

        public void InsertGem(IGem gem, int index)
        {
            if (index < 0 || index >= this.Sockets.Length)
            {
                return;
            }
            this.Sockets[index] = gem;
        }

        public void RemoveGem(int index)
        {
            if (index < 0 || index >= this.Sockets.Length)
            {
                return;
            }
            this.Sockets[index] = null;
        }

        public void Print()
        {
            Console.WriteLine($"{this.Name}: {this.MinDamage}-{this.MaxDamage} Damage, +{this.Strength} Strength, " +
                              $"+{this.Agility} Agility, +{this.Vitality} Vitality");
        }
    }
}