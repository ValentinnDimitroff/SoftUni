namespace Paws_Inc.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, int commandsLearned, string adoptionCenterName)
            : base(name, age, adoptionCenterName)
        {
            this.CommandsLearned = commandsLearned;
        }

        private int CommandsLearned { get; set; }
    }
}
