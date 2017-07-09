namespace Paws_Inc.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Animals;
    using Centers;

    public class AnimalService
    {
        private Dictionary<string, AdoptionCenter> adoptionCenters;
        private Dictionary<string, CleansingCenter> cleansingCenters;
        private List<Animal> cleansedAnimals;
        private List<Animal> adoptedAnimals;

        public AnimalService()
        {
            this.adoptionCenters = new Dictionary<string, AdoptionCenter>();
            this.cleansingCenters = new Dictionary<string, CleansingCenter>();
            this.cleansedAnimals = new List<Animal>();
            this.adoptedAnimals = new List<Animal>();
        }
        public bool ManageCommand(List<string> commandArguments)
        {
            var commandName = commandArguments[0];
            commandArguments.Remove(commandName);

            switch (commandName)
            {
                case "RegisterAdoptionCenter":
                    this.RegisterAdoptionCenter(commandArguments[0]);
                    break;
                case "RegisterCleansingCenter":
                    this.RegisterCleansingCenter(commandArguments[0]);
                    break;
                case "RegisterDog":
                    this.RegisterDog(commandArguments);
                    break;
                case "RegisterCat":
                    this.RegisterCat(commandArguments);
                    break;
                case "SendForCleansing":
                    this.SendAnimalsForCleansing(commandArguments);
                    break;
                case "Cleanse":
                    this.CleanseAnimals(commandArguments);
                    break;
                case "Adopt":
                    this.AdopteAnimals(commandArguments);
                    break;
                case "Paw Paw Pawah":
                    this.ShowStatistics();
                    return false;
            }

            return true;
        }

        private void ShowStatistics()
        {
            var stasticsText = this.GetStatistics();
            this.WriteOutput(stasticsText);
        }

        private void WriteOutput(string stasticsText)
        {
            Console.WriteLine(stasticsText);
        }

        private string GetStatistics()
        {
            var adoptedAnimalsStr = this.adoptedAnimals.Count > 0
                ? string.Join(", ", this.adoptedAnimals.OrderBy(a => a.Name).Select(a => a.Name))
                : "None";
            var cleansedAnimalsStr = this.cleansedAnimals.Count > 0
                ? string.Join(", ", this.cleansedAnimals.OrderBy(a => a.Name).Select(a => a.Name))
                : "None";
            var sb = new StringBuilder();
            sb.AppendLine("Paw Incorporative Regular Statistics")
                .AppendLine($"Adoption Centers: {this.adoptionCenters.Count}")
                .AppendLine($"Cleansing Centers: {this.cleansingCenters.Count}")
                .AppendLine($"Adopted Animals: {adoptedAnimalsStr}")
                .AppendLine($"Cleansed Animals: {cleansedAnimalsStr}")
                .AppendLine(
                    $"Animals Awaiting Adoption: {this.adoptionCenters.SelectMany(a => a.Value.GetAnimalsReadyForAdoption()).Count()}")
                .AppendLine($"Animals Awaiting Cleansing: {this.cleansingCenters.Sum(c => c.Value.GetAnimalsWaitingNumber())}");

            return sb.ToString();
        }

        private void AdopteAnimals(List<string> commandArguments)
        {
            var adoptionCenterName = commandArguments[0];
            var animalsForAdoption = adoptionCenters[adoptionCenterName].AdopteCleansedAnimals();
            this.adoptedAnimals.AddRange(animalsForAdoption);
        }

        private void CleanseAnimals(List<string> commandArguments)
        {
            var cleansingCenter = commandArguments[0];

            var animalsCleansed = this.cleansingCenters[cleansingCenter].GetCleansedAnimals();
            this.cleansedAnimals.AddRange(animalsCleansed);
            this.SendCleansedAnimalsBack(animalsCleansed);
        }

        private void SendCleansedAnimalsBack(IList<Animal> animalsCleansed)
        {
            foreach (var cleansedAnimal in animalsCleansed)
            {
                this.adoptionCenters[cleansedAnimal.AdoptionCenterName].AddAnimal(cleansedAnimal);
            }
        }

        private void SendAnimalsForCleansing(List<string> commandArguments)
        {
            var adoptionCenterName = commandArguments[0];
            var cleansingCenterName = commandArguments[1];

            var uncleansedAnimals = this.adoptionCenters[adoptionCenterName].SendAnimalsForCleasing();
            this.cleansingCenters[cleansingCenterName].ReceiveAnimals(uncleansedAnimals);
        }

        private void RegisterCat(List<string> commandArguments)
        {
            var catsName = commandArguments[0];
            var catsAge = int.Parse(commandArguments[1]);
            var catsInteligenceCoefficient = int.Parse(commandArguments[2]);
            var adoptionCentersName = commandArguments[3];

            var cat = new Dog(catsName, catsAge, catsInteligenceCoefficient, adoptionCentersName);
            adoptionCenters[adoptionCentersName].AddAnimal(cat);
        }

        private void RegisterDog(List<string> commandArguments)
        {
            var dogsName = commandArguments[0];
            var dogsAge = int.Parse(commandArguments[1]);
            var dogsLearnedCommands = int.Parse(commandArguments[2]);
            var adoptionCentersName = commandArguments[3];

            var dog = new Dog(dogsName, dogsAge, dogsLearnedCommands, adoptionCentersName);
            adoptionCenters[adoptionCentersName].AddAnimal(dog);
        }

        private void RegisterCleansingCenter(string centerName)
        {
            this.cleansingCenters[centerName] = new CleansingCenter(centerName);
        }

        private void RegisterAdoptionCenter(string centerName)
        {
            this.adoptionCenters[centerName] = new AdoptionCenter(centerName);
        }
    }
}
