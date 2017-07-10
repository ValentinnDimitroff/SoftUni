namespace Paws_Inc.Animals
{
    public abstract class Animal
    {
        protected Animal(string name, int age, string adoptionCenterName)
        {
            this.Name = name;
            this.Age = age;
            this.AdoptionCenterName = adoptionCenterName;
            this.CleansingStatus = false;
            this.Castrated = false;
        }

        public string Name { get; private set; }
        private int Age { get; set; }
        public bool CleansingStatus { get; private set; }
        public bool Castrated { get; private set; }
        public string AdoptionCenterName { get; set; }

        public void Cleanse() => this.CleansingStatus = true;
        public void Castrate() => this.Castrated = true;
    }
}
