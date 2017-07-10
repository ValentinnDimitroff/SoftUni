namespace Paws_Inc.Centers
{
    using Models.Centers;

    public class CleansingCenter : TreatmentCenter
    {
        public CleansingCenter(string name) 
            : base(name) {}

        protected override void TreatAnimals()
        {
            foreach (var animal in this.StoredAnimals)
                animal.Cleanse();
        }
    }
}
