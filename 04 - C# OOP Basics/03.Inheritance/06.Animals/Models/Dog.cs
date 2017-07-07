namespace Animals
{
    using System.ComponentModel;

    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return Sounds.DogsSound;
        }
    }
}