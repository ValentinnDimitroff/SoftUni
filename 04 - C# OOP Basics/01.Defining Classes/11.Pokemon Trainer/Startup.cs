namespace PokemonTrainer
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.ConstrainedExecution;

    public class Startup
    {
        public static void Main()
        {
            var trainers = new Dictionary<string, Trainer>();

            CollectTrainersAndCatchPokemons(trainers);
            GiveBadgesOrRemovePokemons(trainers);
            PrintAllTrainers(trainers);
        }

        private static void PrintAllTrainers(Dictionary<string, Trainer> trainers)
        {
            foreach (var trainer in trainers.OrderByDescending(t => t.Value.NumberOfBadges))
            {
                Console.WriteLine(trainer.Value);
            }
        }

        private static void GiveBadgesOrRemovePokemons(Dictionary<string, Trainer> trainers)
        {
            string inputElement;
            while ((inputElement = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(p => p.Element == inputElement))
                    {
                        trainer.Value.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.Value.PokemonsTakeDamage();
                    }
                }
            }
        }

        private static void CollectTrainersAndCatchPokemons(Dictionary<string, Trainer> trainers)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Tournament")
            {
                var tokens = inputLine.Split(' ');
                var trainerName = tokens[0];
                var pokemonName = tokens[1];
                var pokemonElement = tokens[2];
                var pokemonHealth = int.Parse(tokens[3]);

                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(trainerName);
                }
                
                trainers[trainerName].AddPokemon(pokemon);
            }
        }
    }
}
