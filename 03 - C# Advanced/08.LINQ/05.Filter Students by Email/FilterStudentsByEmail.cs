using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Filter_Students_by_Email
{
    public class FilterStudentsByEmail
    {
        public static void Main()
        {
            var group = new List<string[]>();
            var domain = "@gmail.com";
            string student;

            while ((student = Console.ReadLine()) != "END")
                group.Add(student.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            group
                .Where(s => s[2].Contains(domain))
                .Select(s => $"{s[0]} {s[1]}")
                .ToList()
                .ForEach(s => Console.WriteLine(s));
        }
    }
}
