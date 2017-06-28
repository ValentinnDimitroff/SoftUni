namespace OpinionPoll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var allPeople = new List<Person>();
            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var personInputInfo = Console.ReadLine().Split(' ');
                var person = new Person(
                    personInputInfo[0],
                    int.Parse(personInputInfo[1]));
                allPeople.Add(person);
            }

            allPeople
                .Where(p => p.age > 30)
                .OrderBy(p => p.name)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.name} - {p.age}"));
        }
    }
}