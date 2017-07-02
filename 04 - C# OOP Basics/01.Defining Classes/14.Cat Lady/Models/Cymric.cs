namespace CatLady.Models
{
    public class Cymric : Cat
    {
        private double furLenght;
        public Cymric(string name, double furLenght) : base(name)
        {
            this.furLenght = furLenght;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.furLenght:f2}";
        }
    }
}
