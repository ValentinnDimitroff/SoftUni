namespace PokemonTrainer
{
    using System.Collections.Generic;
    using System.Linq;

    public class Trainer
    {
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int NumberOfBadges { get; set; }

        public IReadOnlyList<Pokemon> Pokemons
        {
            get { return this.pokemons.AsReadOnly(); }
        }

        public void PokemonsTakeDamage()
        {
            for (int i = this.pokemons.Count - 1; i >= 0; i--)
            {
                if (this.pokemons[i].Health <= 10)
                {
                    this.pokemons.RemoveAt(i);
                }
                else
                {
                    pokemons[i].Health -= 10;
                }
            }
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }

        public override string ToString()
        {
            return $"{this.Name} {this.NumberOfBadges} {this.pokemons.Count}";
        }
    }
}