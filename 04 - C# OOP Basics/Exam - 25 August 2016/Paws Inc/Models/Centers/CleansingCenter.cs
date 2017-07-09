namespace Paws_Inc.Centers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using Animals;

    public class CleansingCenter : Center
    {
        public CleansingCenter(string name) 
            : base(name) {}

        public void ReceiveAnimals(List<Animal> animalsForCleansing)
        {
            this.StoredAnimals.AddRange(animalsForCleansing);
        }

        private void CleanseAnimals()
        {
            foreach (var animal in this.StoredAnimals)
                animal.Cleanse();
        }

        public List<Animal> GetCleansedAnimals()
        {
            this.CleanseAnimals();
            var animalsToSendBack = new List<Animal>();

            foreach (var storedAnimal in this.StoredAnimals)
            {
                animalsToSendBack.Add(storedAnimal);
            }
            this.StoredAnimals.Clear();

            return animalsToSendBack;
        }

        public int GetAnimalsWaitingNumber()
        {
            return this.StoredAnimals.Count;
        }
    }
}
