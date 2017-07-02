namespace Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Models;

    public class Person
    {
        private List<Relative> parents;
        private List<Relative> children;
        private List<Pokemon> pokemons;

        public Person(string name)
        {
            this.Name = name;
            this.parents = new List<Relative>();
            this.children = new List<Relative>();
            this.pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public Company Company { get; set; }

        public Car Car { get; set; }

        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }

        public void AddParent(Relative parent)
        {
            this.parents.Add(parent);
        }

        public void AddChild(Relative child)
        {
            this.children.Add(child);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(this.Name);
            result.AppendLine("Company:");
            if (this.Company != null)
            {
                result.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:f2}");
            }

            result.AppendLine("Car:");
            if (this.Car != null)
            {
                result.AppendLine($"{this.Car.Model} {this.Car.Speed}");
            }

            result.AppendLine("Pokemon:");
            if (this.pokemons.Count > 0)
                result.AppendLine(string.Join(Environment.NewLine, this.pokemons.Select(p => $"{p.Name} {p.Type}")));

            result.AppendLine("Parents:");
            if (this.parents.Count > 0)
            {
                result.AppendLine(string.Join(Environment.NewLine, this.parents.Select(p => $"{p.Name} {p.BirthDate}")));
            }    
            
            result.AppendLine("Children:");
            if (this.children.Count > 0)
            {
                result.AppendLine(string.Join(Environment.NewLine, this.children.Select(p => $"{p.Name} {p.BirthDate}")));
            }

            return result.ToString();
        }
    }
}
