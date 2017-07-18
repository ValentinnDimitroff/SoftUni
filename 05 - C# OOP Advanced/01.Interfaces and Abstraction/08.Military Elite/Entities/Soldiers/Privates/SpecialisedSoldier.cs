namespace _08.Military_Elite.Entities
{
    using System;
    using Interfaces;
    public abstract class SpecialisedSoldier : Private, ISpecialSoldier
    {
        private string corps;

        public SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get => this.corps;
            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException();
                }

                this.corps = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps: {this.Corps}";
        }
    }
}
