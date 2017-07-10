namespace Paws_Inc.Models.Centers
{
    using System.Collections.Generic;
    using Animals;
    using Paws_Inc.Centers;

    public abstract class TreatmentCenter : Center
    {
        public TreatmentCenter(string name) : base(name)
        {
        }

        protected abstract void TreatAnimals();

        public List<Animal> GetTreatedAnimals()
        {
            this.TreatAnimals();
            List<Animal> animalsToSendBack = new List<Animal>();

            foreach (var storedAnimal in this.StoredAnimals)
            {
                animalsToSendBack.Add(storedAnimal);
            }
            this.StoredAnimals.Clear();

            return animalsToSendBack;
        }
    }
}
