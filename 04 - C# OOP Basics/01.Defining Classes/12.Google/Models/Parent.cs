namespace Google.Models
{
    public class Relative
    {
        public Relative(string name, string date)
        {
            this.Name = name;
            this.BirthDate = date;
        }
        public string Name { get; set; }
        public string BirthDate { get; set; }
    }
}
