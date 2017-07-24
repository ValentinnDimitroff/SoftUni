namespace _07.Equalty_Logic
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            HashSet<Person> peopleHashed = new HashSet<Person>();
            SortedSet<Person> peopleSorted = new SortedSet<Person>();

            var peopleCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < peopleCount; i++)
            {
                var personInfo = Console.ReadLine()
                    .Split(' ');
                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));

                peopleHashed.Add(person);
                peopleSorted.Add(person);
            }

            Console.WriteLine(peopleHashed.Count);
            Console.WriteLine(peopleSorted.Count);
        }
    }
}
