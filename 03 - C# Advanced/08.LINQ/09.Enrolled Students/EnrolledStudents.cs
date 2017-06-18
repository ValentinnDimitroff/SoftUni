using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Enrolled_Students
{
    public class EnrolledStudents
    {
        public static void Main()
        {
            var group = new List<string[]>();
            string student;

            while ((student = Console.ReadLine()) != "END")
                group.Add(student.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            group
                .Where(s => s[0].EndsWith("14") || s[0].EndsWith("15"))
                .Select(st => st.Skip(1))
                .ToList()
                .ForEach(res => Console.WriteLine(string.Join(" ", res)));
        }
    }
}
