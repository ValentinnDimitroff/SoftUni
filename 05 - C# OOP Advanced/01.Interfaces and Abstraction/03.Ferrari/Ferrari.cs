namespace _03.Ferrari
{
    public class Ferrari : ICar
    {
        public Ferrari(string driver)
        {
            this.Driver = driver;
        }

        public string Model => "488-Spider";
        public string Driver { get; }

        public string PushBrakesPedal()
        {
            return "Brakes!";
        }

        public string PushGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.PushBrakesPedal()}/{this.PushGasPedal()}/{this.Driver}";
        }
    }
}
