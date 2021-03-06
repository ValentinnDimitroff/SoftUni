﻿namespace Paws_Inc.Centers
{
    using System.Collections.Generic;
    using Animals;

    public abstract class Center
    {
        protected Center(string name)
        {
            this.Name = name;
            this.StoredAnimals = new List<Animal>();
        }

        public string Name { get; private set; }
        protected List<Animal> StoredAnimals { get; set; }

        public void ReceiveAnimals(List<Animal> animalsForTreating)
        {
            this.StoredAnimals.AddRange(animalsForTreating);
        }
        public int GetAnimalsNumber() => this.StoredAnimals.Count;
    }
}
