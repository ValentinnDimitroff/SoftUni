using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Students
{
    public class SortStudents
    {
        public static void Main()
        {
            var group = new List<string[]>();
            string student;

            while ((student = Console.ReadLine()) != "END")
                group.Add(student.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            group
                .OrderBy(s => s[1])
                .ThenByDescending(s => s[0])
                .Select(s => $"{s[0]} {s[1]}")
                .ToList()
                .ForEach(s => Console.WriteLine(s));
        }
    }
}
