namespace _06.Strategy_Pattern
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Comparators;

    public class Program
    {
        public static void Main()
        {
            SortedSet<Person> peopleOrderedByName = new SortedSet<Person>(new PersonNameComparer());
            SortedSet<Person> peopleOrderedByAge = new SortedSet<Person>(new PersonAgeComparator());

            var peopleCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < peopleCount; i++)
            {
                var personInfo = Console.ReadLine()
                    .Split(' ');
                Person person  = new Person(personInfo[0], int.Parse(personInfo[1]));

                peopleOrderedByName.Add(person);
                peopleOrderedByAge.Add(person);
            }

            Console.WriteLine(string.Join(Environment.NewLine, peopleOrderedByName));
            Console.WriteLine(string.Join(Environment.NewLine, peopleOrderedByAge));
        }
    }
}
