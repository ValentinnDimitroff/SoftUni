namespace CatLady.Models
{
    public class StreetExtraordinaire : Cat
    {
        private int meowDecibels;

        public StreetExtraordinaire(string name, int decibels) : base(name)
        {
            this.meowDecibels = decibels;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.meowDecibels}";
        }
    }
}
