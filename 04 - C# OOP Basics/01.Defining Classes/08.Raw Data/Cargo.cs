namespace RawData
{
    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.type = type;
            this.weight = weight;
        }

        private int weight;
        private string type;

        public string Type
        {
            get { return this.type; }
        }
    }
}
