namespace _08.Pet_Clinic
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using Entites;

    public class Program
    {
        public static void Main()
        {
            var allClinics = new Dictionary<string, Clinic>();
            var allPets = new Dictionary<string, Pet>();

            var commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                var commandTokens = Console.ReadLine().Split();

                switch (commandTokens[0])
                {
                    case "Create":
                        if (commandTokens[1] == "Clinic")
                        {
                            try
                            {
                                allClinics.Add(commandTokens[2],
                                    new Clinic(commandTokens[2], int.Parse(commandTokens[3])));
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid Operation!");
                            }
                        }
                        else if (commandTokens[1] == "Pet")
                        {
                            allPets.Add(commandTokens[2],
                                new Pet(commandTokens[2], int.Parse(commandTokens[3]), commandTokens[4]));
                        }
                        break;
                    case "Add":
                        var pet = allPets[commandTokens[1]];
                        var apointedClinic = allClinics[commandTokens[2]];
                        if (apointedClinic.TryAddPet(pet))
                        {
                            Console.WriteLine(true);
                            allPets.Remove(pet.Name);
                        }
                        else
                        {
                            Console.WriteLine(false);
                        }
                        break;
                    case "Release":
                        Console.WriteLine(allClinics[commandTokens[1]].TryReleasePet());
                        break;
                    case "HasEmptyRooms":
                        Console.WriteLine(allClinics[commandTokens[1]].HasEmptyRooms());
                        break;
                    case "Print":
                        if (commandTokens.Length == 2)
                        {
                            Console.WriteLine(allClinics[commandTokens[1]].Print());
                        }
                        else
                        {
                            Console.WriteLine(allClinics[commandTokens[1]].Print(int.Parse(commandTokens[2]) - 1));
                        }
                        break;
                }
            }
        }
    }
}