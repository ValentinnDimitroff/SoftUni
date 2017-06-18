using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Excellent_Students
{
    public class ExcellentStudents
    {
        public static void Main()
        {
            var group = new List<string[]>();
            var domain = "@gmail.com";
            string student;

            while ((student = Console.ReadLine()) != "END")
                group.Add(student.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            group
                .Where(s => s.Any(x => x == "6"))
                .Select(s => $"{s[0]} {s[1]}")
                .ToList()
                .ForEach(s => Console.WriteLine(s));
        }
    }
}
