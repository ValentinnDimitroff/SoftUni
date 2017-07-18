namespace _08.Military_Elite
{
    using System;
    using System.Collections.Generic;
    using Entities;
    using Entities.Soldiers.Privates.SpecialisedSoldiers;
    using Interfaces;

    public class Program
    {
        public static void Main()
        {
            var allSoldiers = new Dictionary<string, ISoldier>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var tokens = inputLine.Split(' ');
                var soldierType = tokens[0];
                var id = tokens[1];
                var firstName = tokens[2];
                var lastName = tokens[3];

                switch (soldierType)
                {
                    case "Private":
                    {
                        var salary = double.Parse(tokens[4]);
                        allSoldiers.Add(id, new Private(id, firstName, lastName, salary));
                        break;
                    }
                    case "LeutenantGeneral":
                    {
                        double salary = double.Parse(tokens[4]);
                        List<ISoldier> privates = new List<ISoldier>();
                        for (int i = 5; i < tokens.Length; i++)
                        {
                            var privateId = tokens[i];
                            privates.Add(allSoldiers[privateId]);
                        }
                        allSoldiers.Add(id, new LeutenantGeneral(id, firstName, lastName, salary, privates));
                        break;
                    }
                    case "Engineer":
                    {
                        double salary = double.Parse(tokens[4]);
                        string corps = tokens[5];
                        List<IRepair> repairs = new List<IRepair>();
                        for (int i = 6; i < tokens.Length; i = i + 2)
                        {
                            string partName = tokens[i];
                            int hoursWorked = int.Parse(tokens[i + 1]);
                            IRepair repair = new Repair(partName, hoursWorked);
                            repairs.Add(repair);
                        }
                        try
                        {
                            allSoldiers.Add(id, new Engineer(id, firstName, lastName, salary, corps, repairs));
                        }
                        catch (ArgumentException)
                        {
                        }
                        break;
                    }
                    case "Commando":
                    {
                        double salary = double.Parse(tokens[4]);
                        string corps = tokens[5];
                        List<IMission> missions = new List<IMission>();
                        for (int i = 6; i < tokens.Length; i = i + 2)
                        {
                            string codeName = tokens[i];
                            string state = tokens[i + 1];
                            try
                            {
                                IMission mission = new Mission(codeName, state);
                                missions.Add(mission);
                            }
                            catch (ArgumentException)
                            {
                            }
                        }
                        try
                        {
                            allSoldiers.Add(id, new Commando(id, firstName, lastName, salary, corps, missions));
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    }
                    case "Spy":
                    {
                        var codeNumber = tokens[4];
                        allSoldiers.Add(id, new Spy(id, firstName, lastName, int.Parse(codeNumber)));
                        break;
                    }
                }
            }

            foreach (var soldier in allSoldiers)
            {
                Console.WriteLine(soldier.Value);
            }
        }
    }
}