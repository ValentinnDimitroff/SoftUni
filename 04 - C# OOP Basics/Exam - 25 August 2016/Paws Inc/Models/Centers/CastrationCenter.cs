namespace Paws_Inc.Models.Centers
{
    using Paws_Inc.Centers;
    public class CastrationCenter : TreatmentCenter
    {
        public CastrationCenter(string name) : base(name)
        {
        }

        protected override void TreatAnimals()
        {
            foreach (var animal in this.StoredAnimals)
                animal.Castrate();
        }
    }
}
