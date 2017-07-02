namespace CatLady.Models
{
    using System;

    public class Siamese : Cat
    {
        private double earSize;
        public Siamese(string name, int earSize) : base(name)
        {
            this.earSize = earSize;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.earSize}";
        }
    }
}
