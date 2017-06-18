using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.Group_by_Group
{
    public class GroupByGroup
    {
        public static void Main()
        {
            var group = new List<Person>();
            string student;

            while ((student = Console.ReadLine()) != "END")
            {
                var tokens = student.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                group.Add(new Person(tokens[0] +" "+ tokens[1], int.Parse(tokens[2])));
            }

            var dict = group
                .GroupBy(pr => pr.Group)
                .OrderBy(x => x.Key);
               // .ToDictionary(gr => gr.Key, gr => gr.ToList());

            foreach (var grouped in dict)
            {
                Console.Write(grouped.Key + " - ");
                var sb = new StringBuilder();
                foreach (var person in grouped)
                {
                    sb.Append(person.Name).Append(", ");
                }
                sb.Length -= 2;
                Console.WriteLine(sb);
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Group { get; set; }

        public Person(string name, int group)
        {
            this.Name = name;
            this.Group = group;
        }
    }
}
