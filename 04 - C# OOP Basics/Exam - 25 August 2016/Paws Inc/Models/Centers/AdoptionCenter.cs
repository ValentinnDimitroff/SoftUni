namespace Paws_Inc.Centers
{
    using System.Collections.Generic;
    using System.Linq;
    using Animals;

    public class AdoptionCenter : Center
    {
        public AdoptionCenter(string name) 
            : base(name) {}

        public void AddAnimal(Animal animal)
        {
            this.StoredAnimals.Add(animal);
        }

        public List<Animal> SendAnimalsForCleasing()
        {
            var uncleansedAnimals = this.StoredAnimals.Where(a => a.CleansingStatus == false).ToList();
            this.StoredAnimals.RemoveAll(a => a.CleansingStatus == false);
            return uncleansedAnimals;
        }

        public List<Animal> AdopteCleansedAnimals()
        {
            var cleansedAnimals = this.StoredAnimals.Where(a => a.CleansingStatus == true).ToList();
            this.StoredAnimals.RemoveAll(a => a.CleansingStatus == true);
            return cleansedAnimals;
        }

        public List<Animal> GetAnimalsReadyForAdoption()
        {
            return this.StoredAnimals.Where(a => a.CleansingStatus == true).ToList();
        }
    }
}
