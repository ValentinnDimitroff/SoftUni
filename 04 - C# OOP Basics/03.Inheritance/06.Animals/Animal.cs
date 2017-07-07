namespace Animals
{
    using System.Text;

    public abstract class Animal
    {
        private string name;
        private int? age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Gender
        {
            get { return this.gender; }
            set
            {
                this.gender = value ?? throw new InvalidInputException();
            }
        }  

        public int? Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidInputException();
                }
                this.age = value;
                // ?? throw new InvalidInputException()
            }
        }  

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value ?? throw new InvalidInputException();
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}")
                .AppendLine($"{this.Name} {this.Age} {this.Gender}")
                .Append(this.ProduceSound());
            return sb.ToString();
        }
    }
}