namespace Google.Models
{
    public class Car
    {
        public Car(string model, double speed)
        {
            this.Model = model;
            this.Speed = speed;
        }
        public string Model { get; set; }
        public double Speed { get; set; }
    }
}
