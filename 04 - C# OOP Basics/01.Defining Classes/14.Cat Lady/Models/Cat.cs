namespace CatLady.Models
{
    public class Cat
    {
       public Cat(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} {this.Name}";
        }
    }
}
