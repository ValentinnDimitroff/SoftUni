namespace _05.Comparing_Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            IList<Person> people = new List<Person>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                var tokens = inputLine.Split(' ');
                people.Add(new Person(tokens[0], int.Parse(tokens[1]), tokens[2]));
            }

            var personIndex = int.Parse(Console.ReadLine());
            var equalPeople = people.Count(p => p.CompareTo(people[personIndex - 1]) == 0);

            if (equalPeople > 1)
                Console.WriteLine($"{equalPeople} {people.Count - equalPeople} {people.Count }");
            else
                Console.WriteLine("No matches"); 
        }
    }
}
