namespace CarSalesman
{
    using System.Security.AccessControl;

    public class Engine
    {
       public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Efficiency = "n/a";
        }

        public int Power { get; set; }
        public double? Displacement { get; set; }   
        
        public string Efficiency { get; set; }

        public string Model { get; set; }
    }
}
