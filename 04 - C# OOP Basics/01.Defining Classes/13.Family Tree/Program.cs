namespace FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var allPeople = new List<Person>();
            var personSearched = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Contains("-"))
                {
                    var tokens = input
                        .Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim())
                        .ToArray();

                    var parentParam = tokens[0];
                    var childParam = tokens[1];

                    var parent = new Person(parentParam);
                    var child = new Person(childParam);

                    AddParentIfMissing(allPeople, parent);

                    if (parentParam.Contains("/"))
                        allPeople.SingleOrDefault(p => p.BirthDate == parentParam).AddChild(child);
                    else
                        allPeople.SingleOrDefault(p => p.Name == parentParam).AddChild(child);
                }
                else
                {
                    var tokens = input
                        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                    var name = $"{tokens[0]} {tokens[1]}";
                    var date = tokens[2];
                    CheckForMissingData(allPeople, name, date);
                }
            }

            PrintParentsAndChildren(allPeople, personSearched);
        }

        private static void PrintParentsAndChildren(List<Person> allPeople, string personSearched)
        {
            var result = new StringBuilder();
            Person startPerson = null;
            if (personSearched.Contains("/"))
            {
                startPerson = allPeople.FirstOrDefault(p => p.BirthDate == personSearched);
            }
            else
            {
                startPerson = allPeople.FirstOrDefault(p => p.Name == personSearched);
            }

            result.AppendLine($"{startPerson.Name} {startPerson.BirthDate}");

            result.AppendLine("Parents:");
            foreach (var person in allPeople.Where(p => p.FindChild(startPerson) != null))
            {
                result.AppendLine($"{person.Name} {person.BirthDate}");
            }

            result.AppendLine("Children:");
            foreach (var child in startPerson.Children)
            {
                result.AppendLine($"{child.Name} {child.BirthDate}");
            }

            Console.WriteLine(result);
        }

        private static void AddParentIfMissing(List<Person> allPeople, Person parent)
        {
            if (parent.Name != null && allPeople.SingleOrDefault(c => c.Name == parent.Name) != null)
            {
                return;
            }

            if (parent.BirthDate != null && allPeople.SingleOrDefault(c => c.BirthDate == parent.BirthDate) !=
                     null)
            {
                return;
            }

            allPeople.Add(parent);
        }

        private static void CheckForMissingData(List<Person> allPeople, string name, string date)
        {
            var added = false;
            foreach (var person in allPeople)
            {
                if (person.Name == name)
                {
                    person.BirthDate = date;
                    added = true;
                }
                else if (person.BirthDate == date)
                {
                    person.Name = name;
                    added = true;
                }

                person.AddChildInfo(new Person(name, date));
            }

            if (!added)
                allPeople.Add(new Person(name, date));
        }
    }
}