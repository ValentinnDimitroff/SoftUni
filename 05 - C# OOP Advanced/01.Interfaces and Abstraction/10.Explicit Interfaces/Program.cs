namespace _10.Explicit_Interfaces
{
    using System;
    using Entites;
    using Interfaces;

    public class Program
    {
        public static void Main()
        {
            string inputCitizen;
            while ((inputCitizen = Console.ReadLine()) != "End")
            {
                var tokens = inputCitizen.Split(' ');
                var citizen = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));
                IResident resident = citizen;
                IPerson person = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
