using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Students_by_Age
{
    public class StudentsByAge
    {
        public static void Main()
        {
            var group = new List<string[]>();
            string student;

            while ((student = Console.ReadLine()) != "END")
                group.Add(student.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            group
                .Where(s => int.Parse(s[2]) >= 18 && int.Parse(s[2]) <= 24)
                .Select(s => $"{s[0]} {s[1]} {s[2]}")
                .ToList()
                .ForEach(s => Console.WriteLine(s));
        }
    }
}
