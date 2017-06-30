namespace CarSalesman
{
    using System;
    using System.Text;

    public class Car
    {
        private string model;
        private Engine engine;
        
        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }

        public double? Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append($"{this.model}:").AppendLine();
            result.Append($"  {this.engine.Model}:").AppendLine();
            result.Append($"    Power: {this.engine.Power}").AppendLine();
            result.Append($"    Displacement: {(this.engine.Displacement == null ? "n/a" : this.engine.Displacement.ToString())}").AppendLine();
            result.Append($"    Efficiency: {this.engine.Efficiency ?? "n/a"}").AppendLine();
            result.Append($"  Weight: {(this.Weight == null ? "n/a" : this.Weight.ToString())}").AppendLine();
            result.Append($"  Color: {this.Color ?? "n/a"}");
            return result.ToString();
        }
    }
}
