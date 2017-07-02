namespace Google
{
    using System;
    using System.Collections.Generic;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            var allPeople = new Dictionary<string, Person>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(' ');
                var name = tokens[0];

                if (!allPeople.ContainsKey(name))
                {
                    allPeople[name] = new Person(name);
                }
                var command = tokens[1];

                switch (command)
                {
                    case "company":
                        allPeople[name].Company = new Company(tokens[2], tokens[3], decimal.Parse(tokens[4]));
                        break;
                    case "pokemon":
                        allPeople[name].AddPokemon(new Pokemon(tokens[2], tokens[3]));
                        break;
                    case "parents":
                        allPeople[name].AddParent(new Relative(tokens[2], tokens[3]));
                        break;
                    case "children":
                        allPeople[name].AddChild(new Relative(tokens[2], tokens[3]));
                        break;
                    case "car":
                        allPeople[name].Car = new Car(tokens[2], double.Parse(tokens[3]));
                        break;
                }
            }

            var nameToFind = Console.ReadLine();
            Console.WriteLine(allPeople[nameToFind]);
        }
    }
}
