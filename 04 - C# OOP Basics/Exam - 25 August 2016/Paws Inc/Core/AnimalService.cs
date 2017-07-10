namespace Paws_Inc.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Animals;
    using Centers;
    using Models.Centers;

    public class AnimalService
    {
        private Dictionary<string, AdoptionCenter> adoptionCenters;
        private Dictionary<string, CleansingCenter> cleansingCenters;
        private Dictionary<string, CastrationCenter> castrationCenters;
        private List<Animal> cleansedAnimals;
        private List<Animal> adoptedAnimals;
        private List<Animal> castratedAnimals;

        public AnimalService()
        {
            this.adoptionCenters = new Dictionary<string, AdoptionCenter>();
            this.cleansingCenters = new Dictionary<string, CleansingCenter>();
            this.castrationCenters = new Dictionary<string, CastrationCenter>();
            this.cleansedAnimals = new List<Animal>();
            this.adoptedAnimals = new List<Animal>();
            this.castratedAnimals = new List<Animal>();
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
                case "RegisterCastrationCenter":
                    this.RegisterCastrationCenter(commandArguments[0]);
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
                case "SendForCastration":
                    this.SendAnimalsForCastration(commandArguments);
                    break;
                case "Cleanse":
                    this.CleanseAnimals(commandArguments);
                    break;
                case "Castrate":
                    this.CastrateAnimals(commandArguments);
                    break;
                case "Adopt":
                    this.AdoptAnimals(commandArguments);
                    break;
                case "CastrationStatistics":
                    this.ShowStatistics("castration");
                    break;
                case "Paw Paw Pawah":
                    this.ShowStatistics("regular");
                    return false;
            }

            return true;
        }

        private void ShowStatistics(string statisticType)
        {
            var stasticsText = this.GetStatistics(statisticType);
            this.WriteOutput(stasticsText);
        }

        private void WriteOutput(string stasticsText)
        {
            Console.WriteLine(stasticsText);
        }

        private string GetStatistics(string statisticType)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Paw Incorporative Regular Statistics");

            if (statisticType == "regular")
            {
                var adoptedAnimalsStr = this.adoptedAnimals.Count > 0
                    ? string.Join(", ", this.adoptedAnimals.OrderBy(a => a.Name).Select(a => a.Name))
                    : "None";
                var cleansedAnimalsStr = this.cleansedAnimals.Count > 0
                    ? string.Join(", ", this.cleansedAnimals.OrderBy(a => a.Name).Select(a => a.Name))
                    : "None";
                sb.AppendLine($"Adoption Centers: {this.adoptionCenters.Count}")
                    .AppendLine($"Cleansing Centers: {this.cleansingCenters.Count}")
                    .AppendLine($"Adopted Animals: {adoptedAnimalsStr}")
                    .AppendLine($"Cleansed Animals: {cleansedAnimalsStr}")
                    .AppendLine(
                        $"Animals Awaiting Adoption: {this.adoptionCenters.SelectMany(a => a.Value.GetAnimalsReadyForAdoption()).Count()}")
                    .Append($"Animals Awaiting Cleansing: {this.cleansingCenters.Sum(c => c.Value.GetAnimalsNumber())}");
            }
            else if (statisticType == "castration")
            {
                var castratedAnimalsStr = this.castratedAnimals.Count > 0
                    ? string.Join(", ", this.castratedAnimals.OrderBy(a => a.Name).Select(a => a.Name))
                    : "None";
                sb.AppendLine($"Castration Centers: {this.castrationCenters.Count}")
                    .Append($"Castrated Animals: {castratedAnimalsStr}");
            }
            
            return sb.ToString();
        }

        private void AdoptAnimals(List<string> commandArguments)
        {
            var adoptionCenterName = commandArguments[0];
            var animalsForAdoption = adoptionCenters[adoptionCenterName].AdoptCleansedAnimals();
            this.adoptedAnimals.AddRange(animalsForAdoption);
        }

        private void CastrateAnimals(List<string> commandArguments)
        {
            var castrationCenterName = commandArguments[0];

            var animalsTreated = this.castrationCenters[castrationCenterName].GetTreatedAnimals();
            this.castratedAnimals.AddRange(animalsTreated);
            this.SendTreatAnimalsBack(animalsTreated);
        }

        private void CleanseAnimals(List<string> commandArguments)
        {
            var cleansingCenter = commandArguments[0];

            var animalsCleansed = this.cleansingCenters[cleansingCenter].GetTreatedAnimals();
            this.cleansedAnimals.AddRange(animalsCleansed);
            this.SendTreatAnimalsBack(animalsCleansed);
        }

        private void SendTreatAnimalsBack(IList<Animal> animalsTreat)
        {
            foreach (var treatAnimal in animalsTreat)
            {
                this.adoptionCenters[treatAnimal.AdoptionCenterName].AddAnimal(treatAnimal);
            }
        }

        private void SendAnimalsForCastration(List<string> commandArguments)
        {
            var adoptionCenterName = commandArguments[0];
            var castrationCenterName = commandArguments[1];

            var animalsForCastration = this.adoptionCenters[adoptionCenterName].SendAnimalsForCastration();
            this.castrationCenters[castrationCenterName].ReceiveAnimals(animalsForCastration);
        }

        private void SendAnimalsForCleansing(List<string> commandArguments)
        {
            var adoptionCenterName = commandArguments[0];
            var cleansingCenterName = commandArguments[1];

            var uncleansedAnimals = this.adoptionCenters[adoptionCenterName].SendAnimalsForCleansing();
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

        private void RegisterCastrationCenter(string centerName)
        {
            this.castrationCenters[centerName] = new CastrationCenter(centerName);
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
